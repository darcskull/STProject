
namespace STProject
{
    partial class FormReviewTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGivenAnswer = new System.Windows.Forms.TextBox();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxSubject = new System.Windows.Forms.ComboBox();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxQuestionNumber = new System.Windows.Forms.TextBox();
            this.textBoxGrade = new System.Windows.Forms.TextBox();
            this.textBoxPoints = new System.Windows.Forms.TextBox();
            this.textBoxCorrect = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Въпрос";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Location = new System.Drawing.Point(146, 214);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(319, 20);
            this.textBoxAnswer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Верен отговор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Даден отговор";
            // 
            // textBoxGivenAnswer
            // 
            this.textBoxGivenAnswer.Enabled = false;
            this.textBoxGivenAnswer.Location = new System.Drawing.Point(146, 262);
            this.textBoxGivenAnswer.Name = "textBoxGivenAnswer";
            this.textBoxGivenAnswer.Size = new System.Drawing.Size(319, 20);
            this.textBoxGivenAnswer.TabIndex = 9;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(390, 316);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Следващ";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(146, 316);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 11;
            this.buttonPrevious.Text = "Предишен";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(659, 149);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 12;
            this.buttonGenerate.Text = "Генериране";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Предмет";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(659, 86);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubject.TabIndex = 14;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Location = new System.Drawing.Point(146, 77);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(319, 106);
            this.textBoxQuestion.TabIndex = 15;
            // 
            // textBoxQuestionNumber
            // 
            this.textBoxQuestionNumber.Enabled = false;
            this.textBoxQuestionNumber.Location = new System.Drawing.Point(115, 77);
            this.textBoxQuestionNumber.Name = "textBoxQuestionNumber";
            this.textBoxQuestionNumber.Size = new System.Drawing.Size(25, 20);
            this.textBoxQuestionNumber.TabIndex = 16;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.Enabled = false;
            this.textBoxGrade.Location = new System.Drawing.Point(659, 297);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(91, 20);
            this.textBoxGrade.TabIndex = 17;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.Enabled = false;
            this.textBoxPoints.Location = new System.Drawing.Point(659, 246);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(91, 20);
            this.textBoxPoints.TabIndex = 18;
            // 
            // textBoxCorrect
            // 
            this.textBoxCorrect.Enabled = false;
            this.textBoxCorrect.Location = new System.Drawing.Point(490, 77);
            this.textBoxCorrect.Name = "textBoxCorrect";
            this.textBoxCorrect.Size = new System.Drawing.Size(91, 20);
            this.textBoxCorrect.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Брой точки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(656, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Оценка";
            // 
            // FormReviewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCorrect);
            this.Controls.Add(this.textBoxPoints);
            this.Controls.Add(this.textBoxGrade);
            this.Controls.Add(this.textBoxQuestionNumber);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.comboBoxSubject);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textBoxGivenAnswer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormReviewTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преглед на теста";
            this.Load += new System.EventHandler(this.FormReviewTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxGivenAnswer;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxSubject;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxQuestionNumber;
        private System.Windows.Forms.TextBox textBoxGrade;
        private System.Windows.Forms.TextBox textBoxPoints;
        private System.Windows.Forms.TextBox textBoxCorrect;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}