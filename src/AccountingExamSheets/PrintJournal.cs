using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using Access = Microsoft.Office.Interop.Access;
using Microsoft.Office.Interop.Access.Dao;
using System.Reflection;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace AccountingExamSheets
{
    class PrintJournal
    {
        private Access.Application _application;

        private Object missingObj = System.Reflection.Missing.Value;
        private Object trueObj = true;
        private Object falseObj = false;

        public void PrintOut()
        {
            _application = new Access.Application();
            _application.OpenCurrentDatabase(Application.StartupPath + @"\Resources\database.accdb", false, "");
            _application.Visible = false;

            _application.DoCmd.OpenReport("customreport", Access.AcView.acViewPreview, Type.Missing, Type.Missing, Access.AcWindowMode.acWindowNormal, Type.Missing);
            _application.DoCmd.PrintOut(Access.AcPrintRange.acPrintAll, Type.Missing, Type.Missing, Access.AcPrintQuality.acHigh, Type.Missing, Type.Missing);

            _application.CloseCurrentDatabase();
            _application = null;
        }

        public void PrintOut(int page)
        {
            _application = new Access.Application();
            _application.OpenCurrentDatabase(Application.StartupPath + @"\Resources\database.accdb", false, "");
            _application.Visible = false;

            _application.DoCmd.OpenReport("customreport", Access.AcView.acViewPreview, Type.Missing, Type.Missing, Access.AcWindowMode.acWindowNormal, Type.Missing);
            _application.DoCmd.PrintOut(Access.AcPrintRange.acPages, page, page, Access.AcPrintQuality.acHigh, Type.Missing, Type.Missing);

            _application.CloseCurrentDatabase();
            _application = null;
        }

        public void PrintOut(int from, int to)
        {
            _application = new Access.Application();
            _application.OpenCurrentDatabase(Application.StartupPath + @"\Resources\database.accdb", false, "");
            _application.Visible = false;

            _application.DoCmd.OpenReport("customreport", Access.AcView.acViewPreview, Type.Missing, Type.Missing, Access.AcWindowMode.acWindowNormal, Type.Missing);
            _application.DoCmd.PrintOut(Access.AcPrintRange.acPages, from, to, Access.AcPrintQuality.acHigh, Type.Missing, Type.Missing);

            _application.CloseCurrentDatabase();
            _application = null;
        }

        /*
        public Image Generate(string[,] array)
        {
            Bitmap bit = new Bitmap(2480, 3508);
            bit.SetResolution(300.0f, 300.0f);

            Graphics g = Graphics.FromImage(bit);
            g.FillRectangle(Brushes.White, new Rectangle(0, 0, bit.Width, bit.Height));

            int margin = 50;
            Font font = new Font("TimesNewRoman", 14);
            Pen pen = new Pen(Color.Black, 5);
            int height = (int)g.MeasureString("Название\nдисциплины", font).Height;
            int width = 50;

            int[] coord = new int[7];

            string[] lines = { "№ п\\п", "Дата выдачи", "Ф.И.О. студента", "№ группы", "Название\nдисциплины", "Ф.И.О.\nпреподавателя" };

            for(int i = 0; i < lines.Length; i++)
            {
                coord[i] = width - (margin / 2);
                g.DrawString(lines[i], font, Brushes.Black, width, margin);
                width = (int)g.MeasureString(lines[i], font).Width + width + margin;

                if (i < 5)
                {
                    g.DrawLine(pen, new Point(width - (margin / 2), 0), new Point(width - (margin / 2), bit.Height));
                }
            }

            coord[6] = bit.Width;

            int h = 0;

            for(int c = 0; c < array.GetLength(0); c++)
            {
                h = (margin + height + margin) * (c + 1);

                for (int s = 0; s < array.GetLength(1); s++)
                {
                    int del = (int)(g.MeasureString(array[c, s], font).Width / (coord[s + 1] - coord[s]));

                    if (del > 0)
                    {
                        string[] split = { array[c, s].Substring(0, array[c, s].Length / 2), array[c, s].Substring(array[c, s].Length / 2) };
                        string output = "";

                        for (int w = 0; w < del; w++)
                        {
                            string[] sp1 = { split[0].Substring(0, split[0].Length / 2), split[0].Substring(split[0].Length / 2) };
                            string[] sp2 = { split[1].Substring(0, split[1].Length / 2), split[1].Substring(split[1].Length / 2) };

                            //output = split[0] + "-\n" + split[1];
                            output = sp1[0] + "-\n" + sp1[1] + "-\n" + sp2[0] + "-\n" + sp2[1];
                        }

                        //string[] split = { array[c, s].Substring(0, array[c, s].Length / 2), array[c, s].Substring(array[c, s].Length / 2) };
                        g.DrawString(output, font, Brushes.Black, coord[s], h + margin);
                    }
                    else
                    {
                        g.DrawString(array[c, s], font, Brushes.Black, coord[s], h + margin);
                    }

                    g.DrawLine(pen, new Point(0, h), new Point(bit.Width, h));
                }
            }

            return bit;
        }
        */
    }
}
