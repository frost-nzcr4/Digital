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
            this.buttonUse1 = new System.Windows.Forms.Button();
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
            this.buttonEndDay = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelHP = new System.Windows.Forms.Label();
            this.buttonUse2 = new System.Windows.Forms.Button();
            this.buttonUse3 = new System.Windows.Forms.Button();
            this.label_wood = new System.Windows.Forms.Label();
            this.label_rock = new System.Windows.Forms.Label();
            this.buttonProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureRKnife = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRKnife)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUse1
            // 
            this.buttonUse1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUse1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUse1.Location = new System.Drawing.Point(412, 53);
            this.buttonUse1.Name = "buttonUse1";
            this.buttonUse1.Size = new System.Drawing.Size(186, 34);
            this.buttonUse1.TabIndex = 5;
            this.buttonUse1.Text = "Собирать ягоды";
            this.buttonUse1.UseVisualStyleBackColor = false;
            this.buttonUse1.Click += new System.EventHandler(this.buttonUse1_Click);
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
            this.buttonVer1.Text = "На равнине";
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
            this.buttonVer2.Text = "В лесу";
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
            this.buttonVer3.Text = "На болоте";
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
            this.label_eat.Location = new System.Drawing.Point(70, 32);
            this.label_eat.Name = "label_eat";
            this.label_eat.Size = new System.Drawing.Size(26, 29);
            this.label_eat.TabIndex = 12;
            this.label_eat.Text = "0";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(412, 185);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(186, 23);
            this.progressBar1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
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
            // buttonEndDay
            // 
            this.buttonEndDay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonEndDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonEndDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEndDay.Location = new System.Drawing.Point(615, 444);
            this.buttonEndDay.Name = "buttonEndDay";
            this.buttonEndDay.Size = new System.Drawing.Size(148, 34);
            this.buttonEndDay.TabIndex = 15;
            this.buttonEndDay.Text = "Закончить день";
            this.buttonEndDay.UseVisualStyleBackColor = false;
            this.buttonEndDay.Click += new System.EventHandler(this.buttonEndDay_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImage = global::Survival_on_island.Properties.Resources.hp;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(182, 64);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.BackColor = System.Drawing.Color.Transparent;
            this.labelHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHP.ForeColor = System.Drawing.Color.Yellow;
            this.labelHP.Location = new System.Drawing.Point(220, 67);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(26, 29);
            this.labelHP.TabIndex = 17;
            this.labelHP.Text = "0";
            // 
            // buttonUse2
            // 
            this.buttonUse2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUse2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUse2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUse2.Location = new System.Drawing.Point(412, 93);
            this.buttonUse2.Name = "buttonUse2";
            this.buttonUse2.Size = new System.Drawing.Size(186, 34);
            this.buttonUse2.TabIndex = 18;
            this.buttonUse2.Text = "Добывать древесину";
            this.buttonUse2.UseVisualStyleBackColor = false;
            this.buttonUse2.Click += new System.EventHandler(this.buttonUse2_Click);
            // 
            // buttonUse3
            // 
            this.buttonUse3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonUse3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUse3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUse3.Location = new System.Drawing.Point(412, 133);
            this.buttonUse3.Name = "buttonUse3";
            this.buttonUse3.Size = new System.Drawing.Size(186, 34);
            this.buttonUse3.TabIndex = 19;
            this.buttonUse3.Text = "Добывать камень";
            this.buttonUse3.UseVisualStyleBackColor = false;
            this.buttonUse3.Click += new System.EventHandler(this.buttonUse3_Click);
            // 
            // label_wood
            // 
            this.label_wood.AutoSize = true;
            this.label_wood.BackColor = System.Drawing.Color.Transparent;
            this.label_wood.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_wood.ForeColor = System.Drawing.Color.Yellow;
            this.label_wood.Location = new System.Drawing.Point(70, 70);
            this.label_wood.Name = "label_wood";
            this.label_wood.Size = new System.Drawing.Size(26, 29);
            this.label_wood.TabIndex = 20;
            this.label_wood.Text = "0";
            // 
            // label_rock
            // 
            this.label_rock.AutoSize = true;
            this.label_rock.BackColor = System.Drawing.Color.Transparent;
            this.label_rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_rock.ForeColor = System.Drawing.Color.Yellow;
            this.label_rock.Location = new System.Drawing.Point(70, 108);
            this.label_rock.Name = "label_rock";
            this.label_rock.Size = new System.Drawing.Size(26, 29);
            this.label_rock.TabIndex = 21;
            this.label_rock.Text = "0";
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.Color.Transparent;
            this.buttonProfile.BackgroundImage = global::Survival_on_island.Properties.Resources.user_01;
            this.buttonProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonProfile.Location = new System.Drawing.Point(330, 32);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(64, 64);
            this.buttonProfile.TabIndex = 22;
            this.buttonProfile.TabStop = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(584, 271);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(128, 128);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox6.Location = new System.Drawing.Point(514, 335);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 64);
            this.pictureBox6.TabIndex = 24;
            this.pictureBox6.TabStop = false;
            // 
            // pictureRKnife
            // 
            this.pictureRKnife.BackColor = System.Drawing.Color.Transparent;
            this.pictureRKnife.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureRKnife.BackgroundImage")));
            this.pictureRKnife.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureRKnife.Location = new System.Drawing.Point(46, 478);
            this.pictureRKnife.Name = "pictureRKnife";
            this.pictureRKnife.Size = new System.Drawing.Size(50, 50);
            this.pictureRKnife.TabIndex = 25;
            this.pictureRKnife.TabStop = false;
            this.pictureRKnife.Click += new System.EventHandler(this.pictureRKnife_Click);
            // 
            // Island
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.pictureRKnife);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.label_rock);
            this.Controls.Add(this.label_wood);
            this.Controls.Add(this.buttonUse3);
            this.Controls.Add(this.buttonUse2);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonEndDay);
            this.Controls.Add(this.labelOD);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_eat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonVer3);
            this.Controls.Add(this.buttonVer2);
            this.Controls.Add(this.buttonVer1);
            this.Controls.Add(this.buttonUse1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Island";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выживание на острове v. 0.2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureRKnife)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUse1;
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
        private System.Windows.Forms.Button buttonEndDay;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.Button buttonUse2;
        private System.Windows.Forms.Button buttonUse3;
        private System.Windows.Forms.Label label_wood;
        private System.Windows.Forms.Label label_rock;
        private System.Windows.Forms.PictureBox buttonProfile;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureRKnife;

    }
}