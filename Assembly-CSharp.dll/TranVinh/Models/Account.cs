using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranVinh.Models
{
    internal static class Account
    {
        internal static string username;
        internal static string password;
        internal static string status = "Đã kết nối!";

        internal static byte stepLogin = 0;
        static int timeLogin = 3;
        static long currLogin = 0;

        internal static int x, y;


        internal static void resetLogin()
        {
            timeLogin = 31;
            stepLogin = 0;
            currLogin = 0;
        }

        internal static void doLogin()
        {
            if (stepLogin == 3)
                return;

            if (!ServerListScreen.loadScreen)
                return;

            if (GameCanvas.currentScreen != null && GameCanvas.currentScreen != SplashScr.instance && (GameCanvas.currentScreen == GameCanvas.serverScreen || GameCanvas.currentScreen == GameCanvas.loginScr))
            {

                if (mSystem.currentTimeMillis() - currLogin >= 1000)
                {
                    currLogin = mSystem.currentTimeMillis();
                    //if(stepLogin == 3)
                    //{
                    //    resetLogin();
                    //}
                    if (stepLogin == 0)
                    {

                        if (timeLogin <= 0)
                        {
                            if (ServerListScreen.testConnect == 2)
                            {
                                stepLogin = 1;
                                currLogin = 0;
                                return;
                            }
                            GameCanvas.serverScreen.switchToMe();
                        }
                        else
                        {
                            timeLogin--;
                        }
                        return;
                    }
                    if (stepLogin == 1)
                    {
                        if (GameCanvas.loginScr == null)
                            GameCanvas.loginScr = new LoginScr();

                        GameCanvas.currentScreen = GameCanvas.loginScr;
                        Service.gI().login(string.Empty, string.Empty, GameMidlet.VERSION, 0);
                        GameCanvas.startWaitDlg();
                        timeLogin = 31;
                        stepLogin = 2;
                        currLogin = 0;
                        return;
                    }
                    if (stepLogin == 2)
                    {
                        if (Char.isLoadingMap)
                        {
                            timeLogin--;
                            if (timeLogin <= 0)
                            {
                                GameCanvas.gI().onDisconnected();
                            }
                            return;
                        }
                        stepLogin = 3;
                    }
                }
            }
            else
            {
                resetLogin();
                stepLogin = 3;
            }
        }
    }
}
