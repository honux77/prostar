using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
namespace miro
{
    public class Game
    {
        public const int WMAX = 15;
        public const int HMAX = 10;
        public char[,] map = new char[HMAX, WMAX];
        public int W;
        public int H;
        List<Bitmap> tile;
        List<Bitmap> popi;
        public void Load()
        {
            byte[] mapData = Encoding.UTF8.GetBytes(Properties.Resources.map);
            
            int i, j;
            i = j= W = 0;
            foreach (byte b in mapData)
            {
                map[i, j] = (char) b;
                i++;
                if (b == '\n')
                {
                    j++;
                    if (i > W)
                        W = i;
                    i = 0;
                }
            }
            W--;
            H = j;
        }
    }
}
