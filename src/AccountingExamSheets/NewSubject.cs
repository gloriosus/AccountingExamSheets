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
    public partial class NewSubject : Form
    {
        public NewSubject()
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
            if (Subject.Text.Trim() != "")
            {
                if (!IsEdit)
                {
                    db.ActionQuery("INSERT INTO subject (title) VALUES ('" + Subject.Text + "')");
                }
                else
                {
                    db.ActionQuery("UPDATE subject SET title='" + Subject.Text + "' WHERE id=" + EditId);
                    IsEdit = false;
                }

                Subjects sub = this.Owner as Subjects;
                if (sub != null)
                {
                    sub.IsUpdate = true;
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Введите название предмета");
            }
        }

        private void NewSubject_FormClosed(object sender, FormClosedEventArgs e)
        {
            Subject.Clear();
        }
    }
}
