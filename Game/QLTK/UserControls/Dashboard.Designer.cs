namespace QLTK.UserControls
{
    partial class Dashboard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataAccount = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.btnSort = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnEdit = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnClose = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnDelete = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.btnAdd = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cbProxy = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.cbAddBatch = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbbSize = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ServerView = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.addTo = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.addFrom = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ZoomView = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.SizeView = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.password = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.port = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.username = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.ip = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.PassView = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.AccView = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAccount
            // 
            this.dataAccount.AllowUserToAddRows = false;
            this.dataAccount.AllowUserToDeleteRows = false;
            this.dataAccount.AllowUserToResizeColumns = false;
            this.dataAccount.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.dataAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.dataAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(30)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataAccount.ColumnHeadersHeight = 21;
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column7,
            this.Column5,
            this.Column8});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataAccount.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataAccount.EnableHeadersVisualStyles = false;
            this.dataAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.dataAccount.Location = new System.Drawing.Point(0, 0);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.ReadOnly = true;
            this.dataAccount.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataAccount.RowHeadersVisible = false;
            this.dataAccount.RowHeadersWidth = 40;
            this.dataAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.dataAccount.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dataAccount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataAccount.ShowCellErrors = false;
            this.dataAccount.ShowCellToolTips = false;
            this.dataAccount.ShowEditingIcon = false;
            this.dataAccount.ShowRowErrors = false;
            this.dataAccount.Size = new System.Drawing.Size(515, 400);
            this.dataAccount.TabIndex = 0;
            this.dataAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.dataAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.dataAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataAccount.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.dataAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.dataAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.dataAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataAccount.ThemeStyle.HeaderStyle.Height = 21;
            this.dataAccount.ThemeStyle.ReadOnly = true;
            this.dataAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.dataAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Silver;
            this.dataAccount.ThemeStyle.RowsStyle.Height = 22;
            this.dataAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(36)))), ((int)(((byte)(77)))));
            this.dataAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Silver;
            this.dataAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAccount_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "id";
            this.Column1.FillWeight = 40F;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "username";
            this.Column2.HeaderText = "Account";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "password";
            this.Column3.HeaderText = "Pass";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "server";
            this.Column4.FillWeight = 80F;
            this.Column4.HeaderText = "Server";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "size";
            this.Column6.FillWeight = 80F;
            this.Column6.HeaderText = "Size";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "zoom";
            this.Column7.FillWeight = 60F;
            this.Column7.HeaderText = "Zoom";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "status";
            this.Column5.FillWeight = 150F;
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "index_server";
            this.Column8.HeaderText = "Column8";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.siticonePanel1.BorderRadius = 2;
            this.siticonePanel1.Controls.Add(this.btnSort);
            this.siticonePanel1.Controls.Add(this.btnEdit);
            this.siticonePanel1.Controls.Add(this.btnClose);
            this.siticonePanel1.Controls.Add(this.btnDelete);
            this.siticonePanel1.Controls.Add(this.btnLogin);
            this.siticonePanel1.Controls.Add(this.btnAdd);
            this.siticonePanel1.Controls.Add(this.cbProxy);
            this.siticonePanel1.Controls.Add(this.cbAddBatch);
            this.siticonePanel1.Controls.Add(this.pictureBox2);
            this.siticonePanel1.Controls.Add(this.cbbSize);
            this.siticonePanel1.Controls.Add(this.pictureBox1);
            this.siticonePanel1.Controls.Add(this.ServerView);
            this.siticonePanel1.Controls.Add(this.addTo);
            this.siticonePanel1.Controls.Add(this.addFrom);
            this.siticonePanel1.Controls.Add(this.ZoomView);
            this.siticonePanel1.Controls.Add(this.SizeView);
            this.siticonePanel1.Controls.Add(this.password);
            this.siticonePanel1.Controls.Add(this.port);
            this.siticonePanel1.Controls.Add(this.username);
            this.siticonePanel1.Controls.Add(this.ip);
            this.siticonePanel1.Controls.Add(this.PassView);
            this.siticonePanel1.Controls.Add(this.AccView);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.siticonePanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(16)))), ((int)(((byte)(36)))));
            this.siticonePanel1.Location = new System.Drawing.Point(520, 0);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.BorderRadius = 5;
            this.siticonePanel1.ShadowDecoration.Enabled = true;
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.siticonePanel1.Size = new System.Drawing.Size(280, 400);
            this.siticonePanel1.TabIndex = 1;
            // 
            // btnSort
            // 
            this.btnSort.Animated = true;
            this.btnSort.BorderRadius = 2;
            this.btnSort.CheckedState.Parent = this.btnSort;
            this.btnSort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSort.CustomImages.Parent = this.btnSort;
            this.btnSort.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSort.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSort.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSort.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSort.DisabledState.Parent = this.btnSort;
            this.btnSort.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnSort.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.ForeColor = System.Drawing.Color.Black;
            this.btnSort.HoverState.Parent = this.btnSort;
            this.btnSort.Location = new System.Drawing.Point(99, 217);
            this.btnSort.Name = "btnSort";
            this.btnSort.PressedColor = System.Drawing.Color.White;
            this.btnSort.ShadowDecoration.Parent = this.btnSort;
            this.btnSort.Size = new System.Drawing.Size(80, 28);
            this.btnSort.TabIndex = 10;
            this.btnSort.Text = "SORT";
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Animated = true;
            this.btnEdit.BorderRadius = 2;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdit.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Location = new System.Drawing.Point(99, 185);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PressedColor = System.Drawing.Color.White;
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(80, 28);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Animated = true;
            this.btnClose.BorderRadius = 2;
            this.btnClose.CheckedState.Parent = this.btnClose;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.CustomImages.Parent = this.btnClose;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.DisabledState.Parent = this.btnClose;
            this.btnClose.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnClose.HoverState.Parent = this.btnClose;
            this.btnClose.Location = new System.Drawing.Point(185, 217);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = System.Drawing.Color.White;
            this.btnClose.ShadowDecoration.Parent = this.btnClose;
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BorderRadius = 2;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(185, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.White;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(80, 28);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Animated = true;
            this.btnLogin.BorderRadius = 2;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.DisabledState.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(15, 217);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PressedColor = System.Drawing.Color.White;
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(80, 28);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BorderRadius = 2;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(15, 185);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.White;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(80, 28);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbProxy
            // 
            this.cbProxy.Animated = true;
            this.cbProxy.CheckedState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.cbProxy.CheckedState.BorderRadius = 1;
            this.cbProxy.CheckedState.BorderThickness = 0;
            this.cbProxy.CheckedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.cbProxy.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.cbProxy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbProxy.Location = new System.Drawing.Point(15, 251);
            this.cbProxy.Name = "cbProxy";
            this.cbProxy.Size = new System.Drawing.Size(121, 27);
            this.cbProxy.TabIndex = 9;
            this.cbProxy.Text = "Using Proxy";
            this.cbProxy.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbProxy.UncheckedState.BorderRadius = 1;
            this.cbProxy.UncheckedState.BorderThickness = 0;
            this.cbProxy.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // cbAddBatch
            // 
            this.cbAddBatch.Animated = true;
            this.cbAddBatch.CheckedState.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.cbAddBatch.CheckedState.BorderRadius = 1;
            this.cbAddBatch.CheckedState.BorderThickness = 0;
            this.cbAddBatch.CheckedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.cbAddBatch.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F);
            this.cbAddBatch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAddBatch.Location = new System.Drawing.Point(22, 147);
            this.cbAddBatch.Name = "cbAddBatch";
            this.cbAddBatch.Size = new System.Drawing.Size(83, 27);
            this.cbAddBatch.TabIndex = 9;
            this.cbAddBatch.Text = "add batch";
            this.cbAddBatch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cbAddBatch.UncheckedState.BorderRadius = 1;
            this.cbAddBatch.UncheckedState.BorderThickness = 0;
            this.cbAddBatch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.pictureBox2.Image = global::QLTK.Properties.Resources.icons8_expand_50px;
            this.pictureBox2.Location = new System.Drawing.Point(22, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // cbbSize
            // 
            this.cbbSize.BackColor = System.Drawing.Color.Transparent;
            this.cbbSize.BorderThickness = 0;
            this.cbbSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.cbbSize.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSize.FocusedState.Parent = this.cbbSize;
            this.cbbSize.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.cbbSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbSize.HoverState.Parent = this.cbbSize;
            this.cbbSize.ItemHeight = 21;
            this.cbbSize.Items.AddRange(new object[] {
            "Lớn",
            "Nhỏ"});
            this.cbbSize.ItemsAppearance.Parent = this.cbbSize;
            this.cbbSize.Location = new System.Drawing.Point(15, 111);
            this.cbbSize.Name = "cbbSize";
            this.cbbSize.ShadowDecoration.Parent = this.cbbSize;
            this.cbbSize.Size = new System.Drawing.Size(90, 27);
            this.cbbSize.StartIndex = 0;
            this.cbbSize.TabIndex = 7;
            this.cbbSize.TextOffset = new System.Drawing.Point(32, 1);
            this.cbbSize.SelectedValueChanged += new System.EventHandler(this.cbbSize_SelectedValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.pictureBox1.Image = global::QLTK.Properties.Resources.icons8_list_50px;
            this.pictureBox1.Location = new System.Drawing.Point(22, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ServerView
            // 
            this.ServerView.BackColor = System.Drawing.Color.Transparent;
            this.ServerView.BorderThickness = 0;
            this.ServerView.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServerView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServerView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.ServerView.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerView.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServerView.FocusedState.Parent = this.ServerView;
            this.ServerView.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.ServerView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServerView.HoverState.Parent = this.ServerView;
            this.ServerView.ItemHeight = 21;
            this.ServerView.ItemsAppearance.Parent = this.ServerView;
            this.ServerView.Location = new System.Drawing.Point(15, 78);
            this.ServerView.Name = "ServerView";
            this.ServerView.ShadowDecoration.Parent = this.ServerView;
            this.ServerView.Size = new System.Drawing.Size(250, 27);
            this.ServerView.TabIndex = 5;
            this.ServerView.TextOffset = new System.Drawing.Point(32, 1);
            // 
            // addTo
            // 
            this.addTo.Animated = true;
            this.addTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.addTo.BorderRadius = 5;
            this.addTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTo.DefaultText = "";
            this.addTo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addTo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addTo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addTo.DisabledState.Parent = this.addTo;
            this.addTo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addTo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.addTo.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.addTo.FocusedState.Parent = this.addTo;
            this.addTo.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.addTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.addTo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.addTo.HoverState.ForeColor = System.Drawing.Color.White;
            this.addTo.HoverState.Parent = this.addTo;
            this.addTo.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.addTo.Location = new System.Drawing.Point(190, 147);
            this.addTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addTo.Name = "addTo";
            this.addTo.PasswordChar = '\0';
            this.addTo.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.addTo.PlaceholderText = "to";
            this.addTo.SelectedText = "";
            this.addTo.ShadowDecoration.Parent = this.addTo;
            this.addTo.Size = new System.Drawing.Size(75, 27);
            this.addTo.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.addTo.TabIndex = 4;
            this.addTo.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // addFrom
            // 
            this.addFrom.Animated = true;
            this.addFrom.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.addFrom.BorderRadius = 5;
            this.addFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addFrom.DefaultText = "";
            this.addFrom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.addFrom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.addFrom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addFrom.DisabledState.Parent = this.addFrom;
            this.addFrom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.addFrom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.addFrom.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.addFrom.FocusedState.Parent = this.addFrom;
            this.addFrom.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.addFrom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.addFrom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.addFrom.HoverState.ForeColor = System.Drawing.Color.White;
            this.addFrom.HoverState.Parent = this.addFrom;
            this.addFrom.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.addFrom.Location = new System.Drawing.Point(110, 147);
            this.addFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.addFrom.Name = "addFrom";
            this.addFrom.PasswordChar = '\0';
            this.addFrom.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.addFrom.PlaceholderText = "from";
            this.addFrom.SelectedText = "";
            this.addFrom.ShadowDecoration.Parent = this.addFrom;
            this.addFrom.Size = new System.Drawing.Size(75, 27);
            this.addFrom.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.addFrom.TabIndex = 4;
            this.addFrom.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // ZoomView
            // 
            this.ZoomView.Animated = true;
            this.ZoomView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.ZoomView.BorderRadius = 5;
            this.ZoomView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ZoomView.DefaultText = "2";
            this.ZoomView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ZoomView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ZoomView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ZoomView.DisabledState.Parent = this.ZoomView;
            this.ZoomView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ZoomView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.ZoomView.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.ZoomView.FocusedState.Parent = this.ZoomView;
            this.ZoomView.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.ZoomView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ZoomView.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.ZoomView.HoverState.ForeColor = System.Drawing.Color.White;
            this.ZoomView.HoverState.Parent = this.ZoomView;
            this.ZoomView.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.ZoomView.Location = new System.Drawing.Point(225, 111);
            this.ZoomView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ZoomView.Name = "ZoomView";
            this.ZoomView.PasswordChar = '\0';
            this.ZoomView.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ZoomView.PlaceholderText = "zoom";
            this.ZoomView.SelectedText = "";
            this.ZoomView.SelectionStart = 1;
            this.ZoomView.ShadowDecoration.Parent = this.ZoomView;
            this.ZoomView.Size = new System.Drawing.Size(40, 27);
            this.ZoomView.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.ZoomView.TabIndex = 4;
            this.ZoomView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SizeView
            // 
            this.SizeView.Animated = true;
            this.SizeView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.SizeView.BorderRadius = 5;
            this.SizeView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SizeView.DefaultText = "1026x600";
            this.SizeView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SizeView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SizeView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SizeView.DisabledState.Parent = this.SizeView;
            this.SizeView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SizeView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.SizeView.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.SizeView.FocusedState.Parent = this.SizeView;
            this.SizeView.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.SizeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SizeView.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.SizeView.HoverState.ForeColor = System.Drawing.Color.White;
            this.SizeView.HoverState.Parent = this.SizeView;
            this.SizeView.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.SizeView.Location = new System.Drawing.Point(110, 111);
            this.SizeView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.SizeView.Name = "SizeView";
            this.SizeView.PasswordChar = '\0';
            this.SizeView.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SizeView.PlaceholderText = "size";
            this.SizeView.SelectedText = "";
            this.SizeView.SelectionStart = 8;
            this.SizeView.ShadowDecoration.Parent = this.SizeView;
            this.SizeView.Size = new System.Drawing.Size(111, 27);
            this.SizeView.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.SizeView.TabIndex = 4;
            this.SizeView.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.password.BorderRadius = 5;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.password.HoverState.ForeColor = System.Drawing.Color.White;
            this.password.HoverState.Parent = this.password;
            this.password.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.password.Location = new System.Drawing.Point(15, 350);
            this.password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.password.Name = "password";
            this.password.PasswordChar = '\0';
            this.password.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.password.PlaceholderText = "Password (có thể bỏ qua)";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(248, 27);
            this.password.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.password.TabIndex = 4;
            this.password.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // port
            // 
            this.port.Animated = true;
            this.port.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.port.BorderRadius = 5;
            this.port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.port.DefaultText = "";
            this.port.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.port.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.port.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.port.DisabledState.Parent = this.port;
            this.port.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.port.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.port.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.port.FocusedState.Parent = this.port;
            this.port.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.port.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.port.HoverState.ForeColor = System.Drawing.Color.White;
            this.port.HoverState.Parent = this.port;
            this.port.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.port.Location = new System.Drawing.Point(183, 284);
            this.port.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.port.Name = "port";
            this.port.PasswordChar = '\0';
            this.port.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.port.PlaceholderText = "Port";
            this.port.SelectedText = "";
            this.port.ShadowDecoration.Parent = this.port;
            this.port.Size = new System.Drawing.Size(80, 27);
            this.port.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.port.TabIndex = 4;
            this.port.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.username.BorderRadius = 5;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.username.HoverState.ForeColor = System.Drawing.Color.White;
            this.username.HoverState.Parent = this.username;
            this.username.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.username.Location = new System.Drawing.Point(15, 317);
            this.username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.username.PlaceholderText = "Username (có thể bỏ qua)";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(248, 27);
            this.username.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.username.TabIndex = 4;
            this.username.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // ip
            // 
            this.ip.Animated = true;
            this.ip.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.ip.BorderRadius = 5;
            this.ip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ip.DefaultText = "";
            this.ip.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ip.DisabledState.Parent = this.ip;
            this.ip.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.ip.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.ip.FocusedState.Parent = this.ip;
            this.ip.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.ip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ip.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.ip.HoverState.ForeColor = System.Drawing.Color.White;
            this.ip.HoverState.Parent = this.ip;
            this.ip.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.ip.Location = new System.Drawing.Point(15, 284);
            this.ip.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ip.Name = "ip";
            this.ip.PasswordChar = '\0';
            this.ip.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ip.PlaceholderText = "IP Address";
            this.ip.SelectedText = "";
            this.ip.ShadowDecoration.Parent = this.ip;
            this.ip.Size = new System.Drawing.Size(164, 27);
            this.ip.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.ip.TabIndex = 4;
            this.ip.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // PassView
            // 
            this.PassView.Animated = true;
            this.PassView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.PassView.BorderRadius = 5;
            this.PassView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassView.DefaultText = "";
            this.PassView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassView.DisabledState.Parent = this.PassView;
            this.PassView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.PassView.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.PassView.FocusedState.Parent = this.PassView;
            this.PassView.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.PassView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PassView.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.PassView.HoverState.ForeColor = System.Drawing.Color.White;
            this.PassView.HoverState.Parent = this.PassView;
            this.PassView.IconLeft = global::QLTK.Properties.Resources.icons8_password_50px;
            this.PassView.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.PassView.Location = new System.Drawing.Point(15, 45);
            this.PassView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.PassView.Name = "PassView";
            this.PassView.PasswordChar = '\0';
            this.PassView.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.PassView.PlaceholderText = "Password";
            this.PassView.SelectedText = "";
            this.PassView.ShadowDecoration.Parent = this.PassView;
            this.PassView.Size = new System.Drawing.Size(250, 27);
            this.PassView.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.PassView.TabIndex = 4;
            this.PassView.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // AccView
            // 
            this.AccView.Animated = true;
            this.AccView.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.AccView.BorderRadius = 5;
            this.AccView.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AccView.DefaultText = "";
            this.AccView.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AccView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AccView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AccView.DisabledState.Parent = this.AccView;
            this.AccView.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AccView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.AccView.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.AccView.FocusedState.Parent = this.AccView;
            this.AccView.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.AccView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AccView.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.AccView.HoverState.ForeColor = System.Drawing.Color.White;
            this.AccView.HoverState.Parent = this.AccView;
            this.AccView.IconLeft = global::QLTK.Properties.Resources.icons8_customer_50px;
            this.AccView.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.AccView.Location = new System.Drawing.Point(15, 12);
            this.AccView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AccView.Name = "AccView";
            this.AccView.PasswordChar = '\0';
            this.AccView.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.AccView.PlaceholderText = "Account";
            this.AccView.SelectedText = "";
            this.AccView.ShadowDecoration.Parent = this.AccView;
            this.AccView.Size = new System.Drawing.Size(250, 27);
            this.AccView.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.AccView.TabIndex = 4;
            this.AccView.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.dataAccount);
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Dashboard";
            this.Size = new System.Drawing.Size(800, 400);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Siticone.Desktop.UI.WinForms.SiticoneDataGridView dataAccount;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox AccView;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox ServerView;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox PassView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cbbSize;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox SizeView;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox cbAddBatch;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addTo;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox addFrom;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnSort;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnEdit;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnClose;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnDelete;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogin;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnAdd;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ZoomView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox cbProxy;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox password;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox username;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox port;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ip;
        private System.Windows.Forms.Timer timer1;
    }
}
