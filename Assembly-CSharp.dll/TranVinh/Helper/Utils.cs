using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TranVinh.Helper
{
    internal static class Utils
    {
        public static int getYGround(int x)
        {
            int num = 50;
            int i = 0;
            while (i < 30)
            {
                i++;
                num += 24;
                bool flag = TileMap.tileTypeAt(x, num, 2);
                if (flag)
                {
                    bool flag2 = num % 24 != 0;
                    if (flag2)
                    {
                        num -= num % 24;
                    }
                    return num;
                }
            }
            return num;
        }
        internal static bool IsGetInfoChat<T>(string text, string s)
        {
            if (!text.StartsWith(s))
            {
                return false;
            }
            try
            {
                Convert.ChangeType(text.Substring(s.Length), typeof(T));
            }
            catch
            {
                return false;
            }
            return true;
        }

        internal static T GetInfoChat<T>(string text, string s)
        {
            return (T)Convert.ChangeType(text.Substring(s.Length), typeof(T));
        }
    }
}
