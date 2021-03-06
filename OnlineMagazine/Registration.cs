﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{
    public partial class Registration : Form
    {
        public bool ob;
        public string login;
        public List<String> infoObAvtore = new List<string>();
        public Registration(string ime)
        {
            if (ime == "")
            { ob = false; }
            else
            {
                login = ime;
                ob = true;
            }
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            this.Font = Configs.USER_FONT;
            this.ForeColor = Configs.USER_COLOR;
            if(ob)
            {

                infoObAvtore = SQLClass.Select("SELECT UserName, Pic, Information_about_author FROM " + Tables.AUTHORS + " WHERE UserName = '" + login + "'");

                if (infoObAvtore.Count > 2)
                {
                    button_come.Text = "Обновить данные";
                    textBox_login.Text = infoObAvtore[0];
                    textBox_pic.Text = infoObAvtore[1];
                    textBox_zapas.Enabled = false;
                    try
                    { pictureBox1.LoadAsync(textBox_pic.Text); }
                    catch (Exception)
                    {
                        pictureBox1.Image = new Bitmap("defolt_avtor.jpg");
                    }
                    textBox_about_me.Text = infoObAvtore[2];
                    textBox_password.Enabled = false;
                    checkBox_agree.Visible = false;
                    checkBox_I_author.Visible = false;

                }
                else
                {

                }
            }
            else
            {
                button2.Visible = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!ob)
            { 
                #region Добавляем пользователя
                List<String> byl = SQLClass.Select(
                    "SELECT COUNT(*) FROM " + Tables.POLZOVATELI + " WHERE Login='" + textBox_login.Text + "'");
                bool userBylUzhe = (byl[0].ToString() != "0");

                if (userBylUzhe)
                {
                    MessageBox.Show("Ты был уже. Регистрируйся заново");
                    return;
                }

                SQLClass.Insert("INSERT INTO " + Tables.POLZOVATELI +
                    "(`Login`, `Parol`, `ban`, `aboutme`, admin)" +
                    " VALUES ('" + textBox_login.Text + "'," +
                    "'" + textBox_password.Text + "'," +
                    "0" + ",'" + textBox_about_me.Text + "', 0)");
                #endregion


                if (checkBox_I_author.Checked == true)
                {
                    #region Добавляем автора
                    List<String> isAdminData = SQLClass.Select(
                        "SELECT COUNT(*) FROM " + Tables.AUTHORS + " WHERE `UserName`=\"" + textBox_login.Text +
                        "\"");
                    bool BylUzhe = (isAdminData[0].ToString() != "0");

                    if (BylUzhe)
                    {
                        MessageBox.Show("Ты был уже. Регистрируйся заново");
                        return;
                    }

                    SQLClass.Insert("INSERT INTO " + Tables.AUTHORS + 
                        "(UserName, Information_about_author, Pic) " +
                        "VALUES ('" + textBox_login.Text + "','" + 
                        textBox_about_me.Text + "', '" +
                        textBox_pic + "')");
                    #endregion
                }
            }
            else
            {

                if (infoObAvtore[0] != textBox_login.Text)
                {

                    List<String> isAdminData = SQLClass.Select(
                     "SELECT COUNT(*) FROM " + Tables.AUTHORS + " WHERE `UserName`=\"" + textBox_login.Text +
                     "\"");
                    bool BylUzhe = (isAdminData[0].ToString() != "0");

                    if (BylUzhe)
                    {
                        MessageBox.Show("Ты вообще не оригинальный");
                        return;
                    }


                    isAdminData = SQLClass.Select(
                     "SELECT COUNT(*) FROM " + Tables.AUTHORS + " WHERE `UserName`=\"" + textBox_login.Text +
                     "\"");
                     BylUzhe = (isAdminData[0].ToString() != "0");

                    if (BylUzhe)
                    {
                        MessageBox.Show("Такой пользователь уже есть");
                        return;
                    }



                    SQLClass.Update("UPDATE " + Tables.ARTICLES +
                       " SET Author = '" + textBox_login.Text +
                       "' WHERE Author = '" + login + "'");

                    SQLClass.Update("UPDATE " + Tables.POLZOVATELI +
                    " SET Login = '" + textBox_login.Text +
                    "' WHERE Login = '" + login + "'");

                    SQLClass.Update("UPDATE " + Tables.BALANCE +
                    " SET Login = '" + textBox_login.Text +
                    "' WHERE Login = '" + login + "'");


                    SQLClass.Update("UPDATE " + Tables.LIKES +
                    " SET Login = '" + textBox_login.Text +
                    "' WHERE Login = '" + login + "'");






                }


                SQLClass.Update("UPDATE " + Tables.AUTHORS + 
                    " SET UserName = '" + textBox_login.Text + 
                    "', Pic = '" + textBox_pic.Text +
                    "', Information_about_author = '" + textBox_about_me.Text + 
                    "' WHERE UserName = '" + login + "'");



            }
            Close();            
        }

        private void textBox_about_me_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || checkBox_agree.Checked)
            {
                button1_Click(sender, null);
            }
        }

        private void checkBox_agree_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || checkBox_agree.Checked)
            {
                button1_Click(sender, null);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Load(textBox_pic.Text); 

            }
            catch(Exception)
            {
                pictureBox1.Load("https://memepedia.ru/wp-content/uploads/2017/04/%D0%B5%D0%B1%D0%B0%D1%82%D1%8C-%D1%82%D1%8B-%D0%BB%D0%BE%D1%85-%D0%BE%D1%80%D0%B8%D0%B3%D0%B8%D0%BD%D0%B0%D0%BB.jpg");
               
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_login.Text = infoObAvtore[0];
            textBox_pic.Text = infoObAvtore[1];
            textBox_about_me.Text = infoObAvtore[2];

        }
    }
}
