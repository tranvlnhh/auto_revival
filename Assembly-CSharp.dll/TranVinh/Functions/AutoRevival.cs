using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using TranVinh.Helper;
using TranVinh.Models;
using TranVinh.Xmap;

namespace TranVinh.Functions
{
    internal static class AutoRevival
    {
        static int map, zone, x, y;
        internal static int type;
        internal static int typeChar;
        static void get_toa_do()
        {
            switch (type)
            {
                case 0:
                    x = 60;
                    x = Utils.getYGround(60);
                    break;
                case 1:
                    x =  TileMap.pxw / 2;
                    x = Utils.getYGround(TileMap.pxw / 2);
                    break;
                case 2:
                    x = TileMap.pxw - 60;
                    x = Utils.getYGround(TileMap.pxw - 60);
                    break;
                case 3:
                    x = Account.x;
                    y = Account.y;
                    break;
            }

        }
        static Char get_char_revival()
        {
            Char c = Char.myCharz();
            if (typeChar == 1 || typeChar == 2)
            {
                var size = GameScr.vCharInMap.size();
                for (int i = 0; i < size; i++)
                {
                    var cc = GameScr.vCharInMap.elementAt(i) as Char;
                    if (cc != null)
                    {
                        if (typeChar == 1)
                        {
                            //if (cc.cName.Contains())
                            //{

                            //}
                        }
                        else
                        {
                            if (cc.charID == 1)
                            {

                            }
                        }
                    }
                }
            }
            return c;
        }
        internal static void update()
        {
            if (IsWaiting())
                return;

            if(TileMap.mapID != map)
            {
                if (!Pk9rXmap.IsXmapRunning)
                    XmapController.StartRunToMapId(map);
                Wait(5000);
                return;
            }
            if(TileMap.zoneID != zone)
            {
                Service.gI().requestChangeZone(zone);
                Wait(1200);
                return;
            }
            get_toa_do();
            var myCharz = Char.myCharz();
            if(myCharz.cx != x || myCharz.cy != y)
            {
                XmapController.MoveMyChar(x, y);
                Wait(2000);
                return;
            }
            Wait(1000);
        }
        #region
        private static bool IsWait;
        private static long TimeStartWait;
        private static long TimeWait;

        private static void Wait(int time)
        {
            IsWait = true;
            TimeStartWait = mSystem.currentTimeMillis();
            TimeWait = time;
        }

        private static bool IsWaiting()
        {
            if (IsWait && mSystem.currentTimeMillis() - TimeStartWait >= TimeWait)
            {
                IsWait = false;
            }
            return IsWait;
        }
        #endregion
    }
}
