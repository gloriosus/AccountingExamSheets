using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Printing;
using System.Diagnostics;

namespace AccountingExamSheets
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            if (!Directory.Exists(direct))
            {
                Directory.CreateDirectory(direct);
                File.SetAttributes(direct, FileAttributes.Hidden);
            }

            if (!File.Exists(Application.StartupPath + @"\settings.ini"))
            {
                string[] lines = new string[5];
                lines[0] = ";Настройки приложения из меню настроек главной формы";
                lines[1] = "[Default]";
                lines[2] = "faculty=";
                lines[3] = "listformat=";
                lines[4] = "orientation=";
                File.WriteAllLines(Application.StartupPath + @"\settings.ini", lines);
            }

            boxes[0] = checkBox1;
            boxes[1] = checkBox3;
            boxes[2] = checkBox2;
            boxes[3] = checkBox4;
        }

        NewNote newNote = new NewNote();
        Preview preview = new Preview();

        private int counter = 0;
        public int Counter
        {
            get
            {
                return counter;
            }

            set
            {
                counter = value;
            }
        }

        private bool isShown = false;
        public bool IsShown
        {
            get
            {
                return isShown;
            }

            set
            {
                isShown = value;
            }
        }

        private int[] idSheets = new int[] { -1, -1, -1, -1 };
        public int[] IdSheets
        {
            get
            {
                return idSheets;
            }

            set
            {
                idSheets = value;
            }
        }

        private Image[] layout = new Image[4];
        private string direct = Application.StartupPath + @"\Temp";
        private CheckBox[] boxes = new CheckBox[4];

        private bool wasEdited = false;
        public bool WasEdited
        {
            get
            {
                return wasEdited;
            }

            set
            {
                wasEdited = value;
            }
        }

        private int index = -1;




        private void Main_Activated(object sender, EventArgs e)
        {
            if (IsShown)
            {
                SetPreview(boxes[Counter - 1], Counter);
                IsShown = false;
            }

            if (WasEdited)
            {
                SetPreview(boxes[index], index + 1);
                WasEdited = false;
            }
        }

        private void SetPreview(CheckBox checkBox, int counter)
        {
            layout[counter - 1] = preview.DrawPreview(File.ReadAllLines(Application.StartupPath + @"\Temp\list" + counter.ToString() + ".txt"));
            checkBox.BackgroundImage = layout[counter - 1];
        }

        void slide_PrintPage(object sender, PrintPageEventArgs e)
        {
            IniEditor ini = new IniEditor();
            string item = ini.GetValue(Application.StartupPath + @"\settings.ini", "[Default]", "listformat");
            string orient = ini.GetValue(Application.StartupPath + @"\settings.ini", "[Default]", "orientation");

            if (orient == "Сверху")
            {
                e.Graphics.DrawImage(preview.DrawCanvas(layout, new ListFormat(item), false), 0, 0);
            }
            else if(orient == "Снизу")
            {
                e.Graphics.DrawImage(preview.DrawCanvas(layout, new ListFormat(item), true), 0, 0);
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Directory.Delete(direct, true);

            //Сжатие базы данных
            try
            {
                JRO.JetEngine jro = new JRO.JetEngine();
                jro.CompactDatabase("Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Resources\database.accdb", "Provider=Microsoft.Ace.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Resources\newdatabase.accdb;Jet OLEDB:Engine Type=5");
                File.Delete(Application.StartupPath + @"\Resources\database.accdb");
                File.Move(Application.StartupPath + @"\Resources\newdatabase.accdb", Application.StartupPath + @"\Resources\database.accdb");
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString());
            }
        }

        private void StandartDownTS_Click(object sender, EventArgs e)
        {
            newNote.Owner = this;
            newNote.ShowDialog();
        }

        private void StandartTS_Click(object sender, EventArgs e)
        {
            newNote.Owner = this;
            newNote.ShowDialog();
        }

        private void Printing()
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += slide_PrintPage;
            doc.DefaultPageSettings.Landscape = true;
            doc.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);

            try
            {
                doc.Print();
            }
            catch
            {
                MessageBox.Show("Не удалось найти принтер");
            }
        }

        private void PrintDownTS_Click(object sender, EventArgs e)
        {
            Printing();
        }

        private void PrintTS_Click(object sender, EventArgs e)
        {
            Printing();
        }

        private void AboutTS_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Owner = this;
            about.ShowDialog();
        }

        private void ExitTS_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        //Выделение листов в окне предпросмотра

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox1.FlatAppearance.BorderColor = Color.RoyalBlue;
                checkBox1.FlatAppearance.BorderSize = 3;

                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox1.FlatAppearance.BorderColor = Color.Black;
                checkBox1.FlatAppearance.BorderSize = 1;
            }
        }

        private void checkBox3_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                checkBox3.FlatAppearance.BorderColor = Color.RoyalBlue;
                checkBox3.FlatAppearance.BorderSize = 3;

                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox3.FlatAppearance.BorderColor = Color.Black;
                checkBox3.FlatAppearance.BorderSize = 1;
            }
        }

        private void checkBox2_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox2.FlatAppearance.BorderColor = Color.RoyalBlue;
                checkBox2.FlatAppearance.BorderSize = 3;

                checkBox1.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
                checkBox4.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox2.FlatAppearance.BorderColor = Color.Black;
                checkBox2.FlatAppearance.BorderSize = 1;
            }
        }

        private void checkBox4_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox4.CheckState == CheckState.Checked)
            {
                checkBox4.FlatAppearance.BorderColor = Color.RoyalBlue;
                checkBox4.FlatAppearance.BorderSize = 3;

                checkBox1.CheckState = CheckState.Unchecked;
                checkBox2.CheckState = CheckState.Unchecked;
                checkBox3.CheckState = CheckState.Unchecked;
            }
            else
            {
                checkBox4.FlatAppearance.BorderColor = Color.Black;
                checkBox4.FlatAppearance.BorderSize = 1;
            }
        }



        //Удаление выделенного листа со сдвигом

        private void Deleting()
        {
            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i].CheckState == CheckState.Checked && IdSheets[i] != -1)
                {
                    for (int v = i; v < boxes.Length; v++)
                    {
                        boxes[v].BackgroundImage = (v != 3) ? boxes[v + 1].BackgroundImage : null;
                        layout[v] = (v != 3) ? layout[v + 1] : null;
                        IdSheets[v] = (v != 3) ? IdSheets[v + 1] : -1;
                    }
                }
            }

            Counter--;
        }

        private void DeleteTS_Click(object sender, EventArgs e)
        {
            Deleting();
        }

        private void DeleteDownTS_Click(object sender, EventArgs e)
        {
            Deleting();
        }

        //Изменение выделенного листа

        private void Changing()
        {
            for (int i = 0; i < boxes.Length; i++)
            {
                if (boxes[i].CheckState == CheckState.Checked && IdSheets[i] != -1)
                {
                    newNote.Owner = this;
                    newNote.IsEdit = true;
                    newNote.EditId = IdSheets[i];
                    newNote.ComboIndex = i;
                    index = i;
                    newNote.ShowDialog();
                }
            }
        }

        private void ChangeTS_Click(object sender, EventArgs e)
        {
            Changing();
        }

        private void EditDownTS_Click(object sender, EventArgs e)
        {
            Changing();
        }

        private void ListsTS_Click(object sender, EventArgs e)
        {
            Lists lists = new Lists();
            lists.Owner = this;
            lists.ShowDialog();
        }

        private void HelpTS_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\Help\help.html");
        }

        private void OpenTS_Click(object sender, EventArgs e)
        {
            Journal journal = new Journal();
            journal.Owner = this;
            journal.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintSetting sett = new PrintSetting(layout);
            sett.Owner = this;
            sett.ShowDialog();
        }

        private void ElementsTS_Click(object sender, EventArgs e)
        {
            Elements elements = new Elements();
            elements.Owner = this;
            elements.ShowDialog();
        }
    }
}
