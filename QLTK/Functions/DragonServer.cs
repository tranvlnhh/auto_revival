using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using QLTK.Properties;
using System.Threading;
using LitJson;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using QLTK.Models;
using System.Security.Principal;
using QLTK.UserControls;

namespace QLTK.Functions
{
    class State
    {
        public State()
        {
            buffer = new byte[BufferSize];
        }

        // Size of receive buffer.  
        public const int BufferSize = 1024;

        // Receive buffer.  
        public byte[] buffer;

        public Socket sc = null;
        public Account account = null;
    }

    internal static class DragonServer
    {
        static Socket listener;
        static ManualResetEvent allDone = new ManualResetEvent(false);
        static void onMessage(JsonData msg, State state)
        {
            var cmd = (string)msg["cmd"];
            switch (cmd)
            {
                case "isDelay":
                    mainForm.gI.dashboard.lastTimeRevival = Utils.currentTimeMillis();
                    mainForm.gI.dashboard.checkSend = false;
                    sendDelay(true);
                    break;
                case "set-status":
                    state.account.status = (string)msg["status"];
                    break;
                case "set-map-zone":
                    state.account.map = (string)msg["map"];
                    state.account.zone = (int)msg["zone"];
                    break;
                case "connect":
                    int id = (int)msg["id"];
                    state.account = mainForm.gI.dashboard.get_list_account_opened.Find(account => account.process.Id == id);
                    state.account.socket = state.sc;
                    //var pr = JsonMapper.ToObject(state.account.proxy);
                    sendMessage(state.account, new
                    {
                        username = state.account.username,
                        password = state.account.password,
                        server = new
                        {
                            ip = state.account.server.ip,
                            port = state.account.server.port,
                            language = state.account.server.language
                        },
                        map = Dashboard.map,
                        zone = Dashboard.zone,
                        type = Dashboard.type,
                        x = Dashboard.x,
                        y = Dashboard.y,
                        typeChar = Dashboard.typeChar,
                        charRevival = Dashboard.charRevival,
                        delay = mainForm.gI.dashboard.cbDelay.Checked
                    });
                    break;
                default:
                    break;
            }
        }
        internal static void sendDelay(bool flag = false)
        {
            sendMessageAll(new
            {
                cmd = "isDelay",
                delay = flag
            });
        }
        internal static void sendUpdate()
        {
            sendMessageAll(new
            {
                cmd = "update",
                map = Dashboard.map,
                zone = Dashboard.zone,
                type = Dashboard.type,
                x = Dashboard.x,
                y = Dashboard.y,
                typeChar = Dashboard.typeChar,
                charRevival = Dashboard.charRevival,
                delay = mainForm.gI.dashboard.cbDelay.Checked
            });
        }

        internal static void StartListen()
        {
            //ip address
            var localEndPoint = new IPEndPoint(IPAddress.Any, 2602);

            // starting server
            listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(localEndPoint);
            listener.Listen(100);
            try
            {
                while (true)
                {
                    allDone.Reset();

                    listener.BeginAccept(
                            callback: new AsyncCallback(AcceptCallback),
                            state: listener);

                    allDone.WaitOne();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        internal static void sendMessageAll(object obj)
        {
            var byteData = Encoding.UTF8.GetBytes(JsonMapper.ToJson(obj));
            var accs = mainForm.gI.dashboard.get_list_account_connected;
            accs.ForEach(a => {

                var handler = a.socket;
                handler.BeginSend(byteData, 0, byteData.Length, 0,
                    new AsyncCallback(SendCallback), handler);
            });
        }
        internal static void sendMessage(List<Account> accounts, object obj)
        {
            foreach (var a in accounts)
                sendMessage(a, obj);
        }
        internal static void sendMessage(Account account, object obj)
        {
            var strData = JsonMapper.ToJson(obj);
            var byteData = Encoding.UTF8.GetBytes(strData);
            var handler = account.socket;
            //handler.Send(byteData);
            // Begin sending the data to the remote device.  
            handler.BeginSend(byteData, 0, byteData.Length, 0,
                new AsyncCallback(SendCallback), handler);
        }

        #region callback
        static void AcceptCallback(IAsyncResult ar)
        {
            allDone.Set();
            // Get the socket that handles the client request.  
            Socket listener = (Socket)ar.AsyncState;
            Socket handler = listener.EndAccept(ar);

            // Create the state object.  
            var state = new State() { sc = handler };

            handler.BeginReceive(state.buffer, 0, State.BufferSize, 0,
                new AsyncCallback(ReadCallback), state);
        }
        static void ReadCallback(IAsyncResult ar)
        {
            string content = string.Empty;

            // Retrieve the state object and the handler socket  
            // from the asynchronous state object.  
            var state = (State)ar.AsyncState;
            Socket handler = state.sc;

            int bytesRead = 0;
            try
            {
                bytesRead = handler.EndReceive(ar);
            }
            catch (Exception)
            {
                state.account.status = "-";
                goto close;
            }

            if (bytesRead > 0)
            {
                try
                {
                    content = Encoding.UTF8.GetString(
                        state.buffer, 0, bytesRead);

                    var msg = JsonMapper.ToObject(content);

                    var action = (string)msg["cmd"];
                    if (action == "close-socket")
                    {
                        goto close;
                    }

                    onMessage(msg, state);

                    handler.BeginReceive(state.buffer, 0, State.BufferSize, 0,
                        new AsyncCallback(ReadCallback), state);
                    return;
                }
                catch (Exception e)
                {
                  //  MessageBox.Show(e.ToString());
                }
            }

        close:
            try
            {
                state.account.status = "-";
                handler.Shutdown(SocketShutdown.Both);
                handler.Close();
                if (state.account.process != null && !state.account.process.HasExited)
                    state.account.process.Kill();
                var dashboard = mainForm.gI.dashboard;
                if (!dashboard.cbCheckOut.Checked)
                    return;
                _ = dashboard.Login(state.account);
            }
            catch
            {
            }
        }
        static void SendCallback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the socket from the state object.  
                var handler = (Socket)ar.AsyncState;

                // Complete sending the data to the remote device.  
                _ = handler.EndSend(ar);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        #endregion
    }
}
