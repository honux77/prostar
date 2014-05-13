using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace imageviewer
{
    public class ImageData
    {
        public int width;
        public int height;
        public int[] pixel;

        public void loadFromImage(Image img)
        {
            width = img.Width;
            height = img.Height;
            pixel = new int[width * height];
            
            Bitmap bm = new Bitmap(img);
            for (int i = 0; i < img.Height; i++)
                for (int j = 0; j < img.Width; j++)
                    pixel[i * width + j] = (bm.GetPixel(j, i).ToArgb());          
           
        }        
    }

}
