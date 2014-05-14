using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace imageviewer
{
    public class ImageData
    {
        public int width;
        public int height;
        public int[] pixel;

        public void LoadFromImage(Image img)
        {            
            width = img.Width;
            height = img.Height;
            pixel = new int[height * width];
            
            Bitmap bm = new Bitmap(img);
            for (int i = 0; i < img.Height; i++)
                for (int j = 0; j < img.Width; j++)
                    pixel[i * width + j] = (bm.GetPixel(j, i).ToArgb());                     
        }

        public static ImageData LoadFromData(string filename)
        {            
            StreamReader sr = new StreamReader(filename, Encoding.GetEncoding("euc-kr"));                 
            XmlSerializer xs = new XmlSerializer(typeof(ImageData));
            ImageData im = (ImageData) xs.Deserialize(sr);
            return im;
        }
        public Bitmap GetBmp()
        {
            Bitmap bmp = new Bitmap(width, height);
            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                    bmp.SetPixel(j, i, Color.FromArgb(pixel[i * width + j]));
            return bmp;
        }
        public void Save(string filename)
        {
            StreamWriter sw = new StreamWriter(filename, false, Encoding.GetEncoding("euc-kr"));
            XmlSerializer xs = new XmlSerializer(typeof(ImageData));
            xs.Serialize(sw, this);
            sw.Close();
        }
    }

}
