﻿
namespace hw_pendulum1205_FRM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tBUrl = new System.Windows.Forms.TextBox();
            this.tBLength = new System.Windows.Forms.TextBox();
            this.tBId = new System.Windows.Forms.TextBox();
            this.tBTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tBUrl
            // 
            this.tBUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBUrl.Location = new System.Drawing.Point(155, 170);
            this.tBUrl.Name = "tBUrl";
            this.tBUrl.Size = new System.Drawing.Size(254, 30);
            this.tBUrl.TabIndex = 9;
            // 
            // tBLength
            // 
            this.tBLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBLength.Location = new System.Drawing.Point(155, 75);
            this.tBLength.Name = "tBLength";
            this.tBLength.Size = new System.Drawing.Size(254, 30);
            this.tBLength.TabIndex = 10;
            // 
            // tBId
            // 
            this.tBId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBId.Location = new System.Drawing.Point(155, 125);
            this.tBId.Name = "tBId";
            this.tBId.Size = new System.Drawing.Size(254, 30);
            this.tBId.TabIndex = 11;
            // 
            // tBTitle
            // 
            this.tBTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBTitle.Location = new System.Drawing.Point(155, 23);
            this.tBTitle.Name = "tBTitle";
            this.tBTitle.Size = new System.Drawing.Size(254, 30);
            this.tBTitle.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(27, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Album id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(27, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Music url";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(27, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Music length";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Music title";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 241);
            this.Controls.Add(this.tBUrl);
            this.Controls.Add(this.tBLength);
            this.Controls.Add(this.tBId);
            this.Controls.Add(this.tBTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBUrl;
        private System.Windows.Forms.TextBox tBLength;
        private System.Windows.Forms.TextBox tBId;
        private System.Windows.Forms.TextBox tBTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}