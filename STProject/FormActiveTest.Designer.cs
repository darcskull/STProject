﻿
namespace STProject
{
    partial class FormActiveTest
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAnswerA = new System.Windows.Forms.TextBox();
            this.textBoxAnswerB = new System.Windows.Forms.TextBox();
            this.textBoxAnswerV = new System.Windows.Forms.TextBox();
            this.textBoxAnswearG = new System.Windows.Forms.TextBox();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonV = new System.Windows.Forms.RadioButton();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonEndTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxNumberQuestion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Въпрос";
            // 
            // textBoxAnswerA
            // 
            this.textBoxAnswerA.Location = new System.Drawing.Point(136, 235);
            this.textBoxAnswerA.Name = "textBoxAnswerA";
            this.textBoxAnswerA.Size = new System.Drawing.Size(364, 20);
            this.textBoxAnswerA.TabIndex = 8;
            // 
            // textBoxAnswerB
            // 
            this.textBoxAnswerB.Location = new System.Drawing.Point(136, 272);
            this.textBoxAnswerB.Name = "textBoxAnswerB";
            this.textBoxAnswerB.Size = new System.Drawing.Size(364, 20);
            this.textBoxAnswerB.TabIndex = 13;
            // 
            // textBoxAnswerV
            // 
            this.textBoxAnswerV.Location = new System.Drawing.Point(136, 309);
            this.textBoxAnswerV.Name = "textBoxAnswerV";
            this.textBoxAnswerV.Size = new System.Drawing.Size(364, 20);
            this.textBoxAnswerV.TabIndex = 14;
            // 
            // textBoxAnswearG
            // 
            this.textBoxAnswearG.Location = new System.Drawing.Point(136, 352);
            this.textBoxAnswearG.Name = "textBoxAnswearG";
            this.textBoxAnswearG.Size = new System.Drawing.Size(364, 20);
            this.textBoxAnswearG.TabIndex = 15;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(98, 235);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(32, 17);
            this.radioButtonA.TabIndex = 16;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Location = new System.Drawing.Point(98, 272);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(32, 17);
            this.radioButtonB.TabIndex = 17;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "Б";
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonV
            // 
            this.radioButtonV.AutoSize = true;
            this.radioButtonV.Location = new System.Drawing.Point(98, 312);
            this.radioButtonV.Name = "radioButtonV";
            this.radioButtonV.Size = new System.Drawing.Size(32, 17);
            this.radioButtonV.TabIndex = 18;
            this.radioButtonV.TabStop = true;
            this.radioButtonV.Text = "В";
            this.radioButtonV.UseVisualStyleBackColor = true;
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(99, 355);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(31, 17);
            this.radioButtonG.TabIndex = 19;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "Г";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(136, 389);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 20;
            this.buttonPrevious.Text = "Предишен";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(416, 389);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "Следващ";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonEndTest
            // 
            this.buttonEndTest.Location = new System.Drawing.Point(583, 389);
            this.buttonEndTest.Name = "buttonEndTest";
            this.buttonEndTest.Size = new System.Drawing.Size(150, 23);
            this.buttonEndTest.TabIndex = 23;
            this.buttonEndTest.Text = "Предаване на теста";
            this.buttonEndTest.UseVisualStyleBackColor = true;
            this.buttonEndTest.Click += new System.EventHandler(this.buttonEndTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(618, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Време";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "TODO";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(136, 92);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(364, 109);
            this.textBoxQuestion.TabIndex = 26;
            // 
            // textBoxNumberQuestion
            // 
            this.textBoxNumberQuestion.Location = new System.Drawing.Point(98, 92);
            this.textBoxNumberQuestion.Name = "textBoxNumberQuestion";
            this.textBoxNumberQuestion.Size = new System.Drawing.Size(27, 20);
            this.textBoxNumberQuestion.TabIndex = 27;
            // 
            // FormActiveTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxNumberQuestion);
            this.Controls.Add(this.textBoxQuestion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEndTest);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.radioButtonG);
            this.Controls.Add(this.radioButtonV);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.textBoxAnswearG);
            this.Controls.Add(this.textBoxAnswerV);
            this.Controls.Add(this.textBoxAnswerB);
            this.Controls.Add(this.textBoxAnswerA);
            this.Controls.Add(this.label1);
            this.Name = "FormActiveTest";
            this.Text = "Тест";
            this.Load += new System.EventHandler(this.FormActiveTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAnswerA;
        private System.Windows.Forms.TextBox textBoxAnswerB;
        private System.Windows.Forms.TextBox textBoxAnswerV;
        private System.Windows.Forms.TextBox textBoxAnswearG;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonV;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonEndTest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxNumberQuestion;
    }
}