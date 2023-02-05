using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AccountingExamSheets
{
    public partial class NewNote : Form
    {
        public NewNote()
        {
            InitializeComponent();
        }

        //Расчет номера экзаменационного листа
        private void NewNote_Load(object sender, EventArgs e)
        {
            string[] sheets = db.Query("SELECT number FROM sheet").ToArray();

            if (sheets.Length != 0)
            {
                Count.Text = (Convert.ToInt32(sheets[sheets.Length - 1]) + 1).ToString();
            }
            else
            {
                Count.Text = "1";
            }

            KindValid.Items.AddRange(db.Query("SELECT kind FROM validation").ToArray());
        }

        //Инициализация соединения с базой данных и новых дочерних форм
        DBConnection db = new DBConnection();
        Students stud = new Students();
        Subjects sub = new Subjects();
        Examinators exam = new Examinators();
        Parser parser = new Parser();


        //Инициализация публичных свойств для ID-номеров
        private int idStudent = -1;
        private int PreIdStudent = -1;
        public int IDStudent
        {
            get
            {
                return idStudent;
            }

            set
            {
                idStudent = value;
            }
        }

        private int idSubject = -1;
        private int PreIdSubject = -1;
        public int IDSubject
        {
            get
            {
                return idSubject;
            }

            set
            {
                idSubject = value;
            }
        }

        private int idExaminator = -1;
        private int PreIdExaminator = -1;
        public int IDExaminator
        {
            get
            {
                return idExaminator;
            }

            set
            {
                idExaminator = value;
            }
        }

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

        private int comboIndex = -1;
        public int ComboIndex
        {
            get
            {
                return comboIndex;
            }

            set
            {
                comboIndex = value;
            }
        }

        private bool isUpdate = false;

        private bool isFresh = false;
        public bool IsFresh
        {
            get
            {
                return isFresh;
            }

            set
            {
                isFresh = value;
            }
        }



        //Открытие дочерних форм
        private void SelectStudent_Click(object sender, EventArgs e)
        {
            stud.Owner = this;
            stud.ShowDialog();
        }

        private void SelectSubject_Click(object sender, EventArgs e)
        {
            sub.Owner = this;
            sub.ShowDialog();
        }

        private void SelectExaminator_Click(object sender, EventArgs e)
        {
            exam.Owner = this;
            exam.ShowDialog();
        }

        //Обработка выбора значений из дочерних форм и изменение состояния компонентов данной формы
        private void NewNote_Activated(object sender, EventArgs e)
        {
            if (IsEdit)
            {
                string[] ides = db.Query("SELECT number, idExaminator, idSubject, idStudent, idHour, idValid FROM sheet WHERE id=" + EditId, 0, 5)[0].Split(' ');
                Count.Text = ides[0];
                IDExaminator = Convert.ToInt32(ides[1]);
                IDSubject = Convert.ToInt32(ides[2]);
                IDStudent = Convert.ToInt32(ides[3]);
                Hours.Text = db.Query("SELECT `count` FROM `hour` WHERE id=" + ides[4])[0];
                KindValid.Text = db.Query("SELECT kind FROM validation WHERE id=" + ides[5])[0];

                isUpdate = true;
                IsEdit = false;
            }

            if (IDStudent != PreIdStudent)
            {
                string[] parts = db.Query("SELECT family, `name`, otchestvo, book, idFaculty, idGroup, idQuater, idCourse FROM student WHERE id=" + IDStudent, 0, 7)[0].Split(' ');
                Student.Text = parts[0] + " " + parts[1][0] + "." + parts[2][0] + ".";
                NumberBook.Text = parts[3];

                Faculty.Text = db.Query("SELECT title FROM faculty WHERE id=" + parts[4])[0];
                Group.Text = db.Query("SELECT number FROM `group` WHERE id=" + parts[5])[0];
                Quater.Text = db.Query("SELECT number FROM quater WHERE id=" + parts[6])[0];
                Course.Text = db.Query("SELECT number FROM course WHERE id=" + parts[7])[0];

                PreIdStudent = IDStudent;
            }

            if (IDSubject != PreIdSubject)
            {
                Subject.Text = db.Query("SELECT title FROM subject WHERE id=" + IDSubject)[0];
                PreIdSubject = IDSubject;
            }

            if (IDExaminator != PreIdExaminator)
            {
                ListExaminators.Items.Add(db.Query("SELECT family, init FROM examinator WHERE id=" + IDExaminator, 0, 1)[0]);
                PreIdExaminator = IDExaminator;
            }

            if (IsFresh)
            {
                KindValid.Items.Clear();
                KindValid.Items.AddRange(db.Query("SELECT kind FROM validation").ToArray());
                IsFresh = false;
            }
        }

        private void GenerateText(string numberList)
        {
            string content = File.ReadAllText(Application.StartupPath + @"\Resources\pattern.txt");

            content = parser.Replace(content, "number", Count.Text);
            content = parser.Replace(content, "subject", Subject.Text);

            string examinator = "";
            for (int i = 0; i < ListExaminators.Items.Count; i++)
            {
                examinator += ListExaminators.Items[i].ToString() + ", ";
            }

            content = parser.Replace(content, "examinator", examinator);
            content = parser.Replace(content, "student", Student.Text);
            content = parser.Replace(content, "book", NumberBook.Text);
            content = parser.Replace(content, "faculty", Faculty.Text);
            content = parser.Replace(content, "course", Course.Text);
            content = parser.Replace(content, "quater", Quater.Text);
            content = parser.Replace(content, "group", Group.Text);
            content = parser.Replace(content, "hours", Hours.Text);
            content = parser.Replace(content, "kindvalid", KindValid.Text);

            File.WriteAllText(Application.StartupPath + @"\Temp\list" + numberList + ".txt", content);
        }

        private bool IsNumber(string number)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsNumber(Count.Text) && Subject.Text != "" && ListExaminators.Items.Count != 0 && Student.Text != "" && KindValid.Text != "" && Hours.Text != "")
            {
                string idHour = "";

                if (db.Query("SELECT `count` FROM `hour`").Contains(Hours.Text))
                {
                    idHour = db.Query("SELECT id FROM `hour` WHERE `count`='" + Hours.Text + "'")[0];
                }
                else
                {
                    idHour = db.ActionQuery("INSERT INTO `hour` (`count`) VALUES ('" + Hours.Text + "')").ToString();
                }

                string idValid = db.Query("SELECT id FROM validation WHERE kind='" + KindValid.Text + "'")[0];

                int idSheet = -1;
                if (!isUpdate)
                {
                    idSheet = db.ActionQuery("INSERT INTO sheet (`number`, idExaminator, idSubject, idStudent, idHour, idValid, dateOut) VALUES (" + Count.Text + ", " + IDExaminator + ", " + IDSubject + ", " + IDStudent + ", " + idHour + ", " + idValid + ", '" + DateTime.Today.ToShortDateString() + "')");
                }
                else
                {
                    db.ActionQuery("UPDATE sheet SET `number`=" + Count.Text + ", idExaminator=" + IDExaminator + ", idSubject=" + IDSubject + ", idStudent=" + IDStudent + ", idHour=" + idHour + ", idValid=" + idValid + ", dateOut='" + DateTime.Today.ToShortDateString() + "' WHERE id=" + EditId);
                }

                Main main = this.Owner as Main;
                if (main != null)
                {
                    if (!isUpdate)
                    {
                        if (main.Counter != 4)
                        {
                            main.IsShown = true;
                            main.Counter++;
                            main.IdSheets[main.Counter - 1] = idSheet;
                            GenerateText(main.Counter.ToString());
                        }
                    }
                    else
                    {
                        main.WasEdited = true;
                        GenerateText((ComboIndex + 1).ToString());
                        isUpdate = false;
                    }

                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста заполните все поля!");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewNote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Subject.Clear();
            ListExaminators.Items.Clear();
            Student.Clear();
            NumberBook.Clear();
            Faculty.Clear();
            Course.Clear();
            Hours.Clear();
            Quater.Clear();
            Group.Clear();
            KindValid.Items.Clear();

            IDStudent = -1;
            PreIdStudent = -1;
            IDSubject = -1;
            PreIdSubject = -1;
            IDExaminator = -1;
            PreIdExaminator = -1;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ListExaminators.SelectedIndex != -1)
            {
                ListExaminators.Items.RemoveAt(ListExaminators.SelectedIndex);
            }
        }

        private void ShowLists_Click(object sender, EventArgs e)
        {
            Lists lists = new Lists();
            lists.Owner = this;
            lists.ShowDialog();
        }
    }
}
