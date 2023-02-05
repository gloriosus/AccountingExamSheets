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
    public partial class Journal : Form
    {
        public Journal()
        {
            InitializeComponent();
        }

        DBConnection db = new DBConnection();

        string[,] records;
        string[,] students;
        string[,] groups;
        string[,] subjects;
        string[,] examinators;

        private int currentPage = 1;

        public int CurrentPage
        {
            get { return currentPage; }

            set { currentPage = value; }
        }

        private void Journal_Load(object sender, EventArgs e)
        {
            records = db.ExtraQuery("SELECT number, idExaminator, idSubject, idStudent, dateOut FROM sheet");
            students = db.ExtraQuery("SELECT id, family, `name`, otchestvo, idGroup FROM student");
            groups = db.ExtraQuery("SELECT id, number FROM `group`");
            subjects = db.ExtraQuery("SELECT id, title FROM subject");
            examinators = db.ExtraQuery("SELECT id, family, init FROM examinator");

            int length = records.GetLength(0);
            Page.Text = "1";
            LastPage.Text = Round(Convert.ToDouble(length) / 10).ToString();
            DataGrid.RowCount = 10;

            Update(currentPage, DataGrid.RowCount);

            Prev.Image = DrawTriangle(Color.DodgerBlue);
            First.Image = DrawDoubleTriangle(Color.DodgerBlue);
            Next.Image = DrawTriangle(Color.DodgerBlue);
            Next.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            Last.Image = DrawDoubleTriangle(Color.DodgerBlue);
            Last.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        //Update(1, length - (DataGrid.RowCount * (Convert.ToInt32(textBox1.Text) - 1)));

        private void PrintContext_Click(object sender, EventArgs e)
        {
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += doc_PrintPage;
            doc.Print();
        }

        void doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap grid = new Bitmap(DataGrid.Width, DataGrid.Height);
            DataGrid.DrawToBitmap(grid, DataGrid.Bounds);
            e.Graphics.DrawImage(grid, 0, 0);
        }

        public int Round(double number)
        {
            int rounded = Convert.ToInt32(number);

            if(number - rounded > 0)
            {
                rounded++;
            }

            return rounded;
        }

        private void Update(int page, int limit)
        {
            for (int i = 0; i < (page < Convert.ToInt32(LastPage.Text) ? limit : records.GetLength(0) % limit); i++)
            {
                int mem = 0;

                DataGrid.Rows[i].Cells[0].Value = records[i + ((page - 1) * limit), 0];

                for (int v = 0; v < students.GetLength(0); v++)
                {
                    if (records[i + ((page - 1) * limit), 3] == students[v, 0])
                    {
                        DataGrid.Rows[i].Cells[2].Value = students[v, 1] + " " + students[v, 2][0] + "." + students[v, 3][0] + ".";
                        break;
                    }
                }

                for (int m = 0; m < students.GetLength(0); m++)
                {
                    if (DataGrid.Rows[i].Cells[2].Value.ToString() == students[m, 1] + " " + students[m, 2][0] + "." + students[m, 3][0] + ".")
                    {
                        mem = m;
                    }
                }

                for (int n = 0; n < groups.GetLength(0); n++)
                {
                    if (students[mem, 4] == groups[n, 0])
                    {
                        DataGrid.Rows[i].Cells[3].Value = groups[n, 1];
                        break;
                    }
                }

                for (int c = 0; c < subjects.GetLength(0); c++)
                {
                    if (records[i + ((page - 1) * limit), 2] == subjects[c, 0])
                    {
                        DataGrid.Rows[i].Cells[4].Value = subjects[c, 1];
                        break;
                    }
                }

                for (int f = 0; f < examinators.GetLength(0); f++)
                {
                    if (records[i + ((page - 1) * limit), 1] == examinators[f, 0])
                    {
                        DataGrid.Rows[i].Cells[5].Value = examinators[f, 1] + " " + examinators[f, 2];
                        break;
                    }
                }

                DataGrid.Rows[i].Cells[1].Value = records[i + ((page - 1) * limit), 4].Split(' ')[0];
            }
        }

        private void Clear()
        {
            for(int i = 0; i < DataGrid.Rows.Count; i++)
            {
                for(int v = 0; v < DataGrid.Rows[0].Cells.Count; v++)
                {
                    DataGrid.Rows[i].Cells[v].Value = "";
                }
            }
        }

        public Image DrawTriangle(Color color)
        {
            Bitmap bit = new Bitmap(16, 16);
            Image image = bit;
            Graphics g = Graphics.FromImage(image);

            Point[] points = new Point[3];
            points[0] = new Point(16, 0);
            points[1] = new Point(16, 16);
            points[2] = new Point(0, 8);


            g.FillPolygon(new SolidBrush(color), points);

            return image;
        }

        public Image DrawDoubleTriangle(Color color)
        {
            Bitmap bit = new Bitmap(16, 16);
            Image image = bit;
            Graphics g = Graphics.FromImage(image);

            Point[] points = new Point[3];
            points[0] = new Point(8, 0);
            points[1] = new Point(8, 16);
            points[2] = new Point(0, 8);

            g.FillPolygon(new SolidBrush(color), points);

            points[0] = new Point(16, 0);
            points[1] = new Point(16, 16);
            points[2] = new Point(8, 8);

            g.FillPolygon(new SolidBrush(color), points);

            return image;
        }

        private void First_Click(object sender, EventArgs e)
        {
            Clear();
            currentPage = 1;
            Update(currentPage, DataGrid.RowCount);
            Page.Text = currentPage.ToString();
        }

        private void Prev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                Clear();
                currentPage--;
                Update(currentPage, DataGrid.RowCount);
                Page.Text = currentPage.ToString();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (currentPage < Convert.ToInt32(LastPage.Text))
            {
                Clear();
                currentPage++;
                Update(currentPage, DataGrid.RowCount);
                Page.Text = currentPage.ToString();
            }
        }

        private void Last_Click(object sender, EventArgs e)
        {
            Clear();
            currentPage = Convert.ToInt32(LastPage.Text);
            Update(currentPage, DataGrid.RowCount);
            Page.Text = currentPage.ToString();
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (CheckInt(Page.Text))
                {
                    if (Convert.ToInt32(Page.Text) >= 1 && Convert.ToInt32(Page.Text) <= Convert.ToInt32(LastPage.Text))
                    {
                        Clear();
                        currentPage = Convert.ToInt32(Page.Text);
                        Update(currentPage, DataGrid.RowCount);
                    }
                    else
                    {
                        MessageBox.Show("Введено неверное число");
                        Page.Text = currentPage.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Введено неверное число");
                    Page.Text = currentPage.ToString();
                }
            }
        }

        private bool CheckInt(string number)
        {
            try
            {
                Convert.ToInt32(number);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            JournalPrintSettings print = new JournalPrintSettings();
            print.Owner = this;
            print.ShowDialog();
        }
    }
}
