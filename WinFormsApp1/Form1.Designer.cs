namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            buttonATAK = new Button();
            buttonHEAL = new Button();
            labelPlayerName = new Label();
            labelHpPlayer = new Label();
            labelDamagePlayer = new Label();
            labelHealPlayer = new Label();
            labelEnemyName = new Label();
            labelEnemyHp = new Label();
            labelEnemyDamage = new Label();
            labelEnemyHeal = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Resource1.player;
            pictureBox1.Location = new Point(608, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 390);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Resource1.zonbie;
            pictureBox3.Location = new Point(-46, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(534, 772);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // buttonATAK
            // 
            buttonATAK.BackColor = Color.IndianRed;
            buttonATAK.Location = new Point(574, 583);
            buttonATAK.Name = "buttonATAK";
            buttonATAK.Size = new Size(134, 54);
            buttonATAK.TabIndex = 1;
            buttonATAK.Text = "АТАКААА";
            buttonATAK.UseVisualStyleBackColor = false;
            // 
            // buttonHEAL
            // 
            buttonHEAL.BackColor = SystemColors.Highlight;
            buttonHEAL.Location = new Point(902, 583);
            buttonHEAL.Name = "buttonHEAL";
            buttonHEAL.Size = new Size(136, 54);
            buttonHEAL.TabIndex = 1;
            buttonHEAL.Text = "ХИЛ";
            buttonHEAL.UseVisualStyleBackColor = false;
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 22F);
            labelPlayerName.Location = new Point(608, 0);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(97, 41);
            labelPlayerName.TabIndex = 2;
            labelPlayerName.Text = "Name";
            // 
            // labelHpPlayer
            // 
            labelHpPlayer.AutoSize = true;
            labelHpPlayer.Font = new Font("Segoe UI", 22F);
            labelHpPlayer.Location = new Point(611, 50);
            labelHpPlayer.Name = "labelHpPlayer";
            labelHpPlayer.Size = new Size(57, 41);
            labelHpPlayer.TabIndex = 2;
            labelHpPlayer.Text = "Hp";
            // 
            // labelDamagePlayer
            // 
            labelDamagePlayer.AutoSize = true;
            labelDamagePlayer.Font = new Font("Segoe UI", 22F);
            labelDamagePlayer.Location = new Point(608, 102);
            labelDamagePlayer.Name = "labelDamagePlayer";
            labelDamagePlayer.Size = new Size(129, 41);
            labelDamagePlayer.TabIndex = 2;
            labelDamagePlayer.Text = "Damage";
            // 
            // labelHealPlayer
            // 
            labelHealPlayer.AutoSize = true;
            labelHealPlayer.Font = new Font("Segoe UI", 22F);
            labelHealPlayer.Location = new Point(611, 154);
            labelHealPlayer.Name = "labelHealPlayer";
            labelHealPlayer.Size = new Size(77, 41);
            labelHealPlayer.TabIndex = 2;
            labelHealPlayer.Text = "Heal";
            // 
            // labelEnemyName
            // 
            labelEnemyName.AutoSize = true;
            labelEnemyName.Font = new Font("Segoe UI", 22F);
            labelEnemyName.Location = new Point(9, 26);
            labelEnemyName.Name = "labelEnemyName";
            labelEnemyName.Size = new Size(97, 41);
            labelEnemyName.TabIndex = 2;
            labelEnemyName.Text = "Name";
            // 
            // labelEnemyHp
            // 
            labelEnemyHp.AutoSize = true;
            labelEnemyHp.Font = new Font("Segoe UI", 22F);
            labelEnemyHp.Location = new Point(12, 79);
            labelEnemyHp.Name = "labelEnemyHp";
            labelEnemyHp.Size = new Size(57, 41);
            labelEnemyHp.TabIndex = 2;
            labelEnemyHp.Text = "Hp";
            // 
            // labelEnemyDamage
            // 
            labelEnemyDamage.AutoSize = true;
            labelEnemyDamage.Font = new Font("Segoe UI", 22F);
            labelEnemyDamage.Location = new Point(9, 130);
            labelEnemyDamage.Name = "labelEnemyDamage";
            labelEnemyDamage.Size = new Size(129, 41);
            labelEnemyDamage.TabIndex = 2;
            labelEnemyDamage.Text = "Damage";
            // 
            // labelEnemyHeal
            // 
            labelEnemyHeal.AutoSize = true;
            labelEnemyHeal.Font = new Font("Segoe UI", 22F);
            labelEnemyHeal.Location = new Point(9, 187);
            labelEnemyHeal.Name = "labelEnemyHeal";
            labelEnemyHeal.Size = new Size(77, 41);
            labelEnemyHeal.TabIndex = 2;
            labelEnemyHeal.Text = "Heal";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Resource1.images;
            ClientSize = new Size(1071, 649);
            Controls.Add(labelEnemyHeal);
            Controls.Add(labelHealPlayer);
            Controls.Add(labelEnemyDamage);
            Controls.Add(labelDamagePlayer);
            Controls.Add(labelEnemyHp);
            Controls.Add(labelEnemyName);
            Controls.Add(labelHpPlayer);
            Controls.Add(labelPlayerName);
            Controls.Add(buttonHEAL);
            Controls.Add(buttonATAK);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button buttonATAK;
        private Button buttonHEAL;
        private Label labelPlayerName;
        private Label labelHpPlayer;
        private Label labelDamagePlayer;
        private Label labelHealPlayer;
        private Label labelEnemyName;
        private Label labelEnemyHp;
        private Label labelEnemyDamage;
        private Label labelEnemyHeal;
    }
}
