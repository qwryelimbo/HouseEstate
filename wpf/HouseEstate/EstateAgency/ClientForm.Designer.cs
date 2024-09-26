namespace MainClient
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.Catalog = new System.Windows.Forms.Button();
            this.flowLayoutPanelProperties = new System.Windows.Forms.FlowLayoutPanel();
            this.profile = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Catalog
            // 
            this.Catalog.BackColor = System.Drawing.Color.Transparent;
            this.Catalog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Catalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Catalog.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Catalog.Location = new System.Drawing.Point(469, 29);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(75, 23);
            this.Catalog.TabIndex = 0;
            this.Catalog.Text = "Каталог";
            this.Catalog.UseVisualStyleBackColor = false;
            this.Catalog.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // flowLayoutPanelProperties
            // 
            this.flowLayoutPanelProperties.AutoScroll = true;
            this.flowLayoutPanelProperties.Location = new System.Drawing.Point(165, 202);
            this.flowLayoutPanelProperties.Name = "flowLayoutPanelProperties";
            this.flowLayoutPanelProperties.Size = new System.Drawing.Size(685, 455);
            this.flowLayoutPanelProperties.TabIndex = 1;
            // 
            // profile
            // 
            this.profile.BackColor = System.Drawing.Color.Transparent;
            this.profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profile.Location = new System.Drawing.Point(689, 29);
            this.profile.Name = "profile";
            this.profile.Size = new System.Drawing.Size(75, 23);
            this.profile.TabIndex = 2;
            this.profile.Text = "Профиль";
            this.profile.UseVisualStyleBackColor = false;
            this.profile.Click += new System.EventHandler(this.profile_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(736, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1005, 701);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(936, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.profile);
            this.Controls.Add(this.flowLayoutPanelProperties);
            this.Controls.Add(this.Catalog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Catalog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProperties;
        private System.Windows.Forms.Button profile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}