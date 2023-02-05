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
    public partial class Examinators : Form
    {
        public Examinators()
        {
            InitializeComponent();
        }

        DBConnection db = new DBConnection();

        private bool isUpdate = false;
        public bool IsUpdate
        {
            get
            {
                return isUpdate;
            }

            set
            {
                isUpdate = value;
            }
        }

        private void Examinators_Load(object sender, EventArgs e)
        {
            ListExaminators.Items.Clear();
            ListExaminators.Items.AddRange(db.Query("SELECT family, init FROM examinator ORDER BY family", 0, 1).ToArray());
            Accept.Enabled = false;
            Change.Enabled = false;
            Delete.Enabled = false;
        }

        private void ListExaminators_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListExaminators.SelectedIndex != -1)
            {
                Accept.Enabled = true;
                Change.Enabled = true;
                Delete.Enabled = true;
            }
        }

        private void Accept_Click(object sender, EventArgs e)
        {
            NewNote newNote = this.Owner as NewNote;
            if (newNote != null)
            {
                string[] name = ListExaminators.SelectedItem.ToString().Split(' ');
                int id = Convert.ToInt32(db.Query("SELECT id FROM examinator WHERE family='" + name[0] + "' AND init='" + name[1] + "'")[0]);

                newNote.IDExaminator = id;

                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Examinators_Activated(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                ListExaminators.Items.Clear();
                ListExaminators.Items.AddRange(db.Query("SELECT family, init FROM examinator ORDER BY family", 0, 1).ToArray());
                Accept.Enabled = false;
                Change.Enabled = false;
                Delete.Enabled = false;
                IsUpdate = false;
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            ListExaminators.Items.Clear();

            if (Search.Text != "")
            {
                ListExaminators.Items.AddRange(db.Query("SELECT family, init FROM examinator WHERE family LIKE '" + Search.Text + "%'", 0, 1).ToArray());
            }
            else
            {
                ListExaminators.Items.AddRange(db.Query("SELECT family, init FROM examinator ORDER BY family", 0, 1).ToArray());
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NewExaminator newExam = new NewExaminator();
            newExam.Owner = this;
            newExam.ShowDialog();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (ListExaminators.SelectedIndex != -1)
            {
                NewExaminator newExam = new NewExaminator();
                newExam.Owner = this;

                newExam.Family.Text = ListExaminators.SelectedItem.ToString();
                string[] name = ListExaminators.SelectedItem.ToString().Split(' ');
                newExam.Rank.Text = db.Query("SELECT rank FROM examinator WHERE family='" + name[0] + "' AND init='" + name[1] + "'")[0];
                newExam.EditId = Convert.ToInt32(db.Query("SELECT id FROM examinator WHERE family='" + name[0] + "' AND init='" + name[1] + "'")[0]);
                newExam.IsEdit = true;

                newExam.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ListExaminators.SelectedIndex != -1)
            {
                string[] name = ListExaminators.SelectedItem.ToString().Split(' ');
                int id = Convert.ToInt32(db.Query("SELECT id FROM examinator WHERE family='" + name[0] + "' AND init='" + name[1] + "'")[0]);
                db.ActionQuery("DELETE FROM sheet WHERE idExaminator=" + id);
                db.ActionQuery("DELETE FROM examinator WHERE id=" + id);
                ListExaminators.Items.Clear();
                ListExaminators.Items.AddRange(db.Query("SELECT family, init FROM examinator ORDER BY family", 0, 1).ToArray());
                Accept.Enabled = false;
                Change.Enabled = false;
                Delete.Enabled = false;
            }
        }
    }
}
