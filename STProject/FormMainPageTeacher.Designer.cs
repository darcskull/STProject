
namespace STProject
{
    partial class FormMainPageTeacher
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
            this.buttonAddTest = new System.Windows.Forms.Button();
            this.buttonAddNews = new System.Windows.Forms.Button();
            this.buttonAddMaterials = new System.Windows.Forms.Button();
            this.buttonMaterials = new System.Windows.Forms.Button();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(605, 259);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(183, 23);
            this.buttonAddTest.TabIndex = 0;
            this.buttonAddTest.Text = "Добавяне на тестови въпрос";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonAddNews
            // 
            this.buttonAddNews.Location = new System.Drawing.Point(605, 176);
            this.buttonAddNews.Name = "buttonAddNews";
            this.buttonAddNews.Size = new System.Drawing.Size(183, 23);
            this.buttonAddNews.TabIndex = 1;
            this.buttonAddNews.Text = "Добавяне на новини";
            this.buttonAddNews.UseVisualStyleBackColor = true;
            this.buttonAddNews.Click += new System.EventHandler(this.buttonAddNews_Click);
            // 
            // buttonAddMaterials
            // 
            this.buttonAddMaterials.Location = new System.Drawing.Point(605, 100);
            this.buttonAddMaterials.Name = "buttonAddMaterials";
            this.buttonAddMaterials.Size = new System.Drawing.Size(183, 23);
            this.buttonAddMaterials.TabIndex = 2;
            this.buttonAddMaterials.Text = "Създаване на материали";
            this.buttonAddMaterials.UseVisualStyleBackColor = true;
            this.buttonAddMaterials.Click += new System.EventHandler(this.buttonAddMaterials_Click);
            // 
            // buttonMaterials
            // 
            this.buttonMaterials.Location = new System.Drawing.Point(605, 26);
            this.buttonMaterials.Name = "buttonMaterials";
            this.buttonMaterials.Size = new System.Drawing.Size(183, 23);
            this.buttonMaterials.TabIndex = 3;
            this.buttonMaterials.Text = "Материали";
            this.buttonMaterials.UseVisualStyleBackColor = true;
            this.buttonMaterials.Click += new System.EventHandler(this.buttonMaterials_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1, 12);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(154, 23);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Излизане от профила";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Location = new System.Drawing.Point(605, 343);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(183, 23);
            this.buttonInformation.TabIndex = 5;
            this.buttonInformation.Text = "Списък със студенти";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Новини";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TODO";
            // 
            // FormMainPageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonMaterials);
            this.Controls.Add(this.buttonAddMaterials);
            this.Controls.Add(this.buttonAddNews);
            this.Controls.Add(this.buttonAddTest);
            this.Name = "FormMainPageTeacher";
            this.Text = "Начало";
            this.Load += new System.EventHandler(this.FormMainPageTeacher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonAddNews;
        private System.Windows.Forms.Button buttonAddMaterials;
        private System.Windows.Forms.Button buttonMaterials;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}