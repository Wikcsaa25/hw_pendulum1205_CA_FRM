using hw_pendulum1205_FRM.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            @"AttachDbFileName=|DataDirectory|\Resources\music.mdf;";
        static SqlConnection connection = new SqlConnection(connectionString);
        private void Form1_Load(object sender, EventArgs e)
        {
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

        private void cBAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            connection.Close();
            connection.Open();
            SqlDataReader command1 = new SqlCommand($"select Tracks.title, Tracks.length from Albums , Tracks where Albums.id = Tracks.album and Albums.title like '{cBAlbum.SelectedItem}';", connection).ExecuteReader();
            while (command1.Read())
            {
                dgwTitles.Rows.Add(command1[0], command1[1]);
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
            string value = "Document 1";
            if (Tmp.InputBox("Tiny youtube url hozzáadása", "Adja meg a tiny youtube url-t:", ref value) == DialogResult.OK)
            {
                
            }
            else MessageBox.Show("Nem megfelelő link!");
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
