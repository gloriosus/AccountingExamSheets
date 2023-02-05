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
    public partial class NewExaminator : Form
    {
        public NewExaminator()
        {
            InitializeComponent();
        }

        DBConnection db = new DBConnection();

        private bool isEdit = false;
        public bool IsEdit
        {
            get
            {
                return isEdit;
            }

            set
            {
                isEdit = value;
            }
        }

        private int editId = -1;
        public int EditId
        {
            get
            {
                return editId;
            }

            set
            {
                editId = value;
            }
        }




        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            if (Family.Text.Trim() != "")
            {
                string[] names = Family.Text.Split(' ');
                string init = "";

                for (int i = 1; i < names.Length; i++)
                {
                    init += names[i];
                }

                if (!IsEdit)
                {
                    db.ActionQuery("INSERT INTO examinator (rank, family, init) VALUES ('" + Rank.Text + "', '" + names[0] + "', '" + init + "')");
                }
                else
                {
                    db.ActionQuery("UPDATE examinator SET rank='" + Rank.Text + "', family='" + names[0] + "', init='" + init + "' WHERE id=" + EditId);
                    IsEdit = false;
                }

                Examinators exam = this.Owner as Examinators;
                if (exam != null)
                {
                    exam.IsUpdate = true;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Введите фамилию и инициалы экзаменатора");
            }
        }

        private void NewExaminator_FormClosed(object sender, FormClosedEventArgs e)
        {
            Family.Clear();
            Rank.Clear();
        }
    }
}
