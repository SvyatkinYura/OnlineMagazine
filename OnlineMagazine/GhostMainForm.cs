using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Net;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication4
{ 

    public partial class GhostMainForm : Form
    {
        public static List<AuthorStat> stat = new List<AuthorStat>();

        public List<LinkLabel> arts = new List<LinkLabel>();
        public List<PictureBox> piccc = new List<PictureBox>();
        WebClient client = new WebClient();
        public string[] url = new string[50];
        int kolvo_nazatiy = 0;
        public string kuda_i_kak;
        public int articleY = 50;
      
        public GhostMainForm()
        {
            InitializeComponent();
            Configs.ZAGOLOVOK_FONT = popularArticlesLabel.Font;
            label_Author_header.Font = Configs.ZAGOLOVOK_FONT;

            label_cats_header.Font = Configs.ZAGOLOVOK_FONT;
            //label_popular.Text = stat.kategorita_statii;
            SQLClass.OpenConnection();

            /*List<AuthorStat> writers = new List<AuthorStat>();
            int uy = 0;
            foreach (AuthorStat write in writers)
            {
                LinkLabel linklabel1 = new LinkLabel();
                linklabel1.Size = new Size (70, 20); 
                linklabel1.Location = new Point (50, 10 + 30*uy);
                linklabel1.Text = write.name;

                Left_panel.Controls.Add(linklabel1);
                uy++;
            }*/
        }
        
        private void ArticleClick(object sender, EventArgs e)
        {
            foreach (LinkLabel lab in arts)
            {
                if (sender.Equals(lab))
                {
                    statiya stat = statiya.Click1(((Label)sender).Text);
                    StatiyaForm OknoStatiya = new StatiyaForm(stat);
                    OknoStatiya.ShowDialog();
                }
            }
        }

        private void clik_na_pic(object sender, EventArgs e)
        {
            foreach (PictureBox lab in piccc)
            {
                if (sender.Equals(lab))
                {
                    statiya stat = statiya.Click1(lab.Tag.ToString());
                    StatiyaForm OknoStatiya = new StatiyaForm(stat);
                    OknoStatiya.ShowDialog();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Right_panel.Controls.Clear();
            //Right_panel.Controls.Add(button_add_reklama);
            //Right_panel.Controls.Add(button1);

            Right_panel.Controls.Add(tableLayoutPanel1);
            button_add_reklama.Visible = false;
                
            lable_name_of_polzovatel.Text = Users.CURRENT_USER;
            if (lable_name_of_polzovatel.Text != "NONAME")
            {
                lable_name_of_polzovatel.Text = "Вы вошли как " + Users.CURRENT_USER;
                Right_panel.Controls.Add(lable_name_of_polzovatel);
                button_add_reklama.Visible = true;
            }

            #region Обновление списка категорий
            Right_panel.Controls.Add(label_cats_header);
            Right_panel.Controls.Add(categories_linklabel);

            List<String> catsList = SQLClass.Select("SELECT Name FROM " + Tables.CATEGORIES + " LIMIT 0, 7");

            int catY = 210;
            for (int artIndex = 0; artIndex < catsList.Count; artIndex++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, catY);
                label1.Size = new Size(100, 20);
                label1.Text = catsList[artIndex].ToString();
                label1.Click += new System.EventHandler(Author_Or_Category_CLick);
                Right_panel.Controls.Add(label1);
                catY += 28;
            }
            #endregion

            #region Обновление списка авторов

            Right_panel.Controls.Add(label_Author_header);
            Right_panel.Controls.Add(label_author);

            List<String> authorsList = SQLClass.Select("SELECT UserName FROM " + Tables.AUTHORS + " LIMIT 0, 3");

            int authorsY = 75;
            for (int artIndex = 0; artIndex < authorsList.Count; artIndex++)
            {
                Label label1 = new Label();
                label1.Location = new Point(0, authorsY);
                label1.Size = new Size(100, 20);
                label1.Text = authorsList[artIndex].ToString();
                label1.Click += new System.EventHandler(Author_Or_Category_CLick);
                Right_panel.Controls.Add(label1);
                authorsY += 25;
            }
            #endregion

            #region Advertising

            List<String> s = Advertising.GetRandom();
            reclama.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama.LoadAsync(s[0]);
            reclama.Tag = s[1];


            s = Advertising.GetRandom();
            reclama2.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama2.LoadAsync(s[0]);
            reclama3.Tag = s[1];

            s = Advertising.GetRandom();
            reclama3.SizeMode = PictureBoxSizeMode.StretchImage;
            reclama3.LoadAsync(s[0]);
            reclama3.Tag = s[1];
            #endregion

            textBox_search.Text = "";
            butto_search_Click(sender, e);


            textBox_search.Text = "Поиск";
        }    


        private void butto_search_Click(object sender, EventArgs e)
        {
            Centr_panel.Controls.Clear();

            textBox_login.Text = "";
            textBox_password.Text = "";
            
            List<String> PopularArticles = SQLClass.Select
                ("SELECT Header, Picture FROM " + Tables.ARTICLES +
                " WHERE new = 0 AND (header like '%" + textBox_search.Text + "%'" +
                " OR category like '%" + textBox_search.Text + "%'" +
                " OR author like '%" + textBox_search.Text + "%') LIMIT 0, 3");
            
            int articleY = 10;

            for (int artIndex = 0; artIndex < PopularArticles.Count; artIndex += 2)
            {
                #region Article header
                Panel articleHeaderPanel = new Panel();
                articleHeaderPanel.Size = new Size(Centr_panel.Width, 30);
                articleHeaderPanel.Dock = DockStyle.Top;
                articleHeaderPanel.TabIndex = 0;
                Centr_panel.Controls.Add(articleHeaderPanel);

                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, 0);
                label1.Size = new Size(180, 20);
                label1.Text = PopularArticles[artIndex].ToString();
                label1.Click += new System.EventHandler(ArticleClick);
                articleHeaderPanel.Controls.Add(label1);

                PictureBox likesPB = new PictureBox();
                likesPB.Size = new Size(20, 20);
                likesPB.Location = new Point(200, 0);
                likesPB.Image = Properties.Resources.like;
                articleHeaderPanel.Controls.Add(likesPB);

                Label likesLabel = new Label();
                likesLabel.Location = new Point(230, 0);
                likesLabel.Size = new Size(20, 20);
                articleHeaderPanel.Controls.Add(likesLabel);

                Label dislikesLabel = new Label();
                dislikesLabel.Location = new Point(290, 0);
                dislikesLabel.Size = new Size(20, 20);
                articleHeaderPanel.Controls.Add(dislikesLabel);

                StatiyaForm.GetStata(likesLabel, dislikesLabel, label1.Text);
                #endregion

                //Video
                if (PopularArticles[artIndex + 1].ToString().Contains("www.youtube.com"))
                {
                    String url = PopularArticles[artIndex + 1].ToString().Replace("watch?v=", "embed/");

                    String embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"" + Centr_panel.Width + "\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";

                    WebBrowser web = new WebBrowser();
                    web.TabIndex = 1;
                    web.ScrollBarsEnabled = false;
                    web.Dock = DockStyle.Top;
                    web.DocumentText = string.Format(embed, url);
                    web.Location = new Point(0, articleY + 25);
                    Centr_panel.Controls.Add(web);
                }
                //Picture
                else
                {
                    String[] chasti_stroki = PopularArticles[artIndex + 1].ToString().Split(new char[] { ' ', '/' });

                    PictureBox artImage = new PictureBox();
                    artImage.Location = new Point(0, articleY + 25);
                    artImage.Tag = label1.Text;
                    artImage.Size = new Size(Centr_panel.Width, 150);
                    artImage.Dock = DockStyle.Top;
                    artImage.Click += new System.EventHandler(clik_na_pic);
                    artImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    artImage.TabIndex = 1;

                    try
                    {
                        artImage.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            artImage.LoadAsync(PopularArticles[artIndex + 1].ToString());
                            Uri uri = new Uri(PopularArticles[artIndex + 1].ToString());
                            client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                        }
                        catch (Exception)
                        {
                            artImage.Image = new Bitmap("defolt_statiy.jpg");
                        }
                    }

                    Centr_panel.Controls.Add(artImage);
                    piccc.Add(artImage);
                }

                arts.Add(label1);
                articleY += 180;
            }

            Centr_panel.Controls.Add(dalee);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration form = new Registration();
            form.ShowDialog();
        }

        private void label_author_Click(object sender, EventArgs e)
        {
            List_of_author form2 = new List_of_author();
            form2.ShowDialog();
        }

        private void categories_linklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoriesForm form3 = new CategoriesForm(false);
            form3.ShowDialog();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            AdvertisingForm form = new AdvertisingForm();
            form.ShowDialog();
        }

        private void GhostMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SQLClass.CloseConnection();
        }
        
        /// <summary>
        /// Функция клика на рекламу
        /// </summary>
        private void reclama_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(((PictureBox)sender).Tag.ToString()); 
            }
            catch (Exception)
            { 
                Process.Start("https://www.yandex.ru"); 
            }
        }
        
        private void button_login_Click(object sender, EventArgs e)
        {
            Users.CURRENT_USER = textBox_login.Text;
            List<String> AuthorLoginData = SQLClass.Select
                ("SELECT COUNT(*) FROM " + Tables.AUTHORS +
                " WHERE UserName = '" + textBox_login.Text + "'" +
                " AND UserName IN (SELECT Login FROM " + Tables.POLZOVATELI +
                " WHERE Login = '" + textBox_login.Text + "' and Parol = '" + textBox_password.Text + "')");

            List<String> Polzovatel = SQLClass.Select
                ("SELECT COUNT(*) FROM " + Tables.POLZOVATELI +
                " WHERE Login = '" + textBox_login.Text + "' and Parol = '" + textBox_password.Text + "'");

            if (AuthorLoginData[0] != "0")
            {
                Users.CURRENT_USER = textBox_login.Text;
                AuthorMainForm af = new AuthorMainForm(textBox_login.Text);
                af.ShowDialog();
                Form1_Load(sender, e);
            }
            else if (label_password.Text != "" && To_come_in.LogIntoAdminZone(textBox_login.Text, textBox_password.Text))
            {
                Form1_Load(sender, e);
            }
            else if (Polzovatel[0] != "0")
            {
                Form1_Load(sender, e);
            }
            else MessageBox.Show("Вас в безе нет (Не верен пароль или логин)");
        }

        private void button_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_login_Click(sender, null);
            }
        }
        
        private void Centr_panel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void butto_search_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                butto_search_Click(sender, null);
            }
        }

        private void label_popular_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// КЛик на автора / категорию
        /// </summary>
        private void Author_Or_Category_CLick(object sender, EventArgs e)
        {
            textBox_search.Text = ((Label)sender).Text;
            butto_search_Click(sender, e);
        }





        private void dalee_Click(object sender, EventArgs e)
        {
            kolvo_nazatiy++;
            List<String> PopularArticles =
                SQLClass.Select("SELECT Header, Picture FROM " + Tables.ARTICLES +
                " WHERE new = 0 AND (header like '%" + textBox_search.Text + "%'" +
                " OR category like '%" + textBox_search.Text + "%'" +
                " OR author like '%" + textBox_search.Text + "%') "+
                " LIMIT " + Convert.ToString(kolvo_nazatiy * 3) + ", 3");

            for (int artIndex = 0; artIndex < PopularArticles.Count; artIndex += 2)
            {
                #region Article header
                Panel articleHeaderPanel = new Panel();
                articleHeaderPanel.Size = new Size(Centr_panel.Width, 30);
                articleHeaderPanel.Dock = DockStyle.Top;
                articleHeaderPanel.TabIndex = 0;
                Centr_panel.Controls.Add(articleHeaderPanel);

                LinkLabel label1 = new LinkLabel();
                label1.Location = new Point(0, 0);
                label1.Size = new Size(180, 20);
                label1.Text = PopularArticles[artIndex].ToString();
                label1.Click += new System.EventHandler(ArticleClick);
                articleHeaderPanel.Controls.Add(label1);

                PictureBox likesPB = new PictureBox();
                likesPB.Size = new Size(20, 20);
                likesPB.Location = new Point(200, 0);
                likesPB.Image = Properties.Resources.like;
                articleHeaderPanel.Controls.Add(likesPB);

                Label likesLabel = new Label();
                likesLabel.Location = new Point(230, 0);
                likesLabel.Size = new Size(20, 20);
                articleHeaderPanel.Controls.Add(likesLabel);

                Label dislikesLabel = new Label();
                dislikesLabel.Location = new Point(290, 0);
                dislikesLabel.Size = new Size(20, 20);
                articleHeaderPanel.Controls.Add(dislikesLabel);

                StatiyaForm.GetStata(likesLabel, dislikesLabel, label1.Text);
                #endregion

                //Video
                if (PopularArticles[artIndex + 1].ToString().Contains("www.youtube.com"))
                {
                    String url = PopularArticles[artIndex + 1].ToString().Replace("watch?v=", "embed/");

                    String embed = "<html><head>" +
                        "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
                        "</head><body>" +
                        "<iframe width=\"" + Centr_panel.Width + "\" src=\"{0}\"" +
                        "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
                        "</body></html>";

                    WebBrowser web = new WebBrowser();
                    web.TabIndex = 1;
                    web.Dock = DockStyle.Top;
                    web.DocumentText = string.Format(embed, url);
                    web.Location = new Point(0, articleY + 25);
                    Centr_panel.Controls.Add(web);
                }
                //Picture
                else
                {
                    String[] chasti_stroki = PopularArticles[artIndex + 1].ToString().Split(new char[] { ' ', '/' });

                    PictureBox artImage = new PictureBox();
                    artImage.Location = new Point(0, articleY + 25);
                    artImage.Tag = label1.Text;
                    artImage.Size = new Size(Centr_panel.Width, 150);
                    artImage.Dock = DockStyle.Top;
                    artImage.Click += new System.EventHandler(clik_na_pic);
                    artImage.SizeMode = PictureBoxSizeMode.StretchImage;
                    artImage.TabIndex = 1;

                    try
                    {
                        artImage.Image = new Bitmap(chasti_stroki[chasti_stroki.Length - 1]);
                    }
                    catch (Exception)
                    {
                        try
                        {
                            artImage.LoadAsync(PopularArticles[artIndex + 1].ToString());
                            Uri uri = new Uri(PopularArticles[artIndex + 1].ToString());
                            client.DownloadFileAsync(uri, chasti_stroki[chasti_stroki.Length - 1]);
                        }
                        catch (Exception)
                        {
                            artImage.Image = new Bitmap("defolt_statiy.jpg");
                        }
                    }

                    Centr_panel.Controls.Add(artImage);
                    piccc.Add(artImage);
                }

                arts.Add(label1);
                articleY += 180;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowColor = true;

            fontDialog1.Font = this.Font;
            fontDialog1.Color = this.ForeColor;

            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                ColorDialog MyDialog = new ColorDialog
                {
                    AllowFullOpen = false,
                    ShowHelp = true,
                    Color = popularArticlesLabel.ForeColor
                };

                if (MyDialog.ShowDialog() == DialogResult.OK)
                {
                    popularArticlesLabel.ForeColor = MyDialog.Color;
                }

                this.Font = fontDialog1.Font;
                this.ForeColor = MyDialog.Color;
                Configs.USER_FONT = fontDialog1.Font;
                Configs.USER_COLOR = MyDialog.Color;
            }
        }

        private void Right_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}