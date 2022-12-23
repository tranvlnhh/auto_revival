﻿using Microsoft.Win32;
using QLTK.Functions;
using QLTK.UserControls;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTK
{
    public partial class mainForm : Form
    {
        public static mainForm gI;
        public mainForm()
        {
            InitializeComponent();
            new SiticoneDragControl(this);
            new SiticoneShadowForm(this);
            dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            PanelSlider.Controls.Add(dashboard);
            gI = this;
        }
        public Dashboard dashboard;

        public DateTime time_expired;

        

        #region font
        

        /// <summary>
        /// Installs font on the user's system and adds it to the registry so it's available on the next session
        /// Your font must be included in your project with its build path set to 'Content' and its Copy property
        /// set to 'Copy Always'
        /// </summary>
        /// <param name="contentFontName">Your font to be passed as a resource (i.e. "myfont.tff")</param>
        static void RegisterFont(string contentFontName)
        {
            // Creates the full path where your font will be installed
            var fontDestination = Path.Combine(System.Environment.GetFolderPath
                                          (System.Environment.SpecialFolder.Fonts), contentFontName);

            if (!File.Exists(fontDestination))
            {
                // Copies font to destination
                System.IO.File.Copy(Path.Combine(System.IO.Directory.GetCurrentDirectory(), contentFontName), fontDestination);

                // Retrieves font name
                // Makes sure you reference System.Drawing
                PrivateFontCollection fontCol = new PrivateFontCollection();
                fontCol.AddFontFile(fontDestination);
                var actualFontName = fontCol.Families[0].Name;

                //Add font
                Utils.AddFontResource(fontDestination);
                //Add registry entry   
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Fonts",
        actualFontName, contentFontName, RegistryValueKind.String);
            }
        }
        #endregion
        void btnDashboard_Click(object sender, EventArgs e)
        {
            dashboard.BringToFront();
        }

        void update_date_Tick(object sender, EventArgs e)
        {
            if (time_expired != null)
            {
                var timeSpan = TimeHelper.gI().calculator(time_expired);
                string date = "forever";
                if (timeSpan.Days > 0)
                {
                    date += timeSpan.Days + "d : ";
                }
                if (timeSpan.Days > 0 || timeSpan.Hours > 0)
                {
                    date += timeSpan.Hours + "h : ";
                }
                if (timeSpan.Hours > 0 || timeSpan.Minutes > 0)
                {
                    date += timeSpan.Minutes + "m : ";
                }
                if (timeSpan.Minutes > 0 || timeSpan.Seconds >= 0)
                {
                    date += timeSpan.Seconds + "s";
                }
                lbDate.Text = date;
            }
            //TimeHelper.gI().DateTimeNow().ToString("dd/MM/yyyy HH:mm:ss");
        }

        
        void mainFrom_Load(object sender, EventArgs e)
        {
        }

        private void btnController_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(AntiCracker.gI().decrypt("uSYCQ839xACjFtOZU+qnTiJwkFumPyWE1mIZFnTLn4FTdaH9T+sheixHJtoLNVlfWg1qf5E6TVcV\r\n332DD/D8HVu8tyEOT0+Ag+YT7GJ8sXDdclCZHhPXWf/MbgRSQ4bzRxYHECWpwIsv1gz4bfyP9yR0\r\n+mYXenMt9zsC4rmrWZk="));
            Clipboard.SetText(AntiCracker.gI().encrypt("dragonboypro"));
        }
    }
}
