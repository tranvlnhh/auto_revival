using LitJson;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using TranVinh.Helper;
using TranVinh.Models;
using UnityEngine;

namespace TranVinh.Functions
{
    internal static class DragonClient
    {
        internal static Thread thread;
        static Socket sender;

        static void onMessage(JsonData msg)
        {
            var cmd = (string)msg["cmd"];
            switch (cmd)
            {
                case "set-map-zone":
                    AutoRevival.map = (int)msg["map"];
                    AutoRevival.zone = (int)msg["zone"];
                    break;
                case "isDelay":
                    AutoRevival.isRevival = (bool)msg["delay"];
                    break;
                default:
                    break;
            }
        }

        [Obfuscation(Feature = "Virtualization", Exclude = false)]
        internal static void Connect()
        {
            thread = 
            new Thread(() =>
            {
                try
                {
                    sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    //while (!sender.Connected)
                    //{
                        sender.Connect(IPAddress.Loopback, 2602);
                        Thread.Sleep(500);
                    //}

                    sendMessage(new Dictionary<string, object>()
                    {
                        { "cmd", "connect" },
                        { "id", Process.GetCurrentProcess().Id }
                    });
                    sendMessage(new Dictionary<string, string>()
                    {
                        { "cmd", "set-status" },
                        { "status",  Account.status }
                    });
                    byte[] array = new byte[1024];
                    int count = sender.Receive(array);
                    string @string = Encoding.UTF8.GetString(array, 0, count);

                    JsonData jsonData = JsonMapper.ToObject(@string);
                    Account.username = (string)jsonData["username"];
                    Account.password = (string)jsonData["password"];
                    GameMidlet.IP = (string)jsonData["server"]["ip"];
                    GameMidlet.PORT = (int)jsonData["server"]["port"];
                    mResources.loadLanguague((sbyte)jsonData["server"]["language"]);

                    AutoRevival.map = (int)jsonData["map"];
                    AutoRevival.zone = (int)jsonData["zone"];
                    AutoRevival.type = (int)jsonData["type"];
                    if(AutoRevival.type == 3)
                    {
                        Account.x = (int)jsonData["x"];
                        Account.y = (int)jsonData["y"];
                    }

                    AutoRevival.typeChar = (int)jsonData["typeChar"];
                    if(AutoRevival.typeChar == 1)
                        AutoRevival.charNameRevival = (string)jsonData["charRevival"];
                    else if(AutoRevival.typeChar == 2)
                        AutoRevival.charIdRevival = int.Parse((string)jsonData["charRevival"]);
                    AutoRevival.delay = (bool)jsonData["delay"];
                    GameCanvas.lowGraphic = true;
                    GameCanvas.isPlaySound = false;
                    GameCanvas.connect();
                    // Account.resetLogin();
                    Receive();

                    Resources.UnloadUnusedAssets();
                    GC.Collect();
                }
                catch (Exception e)
                {
                    File.WriteAllText("bug_connect.txt", e.ToString());
                }
            })
            { IsBackground = true };

            thread.Start();
        }
        internal static void sendDelay()
        {
            sendMessage(new Dictionary<string, string>()
            {
                { "cmd", "isDelay" }
            });
        }
        static void Receive()
        {
            try
            {
                while (true)
                {
                    JsonData msg;

                    byte[] array = new byte[1024];
                    try
                    {
                        int count = sender.Receive(array);
                        var @string = Encoding.UTF8.GetString(array, 0, count);

                        // File.WriteAllText("a.txt", @string);
                        if (string.IsNullOrEmpty(@string))
                            continue;
                        msg = JsonMapper.ToObject(@string);
                        //MainThreadDispatcher.dispatcher(delegate
                        //{
                            onMessage(msg);
                        //});
                    }
                    catch (Exception e)
                    {
                        //File.WriteAllText("bug_recieve.txt", e.ToString());
                        continue;
                    }
                    //MainThreadDispatcher.dispatcher(delegate
                    //{
                    //    this.onMessage(msg);
                    //});
                }
            }
            catch { }
        }

        internal static void sendMessage(object obj)
        {
            string s = JsonMapper.ToJson(obj);
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            try
            {
                sender.Send(bytes);
            }
            catch (ObjectDisposedException)
            {
            }
        }
        internal static void send_status(string str)
        {
            sendMessage(new Dictionary<string, string>()
            {
                { "cmd", "set-status" },
                { "status", str }
            });
        }
        internal static void send_map_zone()
        {
            sendMessage(new Dictionary<string, object>()
            {
                { "cmd", "set-map-zone" },
                { "map", TileMap.mapName },
                { "zone", TileMap.zoneID }
            });
        }
        internal static bool Close() 
        {

            if (sender != null && sender.Connected)
            {
                sendMessage(new Dictionary<string, string>()
                {
                    { "action", "close-socket" }
                });
                sender.Shutdown(SocketShutdown.Both);
                sender.Close();
            }


            if (thread != null && thread.IsAlive)
                thread.Abort();
            return true;
        }
    }
}
