﻿namespace WindowsFormsApplication4
{
    partial class FBIform
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
            this.button_save = new System.Windows.Forms.Button();
            this.button2_print = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_add_author = new System.Windows.Forms.Button();
            this.button_deleteAuthor = new System.Windows.Forms.Button();
            this.textBoxDelete_author = new System.Windows.Forms.TextBox();
            this.checkBox1_Delete_author = new System.Windows.Forms.CheckBox();
            this.label_spisok_of_authors = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.textBox_fineAuthor = new System.Windows.Forms.TextBox();
            this.button_fineAuthor = new System.Windows.Forms.Button();
            this.label_Na = new System.Windows.Forms.Label();
            this.textBox_fineAuthor_chislo = new System.Windows.Forms.TextBox();
            this.label8_rubl = new System.Windows.Forms.Label();
            this.checkBox2_fineAuthor = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1_Authors = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(17, 186);
            this.button_save.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(100, 28);
            this.button_save.TabIndex = 5;
            this.button_save.Text = "Сохранить";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button2_print
            // 
            this.button2_print.Location = new System.Drawing.Point(193, 186);
            this.button2_print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2_print.Name = "button2_print";
            this.button2_print.Size = new System.Drawing.Size(100, 28);
            this.button2_print.TabIndex = 5;
            this.button2_print.Text = "Печать";
            this.button2_print.UseVisualStyleBackColor = true;
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(193, 15);
            this.button_update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(100, 28);
            this.button_update.TabIndex = 5;
            this.button_update.Text = "Обновить";
            this.button_update.UseVisualStyleBackColor = true;
            // 
            // button_add_author
            // 
            this.button_add_author.Location = new System.Drawing.Point(13, 15);
            this.button_add_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_add_author.Name = "button_add_author";
            this.button_add_author.Size = new System.Drawing.Size(100, 55);
            this.button_add_author.TabIndex = 5;
            this.button_add_author.Text = "Добавить автора";
            this.button_add_author.UseVisualStyleBackColor = true;
            // 
            // button_deleteAuthor
            // 
            this.button_deleteAuthor.Location = new System.Drawing.Point(13, 222);
            this.button_deleteAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_deleteAuthor.Name = "button_deleteAuthor";
            this.button_deleteAuthor.Size = new System.Drawing.Size(135, 23);
            this.button_deleteAuthor.TabIndex = 5;
            this.button_deleteAuthor.Text = "Удалить автора";
            this.button_deleteAuthor.UseVisualStyleBackColor = true;
            // 
            // textBoxDelete_author
            // 
            this.textBoxDelete_author.Location = new System.Drawing.Point(156, 220);
            this.textBoxDelete_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDelete_author.Name = "textBoxDelete_author";
            this.textBoxDelete_author.Size = new System.Drawing.Size(136, 22);
            this.textBoxDelete_author.TabIndex = 6;
            // 
            // checkBox1_Delete_author
            // 
            this.checkBox1_Delete_author.AutoSize = true;
            this.checkBox1_Delete_author.Location = new System.Drawing.Point(301, 220);
            this.checkBox1_Delete_author.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1_Delete_author.Name = "checkBox1_Delete_author";
            this.checkBox1_Delete_author.Size = new System.Drawing.Size(54, 21);
            this.checkBox1_Delete_author.TabIndex = 7;
            this.checkBox1_Delete_author.Text = "282";
            this.checkBox1_Delete_author.UseVisualStyleBackColor = true;
            // 
            // label_spisok_of_authors
            // 
            this.label_spisok_of_authors.AutoSize = true;
            this.label_spisok_of_authors.Location = new System.Drawing.Point(121, 54);
            this.label_spisok_of_authors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_spisok_of_authors.Name = "label_spisok_of_authors";
            this.label_spisok_of_authors.Size = new System.Drawing.Size(112, 17);
            this.label_spisok_of_authors.TabIndex = 8;
            this.label_spisok_of_authors.Text = "Список авторов";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // textBox_fineAuthor
            // 
            this.textBox_fineAuthor.Location = new System.Drawing.Point(157, 255);
            this.textBox_fineAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_fineAuthor.Name = "textBox_fineAuthor";
            this.textBox_fineAuthor.Size = new System.Drawing.Size(132, 22);
            this.textBox_fineAuthor.TabIndex = 9;
            // 
            // button_fineAuthor
            // 
            this.button_fineAuthor.Location = new System.Drawing.Point(-1, 254);
            this.button_fineAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_fineAuthor.Name = "button_fineAuthor";
            this.button_fineAuthor.Size = new System.Drawing.Size(149, 53);
            this.button_fineAuthor.TabIndex = 5;
            this.button_fineAuthor.Text = "Оштрафовать автора";
            this.button_fineAuthor.UseVisualStyleBackColor = true;
            // 
            // label_Na
            // 
            this.label_Na.AutoSize = true;
            this.label_Na.Location = new System.Drawing.Point(156, 283);
            this.label_Na.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Na.Name = "label_Na";
            this.label_Na.Size = new System.Drawing.Size(28, 17);
            this.label_Na.TabIndex = 10;
            this.label_Na.Text = "на ";
            // 
            // textBox_fineAuthor_chislo
            // 
            this.textBox_fineAuthor_chislo.Location = new System.Drawing.Point(195, 283);
            this.textBox_fineAuthor_chislo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_fineAuthor_chislo.Name = "textBox_fineAuthor_chislo";
            this.textBox_fineAuthor_chislo.Size = new System.Drawing.Size(55, 22);
            this.textBox_fineAuthor_chislo.TabIndex = 11;
            // 
            // label8_rubl
            // 
            this.label8_rubl.AutoSize = true;
            this.label8_rubl.Location = new System.Drawing.Point(260, 289);
            this.label8_rubl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8_rubl.Name = "label8_rubl";
            this.label8_rubl.Size = new System.Drawing.Size(55, 17);
            this.label8_rubl.TabIndex = 12;
            this.label8_rubl.Text = "рублей";
            // 
            // checkBox2_fineAuthor
            // 
            this.checkBox2_fineAuthor.AutoSize = true;
            this.checkBox2_fineAuthor.Location = new System.Drawing.Point(301, 255);
            this.checkBox2_fineAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2_fineAuthor.Name = "checkBox2_fineAuthor";
            this.checkBox2_fineAuthor.Size = new System.Drawing.Size(70, 21);
            this.checkBox2_fineAuthor.TabIndex = 13;
            this.checkBox2_fineAuthor.Text = "выезд";
            this.checkBox2_fineAuthor.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1_Authors
            // 
            this.tableLayoutPanel1_Authors.AutoScroll = true;
            this.tableLayoutPanel1_Authors.AutoScrollMinSize = new System.Drawing.Size(0, 500);
            this.tableLayoutPanel1_Authors.ColumnCount = 1;
            this.tableLayoutPanel1_Authors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_Authors.Location = new System.Drawing.Point(17, 78);
            this.tableLayoutPanel1_Authors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1_Authors.Name = "tableLayoutPanel1_Authors";
            this.tableLayoutPanel1_Authors.RowCount = 30;
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1_Authors.Size = new System.Drawing.Size(299, 101);
            this.tableLayoutPanel1_Authors.TabIndex = 14;
            // 
            // FBIform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.tableLayoutPanel1_Authors);
            this.Controls.Add(this.checkBox2_fineAuthor);
            this.Controls.Add(this.label8_rubl);
            this.Controls.Add(this.textBox_fineAuthor_chislo);
            this.Controls.Add(this.label_Na);
            this.Controls.Add(this.textBox_fineAuthor);
            this.Controls.Add(this.label_spisok_of_authors);
            this.Controls.Add(this.checkBox1_Delete_author);
            this.Controls.Add(this.textBoxDelete_author);
            this.Controls.Add(this.button_fineAuthor);
            this.Controls.Add(this.button_deleteAuthor);
            this.Controls.Add(this.button_add_author);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button2_print);
            this.Controls.Add(this.button_save);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FBIform";
            this.Text = "FBI";
            this.Load += new System.EventHandler(this.FBIform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button2_print;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_add_author;
        private System.Windows.Forms.Button button_deleteAuthor;
        private System.Windows.Forms.TextBox textBoxDelete_author;
        private System.Windows.Forms.CheckBox checkBox1_Delete_author;
        private System.Windows.Forms.Label label_spisok_of_authors;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label8_rubl;
        private System.Windows.Forms.TextBox textBox_fineAuthor_chislo;
        private System.Windows.Forms.Label label_Na;
        private System.Windows.Forms.TextBox textBox_fineAuthor;
        private System.Windows.Forms.Button button_fineAuthor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1_Authors;
        private System.Windows.Forms.CheckBox checkBox2_fineAuthor;
    }
}