using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AccountingExamSheets
{
    public partial class PrintSetting : Form
    {
        public PrintSetting(Image[] imageArray)
        {
            InitializeComponent();
            layout = imageArray;
        }

        Preview preview = new Preview();
        Image[] layout;
        string currentFormat = "";

        private void button1_Click(object sender, EventArgs e)
        {
            Printing("A4");
            Close();
        }

        void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            IniEditor ini = new IniEditor();
            string orient = ini.GetValue(Application.StartupPath + @"\settings.ini", "[Default]", "orientation");

            if (orient == "Сверху")
            {
                e.Graphics.DrawImage(preview.DrawCanvas(layout, new ListFormat(currentFormat), false), 0, 0);
            }
            else if(orient == "Снизу")
            {
                e.Graphics.DrawImage(preview.DrawCanvas(layout, new ListFormat(currentFormat), true), 0, 0);
            }
        }

        private void Printing(string format)
        {
            currentFormat = format;
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += doc_PrintPage;
            doc.DefaultPageSettings.Landscape = true;
            doc.Print();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Printing("A5");
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Printing("A6");
            Close();
        }
    }
}
