using LitJson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTK.UserControls
{
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }
        
        private void Setting_Load(object sender, EventArgs e)
        {
            var toado = JsonMapper.ToObject(File.ReadAllText("Data\\ToaDo.json"));
            var nhanvat = JsonMapper.ToObject(File.ReadAllText("Data\\NhanVat.json"));

            int type = (int)toado["type"];
            switch (type)
            {
                case 0:
                    td1.Checked = true;
                    break;
                case 1:
                    td2.Checked = true;
                    break;
                case 2:
                    td3.Checked = true;
                    break;
                case 3:
                    td4.Checked = true;
                    x.Text = (string)toado["x"];
                    y.Text = (string)toado["y"];
                    break;
            }
            type = (int)nhanvat["type"];
            switch (type)
            {
                case 0:
                    nv1.Checked = true;
                    break;
                case 1:
                    nv2.Checked = true;
                    value.Text = (string)nhanvat["value"];
                    break;
                case 2:
                    nv3.Checked = true;
                    value.Text = (string)nhanvat["value"];
                    break;
            }
        }

        private void btnSaveToaDo_Click(object sender, EventArgs e)
        {
            var type = 0;
            if (td1.Checked)
                type = 0;
            else if (td2.Checked)
                type = 1;
            else if (td3.Checked)
                type = 2;
            else if (td4.Checked)
                type = 3;

            if(type == 3)
            {
                File.WriteAllText("Data\\ToaDo.json", JsonMapper.ToJson(new
                {
                    type = type,
                    x = x.Text,
                    y = y.Text
                }));
                return;
            }
            File.WriteAllText("Data\\ToaDo.json", JsonMapper.ToJson(new
            {
                type = type,
            }));
        }

        private void btnSaveNhanVat_Click(object sender, EventArgs e)
        {
            var type = 0;
            if (nv1.Checked)
                type = 0;
            else if (nv2.Checked)
                type = 1;
            else if (nv3.Checked)
                type = 2;

            if(type == 0)
            {
                File.WriteAllText("Data\\NhanVat.json", JsonMapper.ToJson(new
                {
                    type = type,
                }));
                return;
            }

            File.WriteAllText("Data\\NhanVat.json", JsonMapper.ToJson(new
            {
                type = type,
                value = value.Text
            }));
        }
    }
}
