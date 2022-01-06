
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
            this.components = new System.ComponentModel.Container();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Въпрос";
            // 
            // textBoxAnswerA
            // 
            this.textBoxAnswerA.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnswerA.Enabled = false;
            this.textBoxAnswerA.Location = new System.Drawing.Point(69, 171);
            this.textBoxAnswerA.Multiline = true;
            this.textBoxAnswerA.Name = "textBoxAnswerA";
            this.textBoxAnswerA.Size = new System.Drawing.Size(364, 29);
            this.textBoxAnswerA.TabIndex = 8;
            // 
            // textBoxAnswerB
            // 
            this.textBoxAnswerB.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnswerB.Enabled = false;
            this.textBoxAnswerB.Location = new System.Drawing.Point(69, 214);
            this.textBoxAnswerB.Multiline = true;
            this.textBoxAnswerB.Name = "textBoxAnswerB";
            this.textBoxAnswerB.Size = new System.Drawing.Size(364, 29);
            this.textBoxAnswerB.TabIndex = 13;
            // 
            // textBoxAnswerV
            // 
            this.textBoxAnswerV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnswerV.Enabled = false;
            this.textBoxAnswerV.Location = new System.Drawing.Point(69, 254);
            this.textBoxAnswerV.Multiline = true;
            this.textBoxAnswerV.Name = "textBoxAnswerV";
            this.textBoxAnswerV.Size = new System.Drawing.Size(364, 28);
            this.textBoxAnswerV.TabIndex = 14;
            // 
            // textBoxAnswearG
            // 
            this.textBoxAnswearG.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxAnswearG.Enabled = false;
            this.textBoxAnswearG.Location = new System.Drawing.Point(69, 297);
            this.textBoxAnswearG.Multiline = true;
            this.textBoxAnswearG.Name = "textBoxAnswearG";
            this.textBoxAnswearG.Size = new System.Drawing.Size(364, 28);
            this.textBoxAnswearG.TabIndex = 15;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Location = new System.Drawing.Point(32, 177);
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
            this.radioButtonB.Location = new System.Drawing.Point(32, 214);
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
            this.radioButtonV.Location = new System.Drawing.Point(32, 254);
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
            this.radioButtonG.Location = new System.Drawing.Point(32, 297);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(31, 17);
            this.radioButtonG.TabIndex = 19;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "Г";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonPrevious.Location = new System.Drawing.Point(18, 353);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 35);
            this.buttonPrevious.TabIndex = 20;
            this.buttonPrevious.Text = "Предишен";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonNext.Location = new System.Drawing.Point(357, 340);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 35);
            this.buttonNext.TabIndex = 21;
            this.buttonNext.Text = "Следващ";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonEndTest
            // 
            this.buttonEndTest.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonEndTest.Location = new System.Drawing.Point(448, 72);
            this.buttonEndTest.Name = "buttonEndTest";
            this.buttonEndTest.Size = new System.Drawing.Size(150, 35);
            this.buttonEndTest.TabIndex = 23;
            this.buttonEndTest.Text = "Предаване на теста";
            this.buttonEndTest.UseVisualStyleBackColor = false;
            this.buttonEndTest.Click += new System.EventHandler(this.buttonEndTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(481, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Време";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Оставащо Време: ";
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxQuestion.Enabled = false;
            this.textBoxQuestion.Location = new System.Drawing.Point(69, 34);
            this.textBoxQuestion.Multiline = true;
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(364, 109);
            this.textBoxQuestion.TabIndex = 26;
            // 
            // textBoxNumberQuestion
            // 
            this.textBoxNumberQuestion.BackColor = System.Drawing.Color.RosyBrown;
            this.textBoxNumberQuestion.Enabled = false;
            this.textBoxNumberQuestion.Location = new System.Drawing.Point(32, 34);
            this.textBoxNumberQuestion.Name = "textBoxNumberQuestion";
            this.textBoxNumberQuestion.Size = new System.Drawing.Size(27, 20);
            this.textBoxNumberQuestion.TabIndex = 27;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "№";
            // 
            // FormActiveTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 404);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormActiveTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тест";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormActiveTest_FormClosed);
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
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}