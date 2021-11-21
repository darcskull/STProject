
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonAddTest
            // 
            this.buttonAddTest.Location = new System.Drawing.Point(472, 360);
            this.buttonAddTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddTest.Name = "buttonAddTest";
            this.buttonAddTest.Size = new System.Drawing.Size(244, 28);
            this.buttonAddTest.TabIndex = 0;
            this.buttonAddTest.Text = "Добавяне на тестови въпрос";
            this.buttonAddTest.UseVisualStyleBackColor = true;
            this.buttonAddTest.Click += new System.EventHandler(this.buttonAddTest_Click);
            // 
            // buttonAddNews
            // 
            this.buttonAddNews.Location = new System.Drawing.Point(472, 258);
            this.buttonAddNews.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddNews.Name = "buttonAddNews";
            this.buttonAddNews.Size = new System.Drawing.Size(244, 28);
            this.buttonAddNews.TabIndex = 1;
            this.buttonAddNews.Text = "Добавяне на новини";
            this.buttonAddNews.UseVisualStyleBackColor = true;
            this.buttonAddNews.Click += new System.EventHandler(this.buttonAddNews_Click);
            // 
            // buttonAddMaterials
            // 
            this.buttonAddMaterials.Location = new System.Drawing.Point(472, 150);
            this.buttonAddMaterials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAddMaterials.Name = "buttonAddMaterials";
            this.buttonAddMaterials.Size = new System.Drawing.Size(244, 28);
            this.buttonAddMaterials.TabIndex = 2;
            this.buttonAddMaterials.Text = "Създаване на материали";
            this.buttonAddMaterials.UseVisualStyleBackColor = true;
            this.buttonAddMaterials.Click += new System.EventHandler(this.buttonAddMaterials_Click);
            // 
            // buttonMaterials
            // 
            this.buttonMaterials.Location = new System.Drawing.Point(472, 73);
            this.buttonMaterials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMaterials.Name = "buttonMaterials";
            this.buttonMaterials.Size = new System.Drawing.Size(244, 28);
            this.buttonMaterials.TabIndex = 3;
            this.buttonMaterials.Text = "Материали";
            this.buttonMaterials.UseVisualStyleBackColor = true;
            this.buttonMaterials.Click += new System.EventHandler(this.buttonMaterials_Click);
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Location = new System.Drawing.Point(1, 15);
            this.buttonLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(205, 28);
            this.buttonLogOut.TabIndex = 4;
            this.buttonLogOut.Text = "Излизане от профила";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Location = new System.Drawing.Point(472, 463);
            this.buttonInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(244, 28);
            this.buttonInformation.TabIndex = 5;
            this.buttonInformation.Text = "Списък със студенти";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(1, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 454);
            this.panel2.TabIndex = 10;
        
            // 
            // FormMainPageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonLogOut);
            this.Controls.Add(this.buttonMaterials);
            this.Controls.Add(this.buttonAddMaterials);
            this.Controls.Add(this.buttonAddNews);
            this.Controls.Add(this.buttonAddTest);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMainPageTeacher";
            this.Text = "Начало";
            this.Load += new System.EventHandler(this.FormMainPageTeacher_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddTest;
        private System.Windows.Forms.Button buttonAddNews;
        private System.Windows.Forms.Button buttonAddMaterials;
        private System.Windows.Forms.Button buttonMaterials;
        private System.Windows.Forms.Button buttonLogOut;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Panel panel2;
    }
}