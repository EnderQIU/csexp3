using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lena
{
    class ImageProcessor
    {
        public static Image Clockwise(Image image)
        {
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            return image;
        }

        public static Image AntiClockwise(Image image)
        {
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            return image;
        }

        public static Image HorizenalFlit(Image image)
        {
            image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            return image;
        }

        public static Image VerticalFlit(Image image)
        {
            image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            return image;
        }

        public static Image SetR(Image image, Image o_image, int r)
        {
            r = r * 3;
            Bitmap o_map = new Bitmap(o_image);
            Bitmap map = new Bitmap(image);
            Color color = new Color();
            for (int x = 1; x < map.Width; x++)
            {
                for (int y = 1; y < map.Height; y++)
                {
                    color = o_map.GetPixel(x, y);
                    if (color.R+r > 255) map.SetPixel(x, y, Color.FromArgb(255, color.G, color.B));
                    else if (color.R + r < 0) map.SetPixel(x, y, Color.FromArgb(0, color.G, color.B));
                    else map.SetPixel(x, y, Color.FromArgb(color.R+r, color.G, color.B));
                }
            }
            return map;
        }

        public static Image SetG(Image image, Image o_image, int r)
        {
            r = r * 3;
            Bitmap o_map = new Bitmap(o_image);
            Bitmap map = new Bitmap(image);
            Color color = new Color();
            for (int x = 1; x < map.Width; x++)
            {
                for (int y = 1; y < map.Height; y++)
                {
                    color = o_map.GetPixel(x, y);
                    if (color.G + r > 255) map.SetPixel(x, y, Color.FromArgb(color.R, 255, color.B));
                    else if (color.G + r < 0) map.SetPixel(x, y, Color.FromArgb(color.R, 0, color.B));
                    else map.SetPixel(x, y, Color.FromArgb(color.R, color.G+r, color.B));
                }
            }
            return map;
        }

        public static Image SetB(Image image, Image o_image, int r)
        {
            r = r * 3;
            Bitmap o_map = new Bitmap(o_image);
            Bitmap map = new Bitmap(image);
            Color color = new Color();
            for (int x = 1; x < map.Width; x++)
            {
                for (int y = 1; y < map.Height; y++)
                {
                    color = o_map.GetPixel(x, y);
                    if (color.B + r > 255) map.SetPixel(x, y, Color.FromArgb(color.R, color.G, 255));
                    else if (color.B + r < 0) map.SetPixel(x, y, Color.FromArgb(color.R, color.G, 0));
                    else map.SetPixel(x, y, Color.FromArgb(color.R, color.G, color.B + r));
                }
            }
            return map;
        }

        public static Image Greyscale(Image image)
        {
            Bitmap map = new Bitmap(image);
            Color color = new Color();
            int gray;
            for (int x = 1; x < map.Width; x++)
            {
                for (int y = 1; y < map.Height; y++)
                {
                    color = map.GetPixel(x, y);
                    gray = (color.R * 30 + color.G * 59 + color.B * 11 + 50) / 100;
                    map.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            return map;
        }

        private static int SafePM(int x, int y)
        {
            int a = x + y;
            if (a < 0) return 0;
            else if (a > 255) return 255;
            else return a;
        }

        public static Image BrightnessAdjust(Image o_image, int r)
        {
            Bitmap map = new Bitmap(o_image);
            Color color = new Color();
            for (int x = 1; x < map.Width; x++)
            {
                for (int y = 1; y < map.Height; y++)
                {
                    color = map.GetPixel(x, y);
                    map.SetPixel(x, y, Color.FromArgb(SafePM(color.R,r), SafePM(color.G,r), SafePM(color.B, r)));
                }
            }
            return map;
        }

        private static Color AvgColor(List<Color> colors)
        {
            int R = 0;
            int G = 0;
            int B = 0;
            foreach(Color color in colors)
            {
                R += color.R;
                G += color.G;
                B += color.B;
            }
            int num = colors.Count;
            return Color.FromArgb(R / num, G / num, B / num);
        }

        public static Image GaussianBlur(Image o_image, int r)
        {
            Bitmap map = new Bitmap(o_image);
            List<Color> colors = new List<Color>();
            for (int x = 1; x < map.Width; x++)
            {
                for (int y = 1; y < map.Height; y++)
                {
                    // 周围值采样
                    for (int k = 0; k <= 2*r; k++)
                    {
                        for (int l = 0; k <= 2 * r; k++)
                        {
                            try
                            {
                                colors.Add(map.GetPixel(x + k - r, y + l - r));
                            }
                            catch (ArgumentOutOfRangeException e)
                            {
                                colors.Add(map.GetPixel(x, y));
                            }
                        }
                    }
                    map.SetPixel(x, y, AvgColor(colors));
                }
            }
            return map;
        }
    }
}
