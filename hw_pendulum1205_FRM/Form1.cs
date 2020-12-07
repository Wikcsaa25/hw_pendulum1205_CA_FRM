using hw_pendulum1205_FRM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace hw_pendulum1205_FRM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DictionaryUp();
            
        }
        static Dictionary<string, string> lookup = new Dictionary<string, string>();
        private void DictionaryUp()
        {
            lookup.Add("Hold Your Colour", "hold_your_colour");
            lookup.Add("In Silico", "in_silico");
            lookup.Add("Immersion", "immersion");
            lookup.Add("Vírus", "virus");
            lookup.Add("Privát Mennyország", "privat_mennyorszag");
            lookup.Add("Igaz történet", "igaz_tortenet");
        }

        static string connectionString = @"Server = (localdb)\MSSQLLocalDB;" + 
            @"AttachDbFileName=|DataDirectory|Resources\music.mdf;";
        static SqlConnection connection = new SqlConnection(connectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
            cBArtist.Items.Clear();
            connection.Open();
            SqlDataReader command = new SqlCommand("SELECT DISTINCT artist FROM Albums;", connection).ExecuteReader();
            while (command.Read())
            {
                cBArtist.Items.Add(command[0]);
            }
            connection.Close();
        }

        private void cBArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBAlbum.Items.Clear();
            connection.Open();
            SqlDataReader command = new SqlCommand($"select title from Albums where artist like '{cBArtist.SelectedItem}';", connection).ExecuteReader();
            while (command.Read())
            {
                cBAlbum.Items.Add(command[0]);
            }
            connection.Close();
        }
        private List<string[]> dgwBackup = new List<string[]>();
        private void cBAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lookup.ContainsKey(cBAlbum.SelectedItem.ToString()))
               pictureBox.Image = (Image)Resources.ResourceManager.GetObject(lookup[cBAlbum.SelectedItem.ToString()]);
            connection.Open();
            SqlDataReader command = new SqlCommand($"select Albums.relase, Tracks.length from Albums , Tracks where Albums.id = Tracks.album and Albums.title like '{cBAlbum.SelectedItem}';", connection).ExecuteReader();
            int seconds = 0;
            string date = "";
            while (command.Read())
            {
                seconds += (int)Math.Round(TimeSpan.Parse(command[1].ToString()).TotalSeconds);
                date = command[0].ToString();
            }
            richTextBox.Text = $"Kiadási dátum: " + DateTime.Parse(date).ToString("yyyy. MMMM dd.") + "\nAlbum hossza: " + TimeSpan.FromSeconds(seconds).ToString();
            dgwTitles.Rows.Clear();
            dgwBackup.Clear();
            connection.Close();
            connection.Open();
            SqlDataReader command1 = new SqlCommand($"select Tracks.title, Tracks.length from Albums , Tracks where Albums.id = Tracks.album and Albums.title like '{cBAlbum.SelectedItem}';", connection).ExecuteReader();
            while (command1.Read())
            {
                dgwTitles.Rows.Add(command1[0], command1[1]);
                dgwBackup.Add(new string[] { command1[0].ToString(), command1[1].ToString() });
            }
            connection.Close();
            tBSearch.ReadOnly = false;
        }

        private void dgwTitles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            connection.Open();
            SqlDataReader command = new SqlCommand($"select url from Tracks where title like '{dgwTitles.SelectedRows[0].Cells[0].Value.ToString()}';", connection).ExecuteReader();
            while (command.Read())
            {
                if (command[0].ToString() == "null")
                {
                    lLLink.Text = "NOPE";
                    addURL.Enabled = true;
                }
                else
                {
                    lLLink.Text = "https://youtu.be/" + command[0].ToString();
                    addURL.Enabled = false;
                }
            }
            connection.Close();
        }

        private void lLLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(lLLink.Text != "NOPE")
                System.Diagnostics.Process.Start(lLLink.Text);
        }

        private void addURL_Click(object sender, EventArgs e)
        {
            string reg = @"https:\/\/youtu.be\/([a-zA-Z0-9]){11}";
            string value = "https://youtu.be/";
            if (Tmp.InputBox("Tiny youtube url hozzáadása", "Adja meg a tiny youtube url-t:", ref value) == DialogResult.OK)
            {
                if (Regex.IsMatch(value, reg))
                {
                    connection.Open();
                    SqlDataReader command = new SqlCommand($"update Tracks set url = '{value.Remove(0, 17)}' where title like '{dgwTitles.SelectedRows[0].Cells[0].Value.ToString()}'", connection).ExecuteReader();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Nem megfelelő link!");
                }
            }
        }
        Form2 frm;
        public void button3_Click(object sender, EventArgs e)
        {
            frm = new Form2();
            frm.FormClosing += Frm_FormClosing;
            frm.Show();
            connection.Open();
            SqlDataReader command = new SqlCommand($"select * from Tracks where title like '{dgwTitles.SelectedRows[0].Cells[0].Value}';", connection).ExecuteReader();
            while (command.Read())
            {
                frm.TBTitle.Text = command[1].ToString();
                frm.TBLength.Text = command[2].ToString();
                frm.TBId.Text = command[3].ToString();
                frm.TBUrl.Text = command[4].ToString();
            }
            connection.Close();
        }

        public void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Biztosan menti a változásokat?", caption: CaptionButton.Close.ToString(), buttons: MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                connection.Open();
                SqlDataReader command = new SqlCommand($"update Tracks set title = '{frm.TBTitle.Text}', length = '{frm.TBLength.Text}', url = '{frm.TBUrl.Text}' where title like '{dgwTitles.SelectedRows[0].Cells[0].Value}'; ", connection).ExecuteReader();
                connection.Close();
                connection.Open();
                dgwTitles.Rows.Clear();
                SqlDataReader command1 = new SqlCommand($"select Tracks.title, Tracks.length from Albums , Tracks where Albums.id = Tracks.album and Albums.title like '{cBAlbum.SelectedItem}';", connection).ExecuteReader();
                while (command1.Read())
                {
                    dgwTitles.Rows.Add(command1[0], command1[1]);
                }
                connection.Close();
                connection.Open();
                SqlDataReader command2 = new SqlCommand($"select Albums.relase, Tracks.length from Albums , Tracks where Albums.id = Tracks.album and Albums.title like '{cBAlbum.SelectedItem}';", connection).ExecuteReader();
                int seconds = 0;
                string date = "";
                while (command2.Read())
                {
                    seconds += (int)Math.Round(TimeSpan.Parse(command2[1].ToString()).TotalSeconds);
                    date = command2[0].ToString();
                }
                richTextBox.Text = $"Kiadási dátum: " + DateTime.Parse(date).ToString("yyyy. MMMM dd.") + "\nAlbum hossza: " + TimeSpan.FromSeconds(seconds).ToString();
                
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            bool hasAlbum = false;
            bool hasTracks = false;
            int albumCount = 0;
            int trackCount = 0;
            bool isValid = true;
            bool albumOrTrack = false;
            List<string> albums = new List<string>();
            List<string> tracks = new List<string>();
            if(!string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        if (line == "[albums]" && !hasAlbum)
                        {
                            hasAlbum = true;
                            albumOrTrack = false;
                        }
                        else if (line == "[tracks]" && !hasTracks)
                        {
                            hasTracks = true;
                            albumOrTrack = true;
                        }
                        else if (albumOrTrack && IsTrackValid(line))
                        {
                            trackCount++;
                            tracks.Add(line);
                        }
                        else if (!albumOrTrack && IsAlbumValid(line))
                        {
                            albumCount++;
                            albums.Add(line);
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                if (albumCount < 0 || trackCount < 0)
                    isValid = false;

                if (isValid)
                {
                    foreach (string item in albums)
                    {
                        string[] split = item.Split(';');
                        using (SqlCommand cmd = new SqlCommand($"INSERT INTO Albums VALUES('{split[0]}', '{split[1]}','{split[2]}','{split[3]}')", connection))
                        {
                            cmd.CommandType = CommandType.Text;

                            connection.Open();

                            cmd.ExecuteNonQuery();
                        }
                        connection.Close();

                    }
                    foreach (string item in tracks)
                    {
                        string[] split = item.Split(';');
                        using (SqlCommand cmd = new SqlCommand($"INSERT INTO Tracks VALUES('{split[0]}', '{split[1]}','{split[2]}','{split[3]}')", connection))
                        {
                            cmd.CommandType = CommandType.Text;

                            connection.Open();

                            cmd.ExecuteNonQuery();
                        }
                        connection.Close();

                    }
                    
                }
                else
                {
                    MessageBox.Show("A fájl nem helyes formátumú!");
                }
            }
            
        }
        private bool IsAlbumValid(string album)
        {
            try
            {
                string[] split = album.Split(';');
                if (split.Length != 4)
                {
                    return false;
                }
                DateTime.Parse(split[3]);
                if (split[0].Length != 4) return false;
                if (split[1].Length > 255) return false;
                if (split[2].Length > 255) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }
        private bool IsTrackValid(string track)
        {
            try
            {
                string[] split = track.Split(';');
                if (split.Length != 4) return false;
                if (split[0].Length > 255) return false;
                TimeSpan.Parse(split[1]);
                if (split[2].Length != 4) return false;
                if (split[3].Length > 30) return false;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {
            List<string[]> results = new List<string[]>();
            foreach (string[] item in dgwBackup)
            {
                if(item[0].ToLower().StartsWith(tBSearch.Text.ToLower()))
                {
                    results.Add(item);
                }
            }
            dgwTitles.Rows.Clear();
            foreach (string[] item in results)
            {
                dgwTitles.Rows.Add(item[0], item[1]);
            }
        }
    }
    public class Tmp
    {

        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
    }
}
