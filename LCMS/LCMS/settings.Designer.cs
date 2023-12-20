namespace LCMS
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            label1 = new Label();
            gameDirectoryBox = new TextBox();
            openGameButton = new Button();
            openProfilesButton = new Button();
            profilesDirectoryBox = new TextBox();
            label2 = new Label();
            confirmButton = new Button();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(126, 17);
            label1.TabIndex = 0;
            label1.Text = "Директория игры";
            // 
            // gameDirectoryBox
            // 
            gameDirectoryBox.BackColor = Color.FromArgb(43, 54, 77);
            gameDirectoryBox.BorderStyle = BorderStyle.None;
            gameDirectoryBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            gameDirectoryBox.ForeColor = Color.White;
            gameDirectoryBox.Location = new Point(12, 63);
            gameDirectoryBox.Multiline = true;
            gameDirectoryBox.Name = "gameDirectoryBox";
            gameDirectoryBox.ReadOnly = true;
            gameDirectoryBox.Size = new Size(238, 36);
            gameDirectoryBox.TabIndex = 1;
            // 
            // openGameButton
            // 
            openGameButton.BackColor = Color.FromArgb(67, 110, 191);
            openGameButton.FlatAppearance.BorderSize = 0;
            openGameButton.FlatStyle = FlatStyle.Flat;
            openGameButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openGameButton.ForeColor = Color.White;
            openGameButton.Location = new Point(256, 63);
            openGameButton.Name = "openGameButton";
            openGameButton.Size = new Size(146, 36);
            openGameButton.TabIndex = 2;
            openGameButton.Text = "Открыть";
            openGameButton.UseVisualStyleBackColor = false;
            openGameButton.Click += openGameButton_Click;
            // 
            // openProfilesButton
            // 
            openProfilesButton.BackColor = Color.FromArgb(67, 110, 191);
            openProfilesButton.FlatAppearance.BorderSize = 0;
            openProfilesButton.FlatStyle = FlatStyle.Flat;
            openProfilesButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openProfilesButton.ForeColor = Color.White;
            openProfilesButton.Location = new Point(256, 122);
            openProfilesButton.Name = "openProfilesButton";
            openProfilesButton.Size = new Size(146, 36);
            openProfilesButton.TabIndex = 5;
            openProfilesButton.Text = "Открыть";
            openProfilesButton.UseVisualStyleBackColor = false;
            openProfilesButton.Click += openProfilesButton_Click;
            // 
            // profilesDirectoryBox
            // 
            profilesDirectoryBox.BackColor = Color.FromArgb(43, 54, 77);
            profilesDirectoryBox.BorderStyle = BorderStyle.None;
            profilesDirectoryBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilesDirectoryBox.ForeColor = Color.White;
            profilesDirectoryBox.Location = new Point(12, 122);
            profilesDirectoryBox.Multiline = true;
            profilesDirectoryBox.Name = "profilesDirectoryBox";
            profilesDirectoryBox.ReadOnly = true;
            profilesDirectoryBox.Size = new Size(238, 36);
            profilesDirectoryBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 102);
            label2.Name = "label2";
            label2.Size = new Size(161, 17);
            label2.TabIndex = 3;
            label2.Text = "Директория профилей";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.FromArgb(67, 110, 191);
            confirmButton.FlatAppearance.BorderSize = 0;
            confirmButton.FlatStyle = FlatStyle.Flat;
            confirmButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirmButton.ForeColor = Color.White;
            confirmButton.Location = new Point(12, 168);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(390, 36);
            confirmButton.TabIndex = 6;
            confirmButton.Text = "Подтвердить";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(43, 54, 77);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label3);
            panel1.ForeColor = Color.FromArgb(67, 110, 191);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 30);
            panel1.TabIndex = 14;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(386, 0);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 11;
            button1.Text = "x";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(32, 7);
            label3.Name = "label3";
            label3.Size = new Size(45, 17);
            label3.TabIndex = 9;
            label3.Text = "LCMS";
            // 
            // settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 45, 59);
            ClientSize = new Size(416, 221);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(openProfilesButton);
            Controls.Add(profilesDirectoryBox);
            Controls.Add(label2);
            Controls.Add(openGameButton);
            Controls.Add(gameDirectoryBox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки";
            FormClosed += settings_FormClosed;
            Load += settings_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox gameDirectoryBox;
        private Button openGameButton;
        private Button openProfilesButton;
        private TextBox profilesDirectoryBox;
        private Label label2;
        private Button confirmButton;
        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
    }
}