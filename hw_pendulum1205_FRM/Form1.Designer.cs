
namespace hw_pendulum1205_FRM
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lLLink = new System.Windows.Forms.LinkLabel();
            this.cBArtist = new System.Windows.Forms.ComboBox();
            this.cBAlbum = new System.Windows.Forms.ComboBox();
            this.tBSearch = new System.Windows.Forms.TextBox();
            this.dgwTitles = new System.Windows.Forms.DataGridView();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.addURL = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTitles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(244, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Album";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Search in track\'s title";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(516, 486);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "URL (if any):";
            // 
            // lLLink
            // 
            this.lLLink.AutoSize = true;
            this.lLLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLLink.Location = new System.Drawing.Point(661, 486);
            this.lLLink.Name = "lLLink";
            this.lLLink.Size = new System.Drawing.Size(68, 25);
            this.lLLink.TabIndex = 1;
            this.lLLink.TabStop = true;
            this.lLLink.Text = "NOPE";
            this.lLLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLLink_LinkClicked);
            // 
            // cBArtist
            // 
            this.cBArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBArtist.FormattingEnabled = true;
            this.cBArtist.Location = new System.Drawing.Point(12, 54);
            this.cBArtist.Name = "cBArtist";
            this.cBArtist.Size = new System.Drawing.Size(206, 33);
            this.cBArtist.TabIndex = 2;
            this.cBArtist.SelectedIndexChanged += new System.EventHandler(this.cBArtist_SelectedIndexChanged);
            // 
            // cBAlbum
            // 
            this.cBAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cBAlbum.FormattingEnabled = true;
            this.cBAlbum.Location = new System.Drawing.Point(249, 54);
            this.cBAlbum.Name = "cBAlbum";
            this.cBAlbum.Size = new System.Drawing.Size(206, 33);
            this.cBAlbum.TabIndex = 3;
            this.cBAlbum.SelectedIndexChanged += new System.EventHandler(this.cBAlbum_SelectedIndexChanged);
            // 
            // tBSearch
            // 
            this.tBSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBSearch.Location = new System.Drawing.Point(12, 165);
            this.tBSearch.Name = "tBSearch";
            this.tBSearch.ReadOnly = true;
            this.tBSearch.Size = new System.Drawing.Size(443, 30);
            this.tBSearch.TabIndex = 4;
            // 
            // dgwTitles
            // 
            this.dgwTitles.AllowUserToAddRows = false;
            this.dgwTitles.AllowUserToDeleteRows = false;
            this.dgwTitles.AllowUserToResizeColumns = false;
            this.dgwTitles.AllowUserToResizeRows = false;
            this.dgwTitles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwTitles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTitles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Length});
            this.dgwTitles.Location = new System.Drawing.Point(12, 218);
            this.dgwTitles.MultiSelect = false;
            this.dgwTitles.Name = "dgwTitles";
            this.dgwTitles.ReadOnly = true;
            this.dgwTitles.RowHeadersVisible = false;
            this.dgwTitles.RowHeadersWidth = 51;
            this.dgwTitles.RowTemplate.Height = 24;
            this.dgwTitles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwTitles.Size = new System.Drawing.Size(443, 406);
            this.dgwTitles.TabIndex = 5;
            this.dgwTitles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTitles_CellClick);
            // 
            // richTextBox
            // 
            this.richTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBox.Location = new System.Drawing.Point(664, 218);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(350, 150);
            this.richTextBox.TabIndex = 6;
            this.richTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(486, 553);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 71);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add discography";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addURL
            // 
            this.addURL.Enabled = false;
            this.addURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addURL.Location = new System.Drawing.Point(664, 553);
            this.addURL.Name = "addURL";
            this.addURL.Size = new System.Drawing.Size(172, 71);
            this.addURL.TabIndex = 8;
            this.addURL.Text = "Add URL";
            this.addURL.UseVisualStyleBackColor = true;
            this.addURL.Click += new System.EventHandler(this.addURL_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(842, 553);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 71);
            this.button3.TabIndex = 8;
            this.button3.Text = "Edit Selected";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            this.Title.FillWeight = 139.0374F;
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Length
            // 
            this.Length.FillWeight = 60.96257F;
            this.Length.HeaderText = "Length";
            this.Length.MinimumWidth = 6;
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(486, 218);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 636);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.addURL);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.dgwTitles);
            this.Controls.Add(this.tBSearch);
            this.Controls.Add(this.cBAlbum);
            this.Controls.Add(this.cBArtist);
            this.Controls.Add(this.lLLink);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Discography Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwTitles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lLLink;
        private System.Windows.Forms.ComboBox cBArtist;
        private System.Windows.Forms.ComboBox cBAlbum;
        private System.Windows.Forms.TextBox tBSearch;
        private System.Windows.Forms.DataGridView dgwTitles;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addURL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
    }
}

