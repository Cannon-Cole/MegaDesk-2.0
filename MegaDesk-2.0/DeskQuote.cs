using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_ColeCannon
{
    class DeskQuote
    {
        public static int getPrice(int height, int width, string material, string rush, int drawer)
        {
            int price = 200;
            price += surfaceAreaPrice(height, width);
            price += getMaterialPrice(material);
            price += getRushPrice(rush, height, width);
            price += getDrawerPrice(drawer);

            return price;
        }

        public static int calculateSurfaceArea(int height, int width)
        {
            return height * width;
        }

        public static int surfaceAreaPrice(int height, int width)
        {
            int surfaceArea = calculateSurfaceArea(height, width);

            if (surfaceArea - 1000 > 0)
                return surfaceArea - 1000;
            else
                return 0;
        }

        public static int getMaterialPrice(string material)
        {
            //returns price of material selected
            string[] names = Enum.GetNames(typeof(Materials));
            for (int i = 0; i < names.Length; i++)
            {
                if (material == names[i])
                {
                    int[] value = (int[])Enum.GetValues(typeof(Materials));
                    return value[i];
                }
            }

            //should never run
            return 0;
        }

        public static int getRushPrice(string rush, int height, int width)
        {
            int days;

            if (rush != "None")
            {
                days = Int32.Parse(rush.Split(null)[0]);
            }
            else
            {
                days = 0;
            }

            int[,] rushCost = {
                { 60, 70, 80 },
                { 40, 50, 60 },
                { 30, 35, 40 }
            };

            int index;
            int area = calculateSurfaceArea(height, width);

            if (area > 2000)
            {
                index = 2;
            }
            else if (area > 1000)
            {
                index = 1;
            }
            else
            {
                index = 0;
            }

            switch (days)
            {
                case 3:
                    return rushCost[0, index];
                case 5:
                    return rushCost[1, index]; ;
                case 7:
                    return rushCost[2, index]; ;
                default:
                    return 0;
            }

        }

        public static int getDrawerPrice(int numOfDrawers)
        {
            return numOfDrawers * 50;
        }
    }
}
