using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicEnc
{
    class Encrypter
    {
        Image image;
        int seed;
        string text;
        public Encrypter(Image img)
        {
            image = img;
        }
        private int getSeed(string thisKey)
        {
            int keySeed = 1;
            for (int i = 0; i < thisKey.Length - 1; i++)
                keySeed *= Convert.ToInt32
                    (thisKey[i] * (thisKey[i] + thisKey[i + 1]) - thisKey[ i + 1] * thisKey[i]);
            return keySeed;
        }
        public Bitmap Encrypt(string txt,string key)
        {
            text = txt;
            text += '~';
            int txtSize = text.Length;
            seed = getSeed(key);
            Random rnd = new Random(seed);
            Size[] pix = new Size[txtSize];
            Bitmap bitmap = new Bitmap(image);
            for (int i = 0; i < txtSize ; i++)
            {   
                int thisPixX;
                int thisPixY;
                Size thisPix;
                while (true)
                {
                    thisPixX = rnd.Next(image.Width);
                    thisPixY = rnd.Next(image.Height);
                    thisPix = new Size(thisPixX, thisPixY);

                    bool check = true;
                    foreach (Size p in pix)
                    {
                        if (p == thisPix) { check = false; }
                    }
                    if (check)
                    {
                        pix[i] = thisPix;
                        break;
                    }
                }
                char thisChar = text[i];
                if (thisChar > 1000) thisChar = (char)((int)thisChar - 890);    // костыль для русских букоф
                Color thisColor = bitmap.GetPixel(thisPixX, thisPixY);
                int r = ((byte)thisColor.R & 0xF8) | (thisChar >> 5);
                int g = ((byte)thisColor.G & 0xFC) | ((byte)(thisChar << 3) >> 6);
                int b = ((byte)thisColor.B & 0xF8) | ((byte)(thisChar << 5) >> 5);
                Color newColor = Color.FromArgb(r, g, b);
                bitmap.SetPixel(thisPixX, thisPixY, newColor);
            }
            return bitmap;
        }
        public string Decrypt(string key)
        {
            seed = getSeed(key);
            Random rnd = new Random(seed);
            Size[] pix = new Size[5];
            Bitmap bitmap = new Bitmap(image);
            text = "";
            int i = 0;
            while (!text.EndsWith("~"))
            {
                if (pix[pix.Length-1] != new Size(0,0)) Array.Resize(ref pix, pix.Length + 5);
                int thisPixX;
                int thisPixY;
                Size thisPix;
                while (true)
                {
                    thisPixX = rnd.Next(image.Width);
                    thisPixY = rnd.Next(image.Height);
                    thisPix = new Size(thisPixX, thisPixY);

                    bool check = true;
                    foreach (Size p in pix)
                    {
                        if (p == thisPix) { check = false; }
                    }
                    if (check)
                    {
                        pix[i] = thisPix;
                        break;
                    }
                }
                Color thisColor = bitmap.GetPixel(thisPixX, thisPixY);
                char thisChar = (char)(((byte)thisColor.R & 0x07) << 5 |
                ((byte)thisColor.G & 0x03) << 3 |
                ((byte)thisColor.B & 0x07));
                if (thisChar > 130) thisChar = (char)((byte)thisChar + 890);
                text = text + thisChar;
                i++;
            }
            return text.TrimEnd('~');
        }
    }
}
