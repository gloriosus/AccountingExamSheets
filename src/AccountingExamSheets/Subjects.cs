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
    public partial class Subjects : Form
    {
        public Subjects()
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

        private void Subjects_Load(object sender, EventArgs e)
        {
            ListSubjects.Items.Clear();
            ListSubjects.Items.AddRange(db.Query("SELECT title FROM subject ORDER BY title").ToArray());
            Accept.Enabled = false;
            Change.Enabled = false;
            Delete.Enabled = false;
        }

        private void ListSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListSubjects.SelectedIndex != -1)
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
                newNote.IDSubject = Convert.ToInt32(db.Query("SELECT id FROM subject WHERE title='" + ListSubjects.SelectedItem + "'")[0]);
                this.Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Subjects_Activated(object sender, EventArgs e)
        {
            if (IsUpdate)
            {
                ListSubjects.Items.Clear();
                ListSubjects.Items.AddRange(db.Query("SELECT title FROM subject ORDER BY title").ToArray());
                Accept.Enabled = false;
                Change.Enabled = false;
                Delete.Enabled = false;
                IsUpdate = false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            NewSubject newSub = new NewSubject();
            newSub.Owner = this;
            newSub.ShowDialog();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (ListSubjects.SelectedIndex != -1)
            {
                NewSubject newSub = new NewSubject();
                newSub.Owner = this;

                newSub.IsEdit = true;
                newSub.Subject.Text = ListSubjects.SelectedItem.ToString();
                newSub.EditId = Convert.ToInt32(db.Query("SELECT id FROM subject WHERE title='" + ListSubjects.SelectedItem.ToString() + "'")[0]);

                newSub.ShowDialog();
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ListSubjects.SelectedIndex != -1)
            {
                string id = db.Query("SELECT id FROM subject WHERE title='" + ListSubjects.SelectedItem.ToString() + "'")[0];
                db.ActionQuery("DELETE FROM sheet WHERE idSubject=" + id);
                db.ActionQuery("DELETE FROM subject WHERE id=" + id);
                ListSubjects.Items.Clear();
                ListSubjects.Items.AddRange(db.Query("SELECT title FROM subject ORDER BY title").ToArray());
                Accept.Enabled = false;
                Change.Enabled = false;
                Delete.Enabled = false;
            }
        }
    }
}
