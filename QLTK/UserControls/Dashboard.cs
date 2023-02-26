using LitJson;
using QLTK.Functions;
using QLTK.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace QLTK.UserControls
{
    public partial class Dashboard : UserControl
    {
        public static int map, zone, type, typeChar, x, y;
        internal static string charRevival;
        public Dashboard()
        {
            InitializeComponent();
            list_account = new BindingSource();
            list_account.DataSource = new List<Account>();
            dataAccount.DataSource = list_account;
            ServerView.Items.AddRange(Server.servers);
            ServerView.SelectedIndex = 0;
            this.dataAccount.MouseWheel += new MouseEventHandler(mousewheel);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {

            new Thread(DragonServer.StartListen) { IsBackground = true }.Start();
            try
            {
                var dataText = File.ReadAllText("Data//dataAccount.json");
                var dataJson = JsonMapper.ToObject<Account[]>(dataText);
                foreach (var account in dataJson)
                    list_account.Add(account);



                var m = JsonMapper.ToObject(File.ReadAllText("Data//Map.json"));
                map = (int)m["map"];
                zone = (int)m["zone"];
                cbbMap.SelectedIndex = (int)m["mapindex"];
                nZone.Value = zone;
                //list_account.ListChanged += List_account_ListChanged;
            }
            catch
            {
            }
        }
        public bool checkSend;
        public long lastTimeRevival;
        private void timer1_Tick(object sender, EventArgs e)
        {
            dataAccount.Update();
            dataAccount.Refresh();
            if (cbDelay.Checked && !checkSend && Utils.currentTimeMillis() - lastTimeRevival >= nDelay.Value)
            {
                DragonServer.sendDelay();
                checkSend = true;
            }
        }

        BindingSource list_account;
        void mousewheel(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Delta > 0 && dataAccount.FirstDisplayedScrollingRowIndex > 0)
                {
                    dataAccount.FirstDisplayedScrollingRowIndex--;
                }
                else if (e.Delta < 0)
                {
                    dataAccount.FirstDisplayedScrollingRowIndex++;
                }
            }
            catch
            {
            }
        }

        #region helper

        bool is_number(string str)
            => int.TryParse(str, out var a);


        Account get_account_intput_batch(int num) => new Account()
        {
            id = dataAccount.Rows.Count,
            username = AccView.Text.Replace("\'X\'", num.ToString()),
            password = PassView.Text,
            index_server = ServerView.SelectedIndex,
        };

        Account get_account_intput => new Account()
        {
            id = dataAccount.Rows.Count,
            username = AccView.Text,
            password = PassView.Text,
            index_server = ServerView.SelectedIndex,
        };
        public List<Account> get_list_account_connected
           => ((List<Account>)list_account.List).FindAll(acc => acc.socket != null && acc.socket.Connected);

        public List<Account> get_list_account_opened
           => ((List<Account>)list_account.List).FindAll(acc => acc.process != null && !acc.process.HasExited);

        List<Account> get_list_account_selected_and_opened
           => ((List<Account>)list_account.List).FindAll(acc => dataAccount.Rows[acc.id].Selected && acc.process != null && !acc.process.HasExited);

        List<Account> get_list_account_selected
            => ((List<Account>)list_account.List).FindAll(acc => dataAccount.Rows[acc.id].Selected);

        public List<Account> get_list_account
            => (List<Account>)list_account.List;

        bool exist_account(Account acc)
            => get_list_account.Any(a => (a.username == acc.username && a.password == acc.password && a.server == acc.server));

        Account get_account(string username) 
            => get_list_account.Find(a => a.username == username);

        #endregion
        #region method

        

        async Task doLogin(List<Account> accounts)
        {
            foreach (var account in accounts)
            {
                await Login(account);
            }
        }

        public async Task Login(Account account)
        {
            if (account.process == null || account.process.HasExited)
            {
                account.status =  "Opening!";
                account.process = Process.Start("123Tool.exe", $"{DragonServer.port} -silent-crashes -disable-gpu-skinning -releaseCodeOptimization -disableManagedDebugger -accept-apiupdate -no-stereo-rendering -batchmode -nographics");// -batchmode -nographics   $"-screen-width {ss[0]} -screen-height {ss[1]}");
                await Task.Delay(500);
            }
        }

        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AccView.Text))
            {
                Utils.notification("Tài khoản không thể để trống!", MessageBoxIcon.Error);
                AccView.Focus();
                return;
            }
            if (string.IsNullOrEmpty(PassView.Text))
            {
                Utils.notification("Mật không thể để trống!", MessageBoxIcon.Error);
                PassView.Focus();
                return;
            }
            
            
            if (!cbAddBatch.Checked)
            {
                var a = get_account_intput;
                if (exist_account(a))
                {
                    Utils.notification("Tài khoản đã tồn tại!", MessageBoxIcon.Error);
                    return;
                }
                list_account.Add(a);
            }
            else
            {
                int f, t;
                if(int.TryParse(addFrom.Text, out f) && int.TryParse(addTo.Text, out t))
                {
                    for(int i = f; i <= t; i++)
                    {
                        list_account.Add(get_account_intput_batch(i));
                    }
                }
                else
                {
                    Utils.notification("Vui lòng nhập đúng dữ liệu!", MessageBoxIcon.Error);
                }

            }
            File.WriteAllText("Data//dataAccount.json", JsonMapper.ToJson(get_list_account));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var list_edit = get_list_account_selected;
            if (list_edit.Count < 1)
            {
                Utils.notification("Vui lòng chọn tài khoản cần sửa!", MessageBoxIcon.Error);
                return;
            }
            if (list_edit.Count == 1)
            {
                if (Utils.Question($"Bạn có chắc chắn muốn sửa tài khoản {list_edit[0].username}!") == DialogResult.Yes)
                {
                    list_edit[0].username = AccView.Text;
                    list_edit[0].password = PassView.Text;
                    list_edit[0].index_server = ServerView.SelectedIndex;

                    File.WriteAllText("Data//dataAccount.json", JsonMapper.ToJson(get_list_account));
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var list_delete = get_list_account_selected;
            if (list_delete.Count < 1)
            {
                Utils.notification("Vui lòng chọn tài khoản cần xóa!", MessageBoxIcon.Error);
                return;
            }
            if(list_delete.Count == 1)
            {
                if (Utils.Question($"Bạn có chắc chắn muốn xóa tài khoản {list_delete[0].username}!") == DialogResult.Yes)
                {
                    list_account.Remove(list_delete[0]);
                    goto save;
                }
                return;
            }
            if (Utils.Question($"Bạn có chắc chắn muốn xóa {list_delete.Count} đang select!") == DialogResult.Yes)
            {
                foreach (var account in list_delete)
                {
                    list_account.Remove(account);
                }
                goto save;
            }
            return;
        save:
            int i = 0;
            foreach (var account in get_list_account)
            {
                account.id = i;
                i++;
            }
            File.WriteAllText("Data//dataAccount.json", JsonMapper.ToJson(get_list_account));
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            await doLogin(get_list_account_selected);
            //var a = StringCipher.Encrypt("qwertyuiopasdfghjklzxcvbnm1234567890");
            //var b = StringCipher.Decrypt(a);

        }

        void btnClose_Click(object sender, EventArgs e)
        {
            var list_close = get_list_account_selected_and_opened;
            if (list_close.Count == 0) 
            {
                Utils.notification("Vui lòng chọn tài khoản cần đóng", MessageBoxIcon.Error);
                return;
            }
            list_close.ForEach(a => a.process.Kill());
        }

        private void dataAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var acc = get_list_account[e.RowIndex];
            AccView.Text = acc.username;
            PassView.Text = acc.password;
            ServerView.SelectedIndex = acc.index_server;
            ServerView.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var m = (string)cbbMap.SelectedItem;
            map = int.Parse(m.Substring(1, m.IndexOf("]") - 1));
            zone = (int)nZone.Value;
            File.WriteAllText("Data//Map.json", JsonMapper.ToJson(new
            {
                map = map,
                mapindex = cbbMap.SelectedIndex,
                zone = zone
            }));
            DragonServer.sendUpdate();
        }

        public void close()
        {
            var accs = get_list_account_opened;
            accs.ForEach(a => a.process.Kill());
        }
    }
}
