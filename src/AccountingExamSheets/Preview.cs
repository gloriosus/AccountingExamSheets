using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AccountingExamSheets
{
    class Preview
    {
        public Image DrawPreview(string[] lines)
        {
            Bitmap bit = new Bitmap(1754, 1240);
            bit.SetResolution(300.0f, 300.0f);
            Image img = bit;
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(new SolidBrush(Color.White), 0, 0, 1754, 1240);

            Font regular = new Font("TimesNewRoman", 12);
            Font underline = new Font("TimesNewRoman", 12, FontStyle.Underline);

            for (int i = 0; i < lines.Length; i++)
            {
                if (i == 5 || i == 7)
                {
                    g.DrawString(lines[i], underline, Brushes.Black, 50, i * 60);
                }
                else if (i == 8 || i == 9 || i == 10 || i == 12 || i == 13)
                {
                    string[] parts = lines[i].Split('#');
                    float width = g.MeasureString(parts[0], regular).Width;
                    g.DrawString(parts[0], regular, Brushes.Black, 50, i * 60);
                    g.DrawString(parts[1], underline, Brushes.Black, 50 + width, i * 60);
                }
                else if (i == 11)
                {
                    string[] parts = lines[i].Split('#');

                    float width = g.MeasureString(parts[0], regular).Width;
                    g.DrawString(parts[0], regular, Brushes.Black, 50, i * 60);
                    g.DrawString(parts[1], underline, Brushes.Black, 50 + width, i * 60);

                    width = g.MeasureString(parts[0] + parts[1], regular).Width;
                    g.DrawString(parts[2], regular, Brushes.Black, 50 + width, i * 60);
                    width = g.MeasureString(parts[0] + parts[1] + parts[2], regular).Width;
                    g.DrawString(parts[3], underline, Brushes.Black, 50 + width, i * 60);

                    width = g.MeasureString(parts[0] + parts[1] + parts[2] + parts[3], regular).Width;
                    g.DrawString(parts[4], regular, Brushes.Black, 50 + width, i * 60);
                    width = g.MeasureString(parts[0] + parts[1] + parts[2] + parts[3] + parts[4], regular).Width;
                    g.DrawString(parts[5], underline, Brushes.Black, 50 + width, i * 60);
                }
                else
                {
                    g.DrawString(lines[i], regular, Brushes.Black, 50, i * 60);
                }
            }

            g.DrawImage(DrawAngleText(File.ReadAllText(Application.StartupPath + @"\Resources\abstract.txt"), 300, 1240, 9, 270), 1454, 0);

            return img;
        }

        private Image DrawAngleText(string text, int width, int height, int fontSize, int angle)
        {
            Bitmap bit = new Bitmap(width, height);
            bit.SetResolution(300.0f, 300.0f);
            Image img = bit;
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, width, height));
            g.TranslateTransform(0, (float)(height - 90));
            g.RotateTransform(angle);
            g.DrawString(text, new Font("TimesNewRoman", fontSize), Brushes.Black, 0, 0);
            g.RotateTransform(-angle);
            return img;
        }

        public Image DrawCanvas(Image[] layout, ListFormat format, bool orient)
        {
            Bitmap bit = new Bitmap(format.ImageSize.Width, format.ImageSize.Height);
            bit.SetResolution(300.0f, 300.0f);
            Image img = bit;
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(Brushes.White, new Rectangle(new Point(0, 0), format.ImageSize));

            for (int i = 0; i < layout.Length; i++)
            {
                if (layout[i] != null)
                {
                    if (format.CurrentFormat == "A4")
                    {
                        if (!orient)
                        {
                            g.DrawImage(layout[i], (i == 0 || i == 1) ? 0 : format.ImageSize.Width / 2, (i == 0 || i == 2) ? 0 : format.ImageSize.Height / 2);
                        }
                        else
                        {
                            g.DrawImage(layout[i], (i == 0 || i == 1) ? format.ImageSize.Width / 2 : 0, (i == 0 || i == 2) ? 0 : format.ImageSize.Height / 2);
                        }
                    }
                    else if (format.CurrentFormat == "A5")
                    {
                        g.DrawImage(layout[i], 0, (i == 0) ? 0 : format.ImageSize.Height / 2);
                    }
                    else if(format.CurrentFormat == "A6")
                    {
                        g.DrawImage(layout[i], 0, 0);
                        break;
                    }
                }
            }

            if (format.CurrentFormat == "A4")
            {
                g.DrawLine(new Pen(Brushes.Black), new Point(0, format.ImageSize.Height / 2), new Point(format.ImageSize.Width, format.ImageSize.Height / 2));
                g.DrawLine(new Pen(Brushes.Black), new Point(format.ImageSize.Width / 2, 0), new Point(format.ImageSize.Width / 2, format.ImageSize.Height));
            }
            else if (format.CurrentFormat == "A5")
            {
                g.DrawLine(new Pen(Brushes.Black), new Point(0, format.ImageSize.Height / 2), new Point(format.ImageSize.Width, format.ImageSize.Height / 2));
            }
            
            return img;
        }
    }

    class ListFormat
    {
        public ListFormat(string format)
        {
            if (format == "A4")
            {
                ImageSize = new Size(3508, 2480);
                CurrentFormat = "A4";
            }
            else if(format == "A5")
            {
                ImageSize = new Size(1748, 2480);
                CurrentFormat = "A5";
            }
            else if(format == "A6")
            {
                ImageSize = new Size(1748, 1240);
                CurrentFormat = "A6";
            }
        }

        private Size imageSize;
        public Size ImageSize
        {
            get
            {
                return imageSize;
            }

            set
            {
                imageSize = value;
            }
        }

        private string currentFormat;
        public string CurrentFormat
        {
            get
            {
                return currentFormat;
            }

            set
            {
                currentFormat = value;
            }
        }
    }
}
