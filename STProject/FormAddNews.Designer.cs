
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
            this.txtNews = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(29, 403);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(100, 28);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Заглавие";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(68, 72);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(211, 22);
            this.textBoxName.TabIndex = 2;
            // 
            // buttonAddNews
            // 
            this.buttonAddNews.Location = new System.Drawing.Point(137, 403);
            this.buttonAddNews.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddNews.Name = "buttonAddNews";
            this.buttonAddNews.Size = new System.Drawing.Size(176, 28);
            this.buttonAddNews.TabIndex = 3;
            this.buttonAddNews.Text = "Добавяне на новина";
            this.buttonAddNews.UseVisualStyleBackColor = true;
            this.buttonAddNews.Click += new System.EventHandler(this.buttonAddNews_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Новина";
            // 
            // txtNews
            // 
            this.txtNews.Location = new System.Drawing.Point(48, 145);
            this.txtNews.Margin = new System.Windows.Forms.Padding(4);
            this.txtNews.Multiline = true;
            this.txtNews.Name = "txtNews";
            this.txtNews.Size = new System.Drawing.Size(245, 219);
            this.txtNews.TabIndex = 5;
            // 
            // FormAddNews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 467);
            this.Controls.Add(this.txtNews);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAddNews);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAddNews";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавяне на Новини";
            this.Load += new System.EventHandler(this.FormAddNews_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddNews;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNews;
    }
}