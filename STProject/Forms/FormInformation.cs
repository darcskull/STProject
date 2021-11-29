using STProject.Classes;
using STProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STProject
{
    public partial class FormInformation : Form
    {
        User user;
        bool checkStudent;
        private StringBuilder sb;
        public FormInformation(User u, bool isStudent)
        {
            InitializeComponent();
            user = u;
            checkStudent = isStudent;
            if (isStudent)
            {
                var teacher = new Teacher();
                var listOfTeachers = teacher.TeachersCollection();
                int locationChange = 10;
                sb = new StringBuilder();
                foreach (var item in listOfTeachers.OrderBy(n => n.FirstName).ThenBy(l => l.LastName))
                {
                    var txtBox = new TextBox
                    {

                        Multiline = true,
                        Size = new Size(400, 50),
                        Location = new Point(10, locationChange),
                        Text = $"Name: {item.FirstName}  {item.LastName}  Email: {item.Email} {Environment.NewLine}Телефон: {item.PhoneNumber} Факултет: {item.Departament}",
                        Enabled = false,
                    };
                    sb.AppendLine(txtBox.Text);
                    txtBox.Font = new Font(txtBox.Font.FontFamily, 13);
                    panel1.Controls.Add(txtBox);
                    locationChange += 60;

                }

            }
            else
            {
                var student = new Student();
                var listOfStudents = student.StudentsCollection();
                int locationChange = 10;
                sb = new StringBuilder();
                foreach (var item in listOfStudents)
                {
                    var txtBox = new TextBox
                    {

                        Multiline = true,
                        Size = new Size(400, 75),
                        Location = new Point(10, locationChange),
                        Text = $"Name: {item.FirstName}  {item.LastName}  Email: {item.Email} {Environment.NewLine}Телефон: {item.PhoneNumber} Факултет: {item.Departament}" +
                        $"{Environment.NewLine}Среден Усхех: {item.Evaluation} фак. Номер: {item.FacultyNumber}",
                        Enabled = false,
                    };
                    txtBox.Font = new Font(txtBox.Font.FontFamily, 13);
                    panel1.Controls.Add(txtBox);
                    sb.AppendLine(txtBox.Text.ToString().TrimEnd()) ;
                    locationChange += 85;

                }

            }
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (checkStudent)
            {
                FormMainPageStudent formStudent = new FormMainPageStudent((Student)user);
                this.Hide();
                formStudent.ShowDialog();
                this.Close();
            }
            else
            {
                FormMainPageTeacher formTeacher = new FormMainPageTeacher((Teacher)user);
                this.Hide();
                formTeacher.ShowDialog();
                this.Close();
            }
        }
        private void FormInformation_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string path = Path.GetFullPath(saveFileDialog.FileName);
                if (!File.Exists(path))
                {
                    var s = sb.ToString().TrimEnd();
                    File.WriteAllText(path, sb.ToString().TrimEnd() );
                }
            }

        }
    }
}
