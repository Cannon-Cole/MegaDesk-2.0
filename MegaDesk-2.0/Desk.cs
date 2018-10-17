using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_ColeCannon
{
    class Desk
    {
        public const int MIN_WIDTH = 24;
        public const int MAX_WIDTH = 96;
        public const int MIN_HEIGHT = 12;
        public const int MAX_HEIGHT = 48;

        public int height { get; set; }
        public int width { get; set; }
        public int drawers { get; set; }
        public string rush { get; set; }
        public string material { get; set; }
    }

    public enum Materials
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    };

    /*public struct Desk
    {
        private int height { get; set; }
        private int width { get; set; }
        private int drawers { get; set; }
        private int rush { get; set; }
        private string material { get; set; }
    }*/
}
