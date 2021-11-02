
namespace STProject
{
    partial class FormAddTest
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
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxQuestion = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxG = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxTrue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(16, 511);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(365, 495);
            this.buttonAddTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(240, 28);
            this.buttonAddTest.TabIndex = 2;
            this.buttonAddTest.Text = "Добавяне на въпрос";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Предмет";
            // 
            // listBoxQuestion
            // 
            this.listBoxQuestion.FormattingEnabled = true;
            this.listBoxQuestion.ItemHeight = 16;
            this.listBoxQuestion.Location = new System.Drawing.Point(266, 53);
            this.listBoxQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxQuestion.Name = "listBoxQuestion";
            this.listBoxQuestion.Size = new System.Drawing.Size(531, 116);
            this.listBoxQuestion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Въпрос";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(598, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отговор Б";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(598, 265);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Отговор Г";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 332);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Верен отговор";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 265);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Отговор В";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Отговор А";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(263, 224);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(231, 22);
            this.textBoxA.TabIndex = 11;
            // 
            // textBoxG
            // 
            this.textBoxG.Location = new System.Drawing.Point(602, 285);
            this.textBoxG.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxG.Name = "textBoxG";
            this.textBoxG.Size = new System.Drawing.Size(231, 22);
            this.textBoxG.TabIndex = 12;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(602, 224);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(231, 22);
            this.textBoxB.TabIndex = 13;
            // 
            // textBoxV
            // 
            this.textBoxV.Location = new System.Drawing.Point(263, 285);
            this.textBoxV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.Size = new System.Drawing.Size(231, 22);
            this.textBoxV.TabIndex = 14;
            // 
            // textBoxTrue
            // 
            this.textBoxTrue.Location = new System.Drawing.Point(263, 351);
            this.textBoxTrue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTrue.Name = "textBoxTrue";
            this.textBoxTrue.Size = new System.Drawing.Size(231, 22);
            this.textBoxTrue.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "TODO";
            // 
            // FormAddTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxTrue);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxG);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxQuestion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddTest);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAddTest";
            this.Text = "Добавяне на въпрос";
            this.Load += new System.EventHandler(this.FormAddTest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxQuestion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxG;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxV;
        private System.Windows.Forms.TextBox textBoxTrue;
        private System.Windows.Forms.Label label8;
    }
}