using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccountingExamSheets
{
    public partial class Elements : Form
    {
        public Elements()
        {
            InitializeComponent();
        }

        DBConnection db = new DBConnection();
        IniEditor ini = new IniEditor();

        private string iniPath = Application.StartupPath + @"\settings.ini";

        private void Elements_Load(object sender, EventArgs e)
        {
            FacultyCombo.Items.AddRange(db.Query("SELECT title FROM faculty").ToArray());

            string item = ini.GetValue(iniPath, "[Default]", "faculty");
            if (item != "")
            {
                FacultyCombo.Text = item;
            }

            item = ini.GetValue(iniPath, "[Default]", "listformat");
            if (item != "")
            {
                FormatCombo.Text = item;
            }

            item = ini.GetValue(iniPath, "[Default]", "orientation");
            if (item != "")
            {
                Orientation.Text = item;
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (FacultyCombo.Items.Contains(FacultyCombo.Text))
            {
                ini.InsertParametr(iniPath, "[Default]", "faculty", FacultyCombo.Text);
            }
            else
            {
                MessageBox.Show("Выберите значение из списка");
            }

            if (FormatCombo.Items.Contains(FormatCombo.Text))
            {
                ini.InsertParametr(iniPath, "[Default]", "listformat", FormatCombo.Text);
            }
            else
            {
                MessageBox.Show("Выберите значение из списка");
            }

            if (Orientation.Items.Contains(Orientation.Text))
            {
                ini.InsertParametr(iniPath, "[Default]", "orientation", Orientation.Text);
            }
            else
            {
                MessageBox.Show("Выберите значение из списка");
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Elements_FormClosed(object sender, FormClosedEventArgs e)
        {
            FacultyCombo.Items.Clear();
            FormatCombo.Items.Clear();
            Orientation.Items.Clear();
        }
    }
}
