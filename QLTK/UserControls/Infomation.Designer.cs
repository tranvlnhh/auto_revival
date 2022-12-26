namespace QLTK.UserControls
{
    partial class Infomation
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
            this.value = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // value
            // 
            this.value.Animated = true;
            this.value.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.value.BorderRadius = 5;
            this.value.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.value.DefaultText = "";
            this.value.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.value.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.value.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.value.DisabledState.Parent = this.value;
            this.value.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.value.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.value.FocusedState.BorderColor = System.Drawing.Color.Gainsboro;
            this.value.FocusedState.Parent = this.value;
            this.value.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F);
            this.value.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.value.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(14)))), ((int)(((byte)(31)))));
            this.value.HoverState.ForeColor = System.Drawing.Color.White;
            this.value.HoverState.Parent = this.value;
            this.value.IconLeftOffset = new System.Drawing.Point(2, 0);
            this.value.Location = new System.Drawing.Point(134, 68);
            this.value.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.value.Name = "value";
            this.value.PasswordChar = '\0';
            this.value.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.value.PlaceholderText = "Tên hoặc id nhân vật";
            this.value.SelectedText = "";
            this.value.ShadowDecoration.Parent = this.value;
            this.value.Size = new System.Drawing.Size(424, 49);
            this.value.Style = Siticone.Desktop.UI.WinForms.Enums.TextBoxStyle.Material;
            this.value.TabIndex = 7;
            this.value.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(26)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.value);
            this.panel1.Location = new System.Drawing.Point(57, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 328);
            this.panel1.TabIndex = 8;
            // 
            // Infomation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(23)))), ((int)(((byte)(43)))));
            this.Controls.Add(this.panel1);
            this.Name = "Infomation";
            this.Size = new System.Drawing.Size(800, 400);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox value;
        private System.Windows.Forms.Panel panel1;
    }
}
