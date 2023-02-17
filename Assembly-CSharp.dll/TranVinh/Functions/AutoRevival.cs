using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Xml.Linq;
using TranVinh.Helper;
using TranVinh.Models;
using TranVinh.Xmap;

namespace TranVinh.Functions
{
    internal static class AutoRevival
    {
        internal static int map, zone, x, y;
        internal static int type;
        internal static int typeChar;
        internal static string charNameRevival;
        internal static int charIdRevival;
        internal static bool delay, isRevival;
        static void get_toa_do()
        {
            switch (type)
            {
                case 0:
                    x = 60;
                    y = Utils.getYGround(60);
                    break;
                case 1:
                    x =  TileMap.pxw / 2;
                    y = Utils.getYGround(TileMap.pxw / 2);
                    break;
                case 2:
                    x = TileMap.pxw - 60;
                    y = Utils.getYGround(TileMap.pxw - 60);
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
                            if (cc.cName.Contains(charNameRevival))
                            {
                                c = cc;
                                break;
                            }
                        }
                        else
                        {
                            if (cc.charID == charIdRevival)
                            {
                                c = cc;
                                break;
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
                {
                    XmapController.StartRunToMapId(map);
                    DragonClient.send_status($"Go to {TileMap.mapNames[map]}!");
                }
                Wait(5000);
                return;
            }
            if(TileMap.zoneID != zone)
            {
                DragonClient.send_status($"Change to zone {zone}!");
                Service.gI().requestChangeZone(zone);
                Wait(1200);
                return;
            }
            get_toa_do();
            var myCharz = Char.myCharz();
            if(myCharz.cx != x || myCharz.cy != y)
            {

                DragonClient.send_status($"Move to [{x}; {y}]!");
                GC.Collect();
                XmapController.MoveMyChar(x, y);
                Wait(2000);
                return;
            }
            if (myCharz.cgender != 1)
            {
                DragonClient.send_status("Not namek!");
                return;
            }

            DragonClient.send_status("Waiting revival!");
            var chareRevival = get_char_revival();
            if (myCharz.myskill.template.id != 7)
            {
                var s = get_skill_revival();
                if (s == null)
                    return;

                myCharz.myskill =s;
                Service.gI().selectSkill(7);
                Wait(1000);
                return;
            }
            if (isRevival && delay)
                return;
            var currTime = mSystem.currentTimeMillis();
            var timeRetrieval = currTime - myCharz.myskill.lastTimeUseThisSkill;
            var coolDown = myCharz.myskill.coolDown + 500;
            if (timeRetrieval < coolDown)
            {
                Wait(coolDown - timeRetrieval);
                return;
            }
            Service.gI().sendPlayerAttack(chareRevival);
            myCharz.myskill.lastTimeUseThisSkill = mSystem.currentTimeMillis();
            if (delay)
                DragonClient.sendDelay();
            DragonClient.send_status("Revived!");
            Wait(1000);
        }

        static Skill get_skill_revival()
        {
            var myCharz = Char.myCharz();
            for (int i = 0; i < myCharz.vSkill.size(); i++)
            {
                var s = (Skill)myCharz.vSkill.elementAt(i);
                if (s.template.id == 7)
                {
                    return s;
                }
            }
            return null;
        }
        #region
        private static bool IsWait;
        private static long TimeStartWait;
        private static long TimeWait;

        internal static void Wait(int time)
        {
            IsWait = true;
            TimeStartWait = mSystem.currentTimeMillis();
            TimeWait = time;
        }
        private static void Wait(long time)
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
