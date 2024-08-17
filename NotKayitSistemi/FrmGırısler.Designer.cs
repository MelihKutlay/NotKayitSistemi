namespace NotKayitSistemi
{
    partial class FrmGırısler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGırısler));
            this.btnogrencigiris = new System.Windows.Forms.Button();
            this.btnogretmengiris = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnogrencigiris
            // 
            this.btnogrencigiris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnogrencigiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnogrencigiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnogrencigiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnogrencigiris.Image = ((System.Drawing.Image)(resources.GetObject("btnogrencigiris.Image")));
            this.btnogrencigiris.Location = new System.Drawing.Point(12, 39);
            this.btnogrencigiris.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnogrencigiris.Name = "btnogrencigiris";
            this.btnogrencigiris.Size = new System.Drawing.Size(294, 213);
            this.btnogrencigiris.TabIndex = 0;
            this.btnogrencigiris.Text = "ÖĞRENCİ GİRİŞ";
            this.btnogrencigiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnogrencigiris.UseVisualStyleBackColor = false;
            this.btnogrencigiris.Click += new System.EventHandler(this.btnogrencigiris_Click);
            // 
            // btnogretmengiris
            // 
            this.btnogretmengiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnogretmengiris.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnogretmengiris.Image = ((System.Drawing.Image)(resources.GetObject("btnogretmengiris.Image")));
            this.btnogretmengiris.Location = new System.Drawing.Point(316, 39);
            this.btnogretmengiris.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnogretmengiris.Name = "btnogretmengiris";
            this.btnogretmengiris.Size = new System.Drawing.Size(294, 213);
            this.btnogretmengiris.TabIndex = 1;
            this.btnogretmengiris.Text = "ÖĞRETMEN GİRİŞ";
            this.btnogretmengiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnogretmengiris.UseVisualStyleBackColor = false;
            this.btnogretmengiris.Click += new System.EventHandler(this.btnogretmengiris_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btncikis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncikis.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncikis.Location = new System.Drawing.Point(550, 12);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(62, 25);
            this.btncikis.TabIndex = 6;
            this.btncikis.Text = "ÇIKIŞ";
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // FrmGırısler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(624, 263);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnogretmengiris);
            this.Controls.Add(this.btnogrencigiris);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmGırısler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGırısler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnogrencigiris;
        private System.Windows.Forms.Button btnogretmengiris;
        private System.Windows.Forms.Button btncikis;
    }
}