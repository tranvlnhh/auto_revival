using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTK.Models
{
    public class Server
    {
        //Green 01:103.48.194.46:14445:0,Blue 01:103.48.194.146:14445:0,Blue 02:103.48.194.152:14445:0,Blue 03:45.119.81.28:14445:0,Blue 04:45.119.81.51:14445:0,Blue 05:103.48.194.173:14445:0,Blue 06:103.48.194.137:14445:0,0,0
        public static Server[] servers = new Server[]
        {
            new Server("Green 01", "103.48.194.46", 14445),
            new Server("Blue 01", "103.48.194.146", 14445),
            new Server("Blue 02", "103.48.194.152", 14445),
            new Server("Blue 03", "45.119.81.28", 14445),
            new Server("Blue 04", "45.119.81.51", 14445),
            new Server("Blue 05", "103.48.194.173", 14445),
            new Server("Blue 06", "103.48.194.137", 14445),
            //new Server() { name = "Võ đài Liên Vũ Trụ", ip = "dragonwar.teamobi.com", port = 20000, language = 0 },
            //new Server() { name = "Indonaga", ip = "dragon.indonaga.com", port = 14446, language = 2 },
            //new Server() { name = "Universe 1", ip = "dragon.indonaga.com", port = 14445, language = 2 },
        };
        public string name { get; set; }
        public string ip { get; set; }
        public int port { get; set; }
        public int language { get; set; }

        public Server(string name, string ip, int port)
        {
            this.name = name;
            this.ip = ip;
            this.port = port;
            this.language = 0;
        }
        public Server(string name, string ip, int port, int language)
        {
            this.name = name;
            this.ip = ip;
            this.port = port;
            this.language = language;
        }
        
        public override string ToString()
            => name;
        
    }
}
