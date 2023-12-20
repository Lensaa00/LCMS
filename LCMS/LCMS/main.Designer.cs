namespace LCMS
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            startButton = new Button();
            settingsButton = new Button();
            refreshButton = new Button();
            label2 = new Label();
            profilesListBox = new ListBox();
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.BackColor = Color.FromArgb(67, 110, 191);
            startButton.FlatAppearance.BorderSize = 0;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            startButton.ForeColor = Color.White;
            startButton.Location = new Point(168, 43);
            startButton.Name = "startButton";
            startButton.Size = new Size(146, 36);
            startButton.TabIndex = 3;
            startButton.Text = "Запустить игру";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.FromArgb(67, 110, 191);
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            settingsButton.ForeColor = Color.White;
            settingsButton.Location = new Point(168, 85);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(146, 36);
            settingsButton.TabIndex = 4;
            settingsButton.Text = "Настройки";
            settingsButton.UseVisualStyleBackColor = false;
            settingsButton.Click += settingsButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(67, 110, 191);
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(14, 219);
            refreshButton.Margin = new Padding(0);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(146, 29);
            refreshButton.TabIndex = 5;
            refreshButton.Text = "Обновить";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(67, 110, 191);
            label2.Location = new Point(215, 231);
            label2.Name = "label2";
            label2.Size = new Size(99, 17);
            label2.TabIndex = 6;
            label2.Text = "t.me/lensaa00";
            // 
            // profilesListBox
            // 
            profilesListBox.BackColor = Color.FromArgb(43, 54, 77);
            profilesListBox.BorderStyle = BorderStyle.None;
            profilesListBox.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profilesListBox.ForeColor = Color.White;
            profilesListBox.FormattingEnabled = true;
            profilesListBox.ItemHeight = 17;
            profilesListBox.Location = new Point(14, 43);
            profilesListBox.Margin = new Padding(5, 10, 5, 10);
            profilesListBox.Name = "profilesListBox";
            profilesListBox.Size = new Size(146, 170);
            profilesListBox.TabIndex = 7;
            profilesListBox.SelectedIndexChanged += profilesListBox_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(43, 54, 77);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(67, 110, 191);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 30);
            panel1.TabIndex = 8;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(296, 0);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 7);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 9;
            label1.Text = "LCMS";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 45, 59);
            ClientSize = new Size(326, 257);
            Controls.Add(panel1);
            Controls.Add(profilesListBox);
            Controls.Add(label2);
            Controls.Add(refreshButton);
            Controls.Add(settingsButton);
            Controls.Add(startButton);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LCMS";
            Activated += main_Activated;
            Load += main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button startButton;
        private Button settingsButton;
        private Button refreshButton;
        private Label label2;
        private ListBox profilesListBox;
        private Panel panel1;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
    }
}