namespace Survival_on_island
{
    partial class Island
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Island));
            this.buttonContin = new System.Windows.Forms.Button();
            this.buttonVer1 = new System.Windows.Forms.Button();
            this.buttonVer2 = new System.Windows.Forms.Button();
            this.buttonVer3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label_eat = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelOD = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonContin
            // 
            this.buttonContin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonContin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonContin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContin.Location = new System.Drawing.Point(432, 53);
            this.buttonContin.Name = "buttonContin";
            this.buttonContin.Size = new System.Drawing.Size(148, 34);
            this.buttonContin.TabIndex = 5;
            this.buttonContin.Text = "Собирать ягоды";
            this.buttonContin.UseVisualStyleBackColor = false;
            this.buttonContin.Click += new System.EventHandler(this.buttonContin_Click);
            // 
            // buttonVer1
            // 
            this.buttonVer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVer1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVer1.ForeColor = System.Drawing.Color.Lime;
            this.buttonVer1.Location = new System.Drawing.Point(615, 53);
            this.buttonVer1.Name = "buttonVer1";
            this.buttonVer1.Size = new System.Drawing.Size(148, 34);
            this.buttonVer1.TabIndex = 6;
            this.buttonVer1.Text = "Равнина";
            this.buttonVer1.UseVisualStyleBackColor = false;
            this.buttonVer1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVer2
            // 
            this.buttonVer2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVer2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVer2.ForeColor = System.Drawing.Color.Yellow;
            this.buttonVer2.Location = new System.Drawing.Point(615, 93);
            this.buttonVer2.Name = "buttonVer2";
            this.buttonVer2.Size = new System.Drawing.Size(148, 34);
            this.buttonVer2.TabIndex = 7;
            this.buttonVer2.Text = "Лес";
            this.buttonVer2.UseVisualStyleBackColor = false;
            this.buttonVer2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonVer3
            // 
            this.buttonVer3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonVer3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonVer3.ForeColor = System.Drawing.Color.Red;
            this.buttonVer3.Location = new System.Drawing.Point(615, 133);
            this.buttonVer3.Name = "buttonVer3";
            this.buttonVer3.Size = new System.Drawing.Size(148, 34);
            this.buttonVer3.TabIndex = 8;
            this.buttonVer3.Text = "Болото";
            this.buttonVer3.UseVisualStyleBackColor = false;
            this.buttonVer3.Click += new System.EventHandler(this.buttonVer3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Survival_on_island.Properties.Resources.еда;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Survival_on_island.Properties.Resources.древесина;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(32, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::Survival_on_island.Properties.Resources.камень;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(32, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // label_eat
            // 
            this.label_eat.AutoSize = true;
            this.label_eat.BackColor = System.Drawing.Color.Transparent;
            this.label_eat.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_eat.ForeColor = System.Drawing.Color.Yellow;
            this.label_eat.Location = new System.Drawing.Point(71, 32);
            this.label_eat.Name = "label_eat";
            this.label_eat.Size = new System.Drawing.Size(26, 29);
            this.label_eat.TabIndex = 12;
            this.label_eat.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(432, 187);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(184, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelOD
            // 
            this.labelOD.AutoSize = true;
            this.labelOD.BackColor = System.Drawing.Color.Transparent;
            this.labelOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOD.ForeColor = System.Drawing.Color.Yellow;
            this.labelOD.Location = new System.Drawing.Point(177, 32);
            this.labelOD.Name = "labelOD";
            this.labelOD.Size = new System.Drawing.Size(60, 29);
            this.labelOD.TabIndex = 14;
            this.labelOD.Text = "ОД: ";
            // 
            // Island
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.labelOD);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_eat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVer3);
            this.Controls.Add(this.buttonVer2);
            this.Controls.Add(this.buttonVer1);
            this.Controls.Add(this.buttonContin);
            this.Name = "Island";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Island";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonContin;
        private System.Windows.Forms.Button buttonVer1;
        private System.Windows.Forms.Button buttonVer2;
        private System.Windows.Forms.Button buttonVer3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_eat;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelOD;

    }
}