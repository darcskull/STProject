
namespace STProject
{
    partial class FormAddNews
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddNews = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxNews = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(3, 415);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заглавие";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(181, 131);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonAddNews
            // 
            this.buttonAddNews.Location = new System.Drawing.Point(273, 393);
            this.buttonAddNews.Name = "buttonAddNews";
            this.buttonAddNews.Size = new System.Drawing.Size(132, 23);
            this.buttonAddNews.TabIndex = 3;
            this.buttonAddNews.Text = "Добавяне на новина";
            this.buttonAddNews.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Новина";
            // 
            // listBoxNews
            // 
            this.listBoxNews.FormattingEnabled = true;
            this.listBoxNews.Location = new System.Drawing.Point(181, 236);
            this.listBoxNews.Name = "listBoxNews";
            this.listBoxNews.Size = new System.Drawing.Size(120, 95);
            this.listBoxNews.TabIndex = 5;
            // 
            // FormAddNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxNews);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddNews);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormAddNews";
            this.Text = "Добавяне на Новини";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddNews;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxNews;
    }
}