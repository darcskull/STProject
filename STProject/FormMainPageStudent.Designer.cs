
namespace STProject
{
    partial class FormMainPageStudent
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
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonInformation = new System.Windows.Forms.Button();
            this.buttonReviewTest = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.buttonMaterials = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 219);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новини";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(4, 15);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(175, 28);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Изход от профил";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonInformation
            // 
            this.buttonInformation.Location = new System.Drawing.Point(808, 329);
            this.buttonInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonInformation.Name = "buttonInformation";
            this.buttonInformation.Size = new System.Drawing.Size(243, 28);
            this.buttonInformation.TabIndex = 3;
            this.buttonInformation.Text = "Списък с преподаватели";
            this.buttonInformation.UseVisualStyleBackColor = true;
            this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
            // 
            // buttonReviewTest
            // 
            this.buttonReviewTest.Location = new System.Drawing.Point(808, 219);
            this.buttonReviewTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonReviewTest.Name = "buttonReviewTest";
            this.buttonReviewTest.Size = new System.Drawing.Size(243, 28);
            this.buttonReviewTest.TabIndex = 4;
            this.buttonReviewTest.Text = "Преглед на тест";
            this.buttonReviewTest.UseVisualStyleBackColor = true;
            this.buttonReviewTest.Click += new System.EventHandler(this.buttonReviewTest_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Location = new System.Drawing.Point(808, 121);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(243, 28);
            this.buttonTest.TabIndex = 5;
            this.buttonTest.Text = "Тест";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // buttonMaterials
            // 
            this.buttonMaterials.Location = new System.Drawing.Point(808, 27);
            this.buttonMaterials.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMaterials.Name = "buttonMaterials";
            this.buttonMaterials.Size = new System.Drawing.Size(243, 28);
            this.buttonMaterials.TabIndex = 6;
            this.buttonMaterials.Text = "Материали";
            this.buttonMaterials.UseVisualStyleBackColor = true;
            this.buttonMaterials.Click += new System.EventHandler(this.buttonMaterials_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "TODO";
            // 
            // lblIInformation
            // 
            this.lblIInformation.AutoSize = true;
            this.lblIInformation.Location = new System.Drawing.Point(234, 21);
            this.lblIInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIInformation.Name = "lblIInformation";
            this.lblIInformation.Size = new System.Drawing.Size(57, 17);
            this.lblIInformation.TabIndex = 8;
            this.lblIInformation.Text = "Новини";
            this.lblIInformation.Click += new System.EventHandler(this.lblIInformation_Click);
            // 
            // FormMainPageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblIInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonMaterials);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonReviewTest);
            this.Controls.Add(this.buttonInformation);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMainPageStudent";
            this.Text = "Начало";
            this.Load += new System.EventHandler(this.FormMainPageStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonInformation;
        private System.Windows.Forms.Button buttonReviewTest;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonMaterials;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIInformation;
    }
}