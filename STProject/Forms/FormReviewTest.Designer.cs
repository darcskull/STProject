
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
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonBack.Location = new System.Drawing.Point(4, 380);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 32);
            this.buttonBack.TabIndex = 3;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Въпрос";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxAnswer.Enabled = false;
            this.textBoxAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnswer.Location = new System.Drawing.Point(58, 218);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAnswer.Multiline = true;
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(424, 36);
            this.textBoxAnswer.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Верен отговор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Даден отговор";
            // 
            // textBoxGivenAnswer
            // 
            this.textBoxGivenAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxGivenAnswer.Enabled = false;
            this.textBoxGivenAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGivenAnswer.Location = new System.Drawing.Point(57, 283);
            this.textBoxGivenAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGivenAnswer.Multiline = true;
            this.textBoxGivenAnswer.Name = "textBoxGivenAnswer";
            this.textBoxGivenAnswer.Size = new System.Drawing.Size(424, 36);
            this.textBoxGivenAnswer.TabIndex = 9;
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonNext.Location = new System.Drawing.Point(399, 327);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(100, 36);
            this.buttonNext.TabIndex = 10;
            this.buttonNext.Text = "Следващ";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonPrevious.Location = new System.Drawing.Point(4, 335);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(100, 37);
            this.buttonPrevious.TabIndex = 11;
            this.buttonPrevious.Text = "Предишен";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonGenerate.Location = new System.Drawing.Point(653, 127);
            this.buttonGenerate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(100, 36);
            this.buttonGenerate.TabIndex = 12;
            this.buttonGenerate.Text = "Генериране";
            this.buttonGenerate.UseVisualStyleBackColor = false;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Предмет";
            // 
            // comboBoxSubject
            // 
            this.comboBoxSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubject.FormattingEnabled = true;
            this.comboBoxSubject.Location = new System.Drawing.Point(653, 83);
            this.comboBoxSubject.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxSubject.Name = "comboBoxSubject";
            this.comboBoxSubject.Size = new System.Drawing.Size(160, 24);
            this.comboBoxSubject.TabIndex = 14;
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQuestion.Location = new System.Drawing.Point(58, 50);
            this.textBoxQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(424, 130);
            this.textBoxQuestion.TabIndex = 15;
            // 
            // textBoxQuestionNumber
            // 
            this.textBoxQuestionNumber.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxQuestionNumber.Enabled = false;
            this.textBoxQuestionNumber.Location = new System.Drawing.Point(16, 50);
            this.textBoxQuestionNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxQuestionNumber.Name = "textBoxQuestionNumber";
            this.textBoxQuestionNumber.Size = new System.Drawing.Size(32, 22);
            this.textBoxQuestionNumber.TabIndex = 16;
            // 
            // textBoxGrade
            // 
            this.textBoxGrade.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxGrade.Enabled = false;
            this.textBoxGrade.Location = new System.Drawing.Point(653, 258);
            this.textBoxGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGrade.Name = "textBoxGrade";
            this.textBoxGrade.Size = new System.Drawing.Size(120, 22);
            this.textBoxGrade.TabIndex = 17;
            // 
            // textBoxPoints
            // 
            this.textBoxPoints.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxPoints.Enabled = false;
            this.textBoxPoints.Location = new System.Drawing.Point(653, 195);
            this.textBoxPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPoints.Name = "textBoxPoints";
            this.textBoxPoints.Size = new System.Drawing.Size(120, 22);
            this.textBoxPoints.TabIndex = 18;
            // 
            // textBoxCorrect
            // 
            this.textBoxCorrect.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxCorrect.Enabled = false;
            this.textBoxCorrect.Location = new System.Drawing.Point(514, 83);
            this.textBoxCorrect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCorrect.Name = "textBoxCorrect";
            this.textBoxCorrect.Size = new System.Drawing.Size(120, 22);
            this.textBoxCorrect.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(649, 175);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Брой точки";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "Оценка";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "№";
            // 
            // FormReviewTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(833, 424);
            this.Controls.Add(this.label7);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label7;
    }
}