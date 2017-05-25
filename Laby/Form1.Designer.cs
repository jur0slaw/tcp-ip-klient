namespace Laby
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
            this.Adress = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.NumericUpDown();
            this.Connect = new System.Windows.Forms.Button();
            this.info_feed = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.port)).BeginInit();
            this.SuspendLayout();
            // 
            // Adress
            // 
            this.Adress.Location = new System.Drawing.Point(28, 31);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(365, 20);
            this.Adress.TabIndex = 0;
            this.Adress.Text = "Adress";
            this.Adress.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(430, 31);
            this.port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(341, 20);
            this.port.TabIndex = 1;
            this.port.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(221, 436);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(370, 23);
            this.Connect.TabIndex = 3;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // info_feed
            // 
            this.info_feed.FormattingEnabled = true;
            this.info_feed.Location = new System.Drawing.Point(28, 71);
            this.info_feed.Name = "info_feed";
            this.info_feed.Size = new System.Drawing.Size(743, 342);
            this.info_feed.TabIndex = 4;
            this.info_feed.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 483);
            this.Controls.Add(this.info_feed);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.port);
            this.Controls.Add(this.Adress);
            this.Name = "Form1";
            this.Text = "Tcp Klient";
            ((System.ComponentModel.ISupportInitialize)(this.port)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Adress;
        private System.Windows.Forms.NumericUpDown port;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.ListBox info_feed;
    }
}

