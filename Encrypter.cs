using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        private void AddTilda(string txt, string V)
        {
            switch (V)
            {
                case "File":
                    string textFilePath = txt;
                    using (StreamWriter file = new StreamWriter(textFilePath,true))
                        file.Write("~");
                    break;
                case "TextBox":
                    text = txt + "~";
                    break;
            }
        }
        public Bitmap Encrypt(string txt,string key, string V, 
            int txtSize = 0, Stream fileStream = null)
        {
            Bitmap bitmap = new Bitmap(image);
            seed = getSeed(key);
            Random rnd = new Random(seed);
            switch (V)
            {
                case "File":
                    int i = 0;
                    string textFilePath = txt;
                    AddTilda(textFilePath, "File");
                    //pix = new Size[txtSize];
                    var pix = new Dictionary<int, Size>();
                    using (StreamReader file = new StreamReader(textFilePath, Encoding.UTF8))
                    {
                        while (file.Peek() != -1)
                        {
                            int thisPixX;
                            int thisPixY;
                            
                            Size thisPix;
                            while (true)
                            {
                                thisPixX = rnd.Next(image.Width);
                                thisPixY = rnd.Next(image.Height);
                                thisPix = new Size(thisPixX, thisPixY);
                                if (!pix.ContainsValue(thisPix))
                                {
                                    pix.Add(i,thisPix);
                                    i++;
                                    break;
                                }
                            }
                            char thisChar = (char)file.Read();
                            if (thisChar > 1000) thisChar = (char)((int)thisChar - 890);    // костыль для русских букоф
                            Color thisColor = bitmap.GetPixel(thisPixX, thisPixY);
                            int r = ((byte)thisColor.R & 0xF8) | (thisChar >> 5);
                            int g = ((byte)thisColor.G & 0xFC) | ((byte)(thisChar << 3) >> 6);
                            int b = ((byte)thisColor.B & 0xF8) | ((byte)(thisChar << 5) >> 5);
                            Color newColor = Color.FromArgb(r, g, b);
                            bitmap.SetPixel(thisPixX, thisPixY, newColor);
                        }
                    }
                    break;
                case "textBox":
                    AddTilda(txt, "textBox");
                    txtSize = text.Length;
                    pix = new Dictionary<int, Size>();
                    int j = 0;
                    for (i = 0; i < txtSize; i++)
                    {
                        int thisPixX;
                        int thisPixY;
                        Size thisPix;
                        while (true)
                        {
                            thisPixX = rnd.Next(image.Width);
                            thisPixY = rnd.Next(image.Height);
                            thisPix = new Size(thisPixX, thisPixY);
                            if (!pix.ContainsValue(thisPix))
                            {
                                pix.Add(j, thisPix);
                                j++;
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
                    break;
            }
            return bitmap;
        }
        public string Decrypt(string key, bool V, string txt = "")
        {
            seed = getSeed(key);
            Random rnd = new Random(seed);
            var pix = new Dictionary<int, Size>();
            Bitmap bitmap = new Bitmap(image);
            int i = 0;
            switch (V)
            {
                case true:
                    while (true)
                    {
                        int thisPixX;
                        int thisPixY;
                        Size thisPix;
                        while (true)
                        {
                            thisPixX = rnd.Next(image.Width);
                            thisPixY = rnd.Next(image.Height);
                            thisPix = new Size(thisPixX, thisPixY);
                            if (!pix.ContainsValue(thisPix))
                            {
                                pix.Add(i, thisPix);
                                i++;
                                break;
                            }
                        }
                        Color thisColor = bitmap.GetPixel(thisPixX, thisPixY);
                        char thisChar = (char)(((byte)thisColor.R & 0x07) << 5 |
                        ((byte)thisColor.G & 0x03) << 3 |
                        ((byte)thisColor.B & 0x07));
                        if (thisChar > 130) thisChar = (char)((byte)thisChar + 890);
                        string textFilePath = txt;
                        if (thisChar == '~')
                        {
                            return "Успех";
                        }
                        using (StreamWriter file = new StreamWriter(textFilePath, true, Encoding.UTF8))
                        {
                            file.Write(thisChar);
                        }
                    }
                case false:
                    seed = getSeed(key);
                    text = "";
                    while (!text.EndsWith("~"))
                    {
                        int thisPixX;
                        int thisPixY;
                        Size thisPix;
                        while (true)
                        {
                            thisPixX = rnd.Next(image.Width);
                            thisPixY = rnd.Next(image.Height);
                            thisPix = new Size(thisPixX, thisPixY);
                            if (!pix.ContainsValue(thisPix))
                            {
                                pix.Add(i, thisPix);
                                i++;
                                break;
                            }
                        }
                        Color thisColor = bitmap.GetPixel(thisPixX, thisPixY);
                        char thisChar = (char)(((byte)thisColor.R & 0x07) << 5 |
                        ((byte)thisColor.G & 0x03) << 3 |
                        ((byte)thisColor.B & 0x07));
                        if (thisChar > 130) thisChar = (char)((byte)thisChar + 890);
                        text = text + thisChar;
                    }
                    return text.TrimEnd('~');
            }
            return "Что-то пошло не так";
        }
    }
}
