﻿namespace WindowsFormsApplication4
{
    partial class AuthorMainForm
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
            this.panel1_reklama = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2_reklama = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_Statiya = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aboutAuthorLabel = new System.Windows.Forms.Label();
            this.Avatar_author = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_statistika = new System.Windows.Forms.Button();
            this.panel_spisok_statey = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.leftTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.table_right_up = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Balance = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1_reklama.SuspendLayout();
            this.panel2_reklama.SuspendLayout();
            this.panel_Statiya.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Avatar_author)).BeginInit();
            this.panel_spisok_statey.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.leftTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.table_right_up.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1_reklama
            // 
            this.panel1_reklama.Controls.Add(this.label2);
            this.panel1_reklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1_reklama.Location = new System.Drawing.Point(3, 3);
            this.panel1_reklama.Name = "panel1_reklama";
            this.panel1_reklama.Size = new System.Drawing.Size(204, 122);
            this.panel1_reklama.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "РЕЛАМА";
            // 
            // panel2_reklama
            // 
            this.panel2_reklama.Controls.Add(this.label3);
            this.panel2_reklama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2_reklama.Location = new System.Drawing.Point(3, 131);
            this.panel2_reklama.Name = "panel2_reklama";
            this.panel2_reklama.Size = new System.Drawing.Size(204, 352);
            this.panel2_reklama.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "РЕЛАМА";
            // 
            // panel_Statiya
            // 
            this.panel_Statiya.Controls.Add(this.panel1);
            this.panel_Statiya.Controls.Add(this.label1);
            this.panel_Statiya.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Statiya.Location = new System.Drawing.Point(3, 3);
            this.panel_Statiya.Name = "panel_Statiya";
            this.panel_Statiya.Size = new System.Drawing.Size(312, 429);
            this.panel_Statiya.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статья";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(312, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Опубликовать статью";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aboutAuthorLabel
            // 
            this.aboutAuthorLabel.AutoSize = true;
            this.aboutAuthorLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutAuthorLabel.Location = new System.Drawing.Point(3, 0);
            this.aboutAuthorLabel.Name = "aboutAuthorLabel";
            this.aboutAuthorLabel.Size = new System.Drawing.Size(61, 79);
            this.aboutAuthorLabel.TabIndex = 5;
            this.aboutAuthorLabel.Text = "Об авторе";
            this.aboutAuthorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Avatar_author
            // 
            this.Avatar_author.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Avatar_author.Location = new System.Drawing.Point(70, 3);
            this.Avatar_author.Name = "Avatar_author";
            this.Avatar_author.Size = new System.Drawing.Size(96, 73);
            this.Avatar_author.TabIndex = 6;
            this.Avatar_author.TabStop = false;
            this.Avatar_author.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 489);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_statistika
            // 
            this.button_statistika.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_statistika.Location = new System.Drawing.Point(3, 470);
            this.button_statistika.Name = "button_statistika";
            this.button_statistika.Size = new System.Drawing.Size(169, 39);
            this.button_statistika.TabIndex = 10;
            this.button_statistika.UseVisualStyleBackColor = true;
            this.button_statistika.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_spisok_statey
            // 
            this.panel_spisok_statey.Controls.Add(this.label5);
            this.panel_spisok_statey.Controls.Add(this.label4);
            this.panel_spisok_statey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_spisok_statey.Location = new System.Drawing.Point(3, 279);
            this.panel_spisok_statey.Name = "panel_spisok_statey";
            this.panel_spisok_statey.Size = new System.Drawing.Size(169, 185);
            this.panel_spisok_statey.TabIndex = 11;
            this.panel_spisok_statey.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_spisok_statey_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Работы";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 489);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.leftTableLayoutPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.table_right_up, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(721, 518);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // leftTableLayoutPanel
            // 
            this.leftTableLayoutPanel.ColumnCount = 1;
            this.leftTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftTableLayoutPanel.Controls.Add(this.panel1_reklama, 0, 0);
            this.leftTableLayoutPanel.Controls.Add(this.comboBox1, 0, 2);
            this.leftTableLayoutPanel.Controls.Add(this.panel2_reklama, 0, 1);
            this.leftTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.leftTableLayoutPanel.Name = "leftTableLayoutPanel";
            this.leftTableLayoutPanel.RowCount = 3;
            this.leftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.leftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.leftTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.leftTableLayoutPanel.Size = new System.Drawing.Size(210, 512);
            this.leftTableLayoutPanel.TabIndex = 0;
            this.leftTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel_Statiya, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(219, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(318, 512);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // table_right_up
            // 
            this.table_right_up.ColumnCount = 1;
            this.table_right_up.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_right_up.Controls.Add(this.button_statistika, 0, 3);
            this.table_right_up.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.table_right_up.Controls.Add(this.Button_Balance, 0, 1);
            this.table_right_up.Controls.Add(this.panel_spisok_statey, 0, 2);
            this.table_right_up.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_right_up.Location = new System.Drawing.Point(543, 3);
            this.table_right_up.Name = "table_right_up";
            this.table_right_up.RowCount = 4;
            this.table_right_up.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.table_right_up.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.table_right_up.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.table_right_up.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333333F));
            this.table_right_up.Size = new System.Drawing.Size(175, 512);
            this.table_right_up.TabIndex = 2;
            this.table_right_up.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel5.Controls.Add(this.aboutAuthorLabel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Avatar_author, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(169, 79);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // Button_Balance
            // 
            this.Button_Balance.Font = new System.Drawing.Font("Ravie", 14.25F, System.Drawing.FontStyle.Bold);
            this.Button_Balance.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Balance.Location = new System.Drawing.Point(3, 88);
            this.Button_Balance.Name = "Button_Balance";
            this.Button_Balance.Size = new System.Drawing.Size(169, 142);
            this.Button_Balance.TabIndex = 12;
            this.Button_Balance.Text = "Баланс";
            this.Button_Balance.UseVisualStyleBackColor = true;
            this.Button_Balance.Click += new System.EventHandler(this.Balance_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(7, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 383);
            this.panel1.TabIndex = 1;
            // 
            // AuthorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 518);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(737, 556);
            this.Name = "AuthorMainForm";
            this.Text = "Автор";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1_reklama.ResumeLayout(false);
            this.panel1_reklama.PerformLayout();
            this.panel2_reklama.ResumeLayout(false);
            this.panel2_reklama.PerformLayout();
            this.panel_Statiya.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Avatar_author)).EndInit();
            this.panel_spisok_statey.ResumeLayout(false);
            this.panel_spisok_statey.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.leftTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.table_right_up.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1_reklama;
        private System.Windows.Forms.Panel panel2_reklama;
        private System.Windows.Forms.Panel panel_Statiya;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label aboutAuthorLabel;
        private System.Windows.Forms.PictureBox Avatar_author;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_statistika;
        private System.Windows.Forms.Panel panel_spisok_statey;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel leftTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel table_right_up;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Balance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}