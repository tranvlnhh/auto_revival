using Siticone.Desktop.UI.WinForms;
using Siticone.Desktop.UI.WinForms.Enums;
using System.ComponentModel;
using System.Windows.Forms;

namespace QLTK
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.update_date = new System.Windows.Forms.Timer(this.components);
            this.btnSetting = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDashboard = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnInfomation = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.siticoneHtmlLabel2 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel1 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.PanelSlider = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.lbVersion = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel6 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.lbDate = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneHtmlLabel3 = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // update_date
            // 
            this.update_date.Enabled = true;
            this.update_date.Interval = 1000;
            this.update_date.Tick += new System.EventHandler(this.update_date_Tick);
            // 
            // btnSetting
            // 
            this.btnSetting.Animated = true;
            this.btnSetting.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnSetting.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnSetting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnSetting.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnSetting.CheckedState.Parent = this.btnSetting;
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnSetting.CustomImages.Parent = this.btnSetting;
            this.btnSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSetting.DisabledState.Parent = this.btnSetting;
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnSetting.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.Gray;
            this.btnSetting.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnSetting.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSetting.HoverState.Parent = this.btnSetting;
            this.btnSetting.Location = new System.Drawing.Point(533, 10);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.PressedColor = System.Drawing.Color.White;
            this.btnSetting.ShadowDecoration.Parent = this.btnSetting;
            this.btnSetting.Size = new System.Drawing.Size(154, 45);
            this.btnSetting.TabIndex = 28;
            this.btnSetting.Text = "SETTING";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Animated = true;
            this.btnDashboard.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDashboard.Checked = true;
            this.btnDashboard.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnDashboard.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.DisabledState.Parent = this.btnDashboard;
            this.btnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnDashboard.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Gray;
            this.btnDashboard.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnDashboard.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(373, 12);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.PressedColor = System.Drawing.Color.White;
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(154, 45);
            this.btnDashboard.TabIndex = 29;
            this.btnDashboard.Text = "DASHBOARD";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnInfomation
            // 
            this.btnInfomation.Animated = true;
            this.btnInfomation.ButtonMode = Siticone.Desktop.UI.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInfomation.CheckedState.CustomBorderColor = System.Drawing.Color.White;
            this.btnInfomation.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnInfomation.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnInfomation.CheckedState.Parent = this.btnInfomation;
            this.btnInfomation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfomation.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.btnInfomation.CustomImages.Parent = this.btnInfomation;
            this.btnInfomation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfomation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfomation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfomation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfomation.DisabledState.Parent = this.btnInfomation;
            this.btnInfomation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnInfomation.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfomation.ForeColor = System.Drawing.Color.Gray;
            this.btnInfomation.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.btnInfomation.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.btnInfomation.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnInfomation.HoverState.Parent = this.btnInfomation;
            this.btnInfomation.Location = new System.Drawing.Point(213, 12);
            this.btnInfomation.Name = "btnInfomation";
            this.btnInfomation.PressedColor = System.Drawing.Color.White;
            this.btnInfomation.ShadowDecoration.Parent = this.btnInfomation;
            this.btnInfomation.Size = new System.Drawing.Size(154, 45);
            this.btnInfomation.TabIndex = 30;
            this.btnInfomation.Text = "INFOMATION";
            this.btnInfomation.Click += new System.EventHandler(this.btnInfomation_Click);
            // 
            // siticoneHtmlLabel2
            // 
            this.siticoneHtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel2.Enabled = false;
            this.siticoneHtmlLabel2.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 8F);
            this.siticoneHtmlLabel2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.siticoneHtmlLabel2.Location = new System.Drawing.Point(136, 24);
            this.siticoneHtmlLabel2.Name = "siticoneHtmlLabel2";
            this.siticoneHtmlLabel2.Size = new System.Drawing.Size(21, 15);
            this.siticoneHtmlLabel2.TabIndex = 31;
            this.siticoneHtmlLabel2.Text = "PRO";
            // 
            // siticoneHtmlLabel1
            // 
            this.siticoneHtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel1.Enabled = false;
            this.siticoneHtmlLabel1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneHtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneHtmlLabel1.Location = new System.Drawing.Point(50, 25);
            this.siticoneHtmlLabel1.Name = "siticoneHtmlLabel1";
            this.siticoneHtmlLabel1.Size = new System.Drawing.Size(86, 23);
            this.siticoneHtmlLabel1.TabIndex = 32;
            this.siticoneHtmlLabel1.Text = "Auto Revival";
            // 
            // PanelSlider
            // 
            this.PanelSlider.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelSlider.CustomBorderColor = System.Drawing.Color.White;
            this.PanelSlider.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.PanelSlider.Location = new System.Drawing.Point(50, 70);
            this.PanelSlider.Name = "PanelSlider";
            this.PanelSlider.ShadowDecoration.Parent = this.PanelSlider;
            this.PanelSlider.Size = new System.Drawing.Size(800, 400);
            this.PanelSlider.TabIndex = 33;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(26)))));
            this.siticonePanel1.Controls.Add(this.lbVersion);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel6);
            this.siticonePanel1.Controls.Add(this.lbDate);
            this.siticonePanel1.Controls.Add(this.siticoneHtmlLabel3);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(11)))), ((int)(((byte)(26)))));
            this.siticonePanel1.Location = new System.Drawing.Point(0, 487);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(900, 53);
            this.siticonePanel1.TabIndex = 34;
            // 
            // lbVersion
            // 
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Enabled = false;
            this.lbVersion.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.lbVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.lbVersion.Location = new System.Drawing.Point(844, 24);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(41, 21);
            this.lbVersion.TabIndex = 6;
            this.lbVersion.Text = "1.0.0.0";
            // 
            // siticoneHtmlLabel6
            // 
            this.siticoneHtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel6.Enabled = false;
            this.siticoneHtmlLabel6.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.siticoneHtmlLabel6.ForeColor = System.Drawing.Color.DodgerBlue;
            this.siticoneHtmlLabel6.Location = new System.Drawing.Point(844, 8);
            this.siticoneHtmlLabel6.Name = "siticoneHtmlLabel6";
            this.siticoneHtmlLabel6.Size = new System.Drawing.Size(40, 18);
            this.siticoneHtmlLabel6.TabIndex = 5;
            this.siticoneHtmlLabel6.Text = "Version";
            // 
            // lbDate
            // 
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Enabled = false;
            this.lbDate.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F);
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(21, 24);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(48, 21);
            this.lbDate.TabIndex = 4;
            this.lbDate.Text = "forever";
            // 
            // siticoneHtmlLabel3
            // 
            this.siticoneHtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneHtmlLabel3.Enabled = false;
            this.siticoneHtmlLabel3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 10F);
            this.siticoneHtmlLabel3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.siticoneHtmlLabel3.Location = new System.Drawing.Point(21, 8);
            this.siticoneHtmlLabel3.Name = "siticoneHtmlLabel3";
            this.siticoneHtmlLabel3.Size = new System.Drawing.Size(79, 18);
            this.siticoneHtmlLabel3.TabIndex = 3;
            this.siticoneHtmlLabel3.Text = "Expiration date";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.siticoneControlBox2.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.siticoneControlBox2.HoverState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Gray;
            this.siticoneControlBox2.Location = new System.Drawing.Point(800, 3);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(50, 45);
            this.siticoneControlBox2.TabIndex = 35;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxStyle = Siticone.Desktop.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.Red;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Gray;
            this.siticoneControlBox1.Location = new System.Drawing.Point(844, 3);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(50, 45);
            this.siticoneControlBox1.TabIndex = 36;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.siticoneControlBox2);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.PanelSlider);
            this.Controls.Add(this.siticoneHtmlLabel1);
            this.Controls.Add(this.siticoneHtmlLabel2);
            this.Controls.Add(this.btnInfomation);
            this.Controls.Add(this.btnDashboard);
            this.Controls.Add(this.btnSetting);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "tranvlnh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing);
            this.Load += new System.EventHandler(this.mainFrom_Load);
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer update_date;
        private SiticoneButton btnSetting;
        private SiticoneButton btnDashboard;
        private SiticoneButton btnInfomation;
        private SiticoneHtmlLabel siticoneHtmlLabel2;
        private SiticoneHtmlLabel siticoneHtmlLabel1;
        private SiticonePanel PanelSlider;
        private SiticonePanel siticonePanel1;
        internal SiticoneHtmlLabel lbVersion;
        private SiticoneHtmlLabel siticoneHtmlLabel6;
        private SiticoneHtmlLabel lbDate;
        private SiticoneHtmlLabel siticoneHtmlLabel3;
        private SiticoneControlBox siticoneControlBox2;
        private SiticoneControlBox siticoneControlBox1;
    }
}

