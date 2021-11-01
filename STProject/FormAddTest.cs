using STProject.Classes;
using STProject.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STProject
{
    public partial class FormAddTest : Form
    {
        DropDownValues vvalues = new DropDownValues();
        List<string> dropValyes = new List<string>();
        public FormAddTest()
        {
            InitializeComponent();
            vvalues.getSubjects(dropValyes);
            foreach (string value in dropValyes)
            {
                comboBoxSubjects.Items.Add(value);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormMainPageTeacher formUser = new FormMainPageTeacher();
            this.Hide();
            formUser.ShowDialog();
            this.Close();
        }

        private void buttonAddTest_Click(object sender, EventArgs e)
        {
            if (textBoxQuestion.Text!="" && textBoxA.Text != "" && textBoxB.Text != "" && textBoxG.Text != "" &&
                textBoxTrue.Text != "" && textBoxV.Text != "" && comboBoxSubjects.SelectedItem !=null)
            {
                //TODO check if exist
                Questions qu = new Questions(textBoxQuestion.Text,textBoxA.Text, textBoxB.Text, textBoxV.Text,
                    textBoxG.Text, textBoxTrue.Text, comboBoxSubjects.SelectedItem.ToString());
                qu.setAnswer(qu);
                if (qu.checkValidQuestion(qu))
                {
                    try
                    {
                        //TODO check why cant make records in db
                        qu.InsertQuestion(qu);
                        MessageBox.Show("Въпросът беше записан успешно");
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Заявката не беше изпълнена поради следната грешка: " + exc.Message);
                    }
                    finally
                    {
                        textBoxQuestion.Text = string.Empty;
                        textBoxA.Text = string.Empty;
                        textBoxB.Text = string.Empty;
                        textBoxG.Text = string.Empty;
                        textBoxTrue.Text = string.Empty;
                        textBoxV.Text = string.Empty;
                        comboBoxSubjects.SelectedIndex = -1;
                    }
                }
                else
                    MessageBox.Show("Въпросът не е валиден, моля задайте въпрос с 4 отговора, от който 1 е верен");
            }
            else
                MessageBox.Show("Моля попълнете всички празни полета");
        }

        private void FormAddTest_Load(object sender, EventArgs e)
        {

        }
    }
}
