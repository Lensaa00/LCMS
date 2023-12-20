namespace LCMS.forms
{
    partial class notification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(notification));
            panel1 = new Panel();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            windowTitle = new Label();
            messageTitle = new Label();
            messageText = new Label();
            accept = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(43, 54, 77);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(windowTitle);
            panel1.ForeColor = Color.FromArgb(67, 110, 191);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 30);
            panel1.TabIndex = 9;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(292, 0);
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
            // windowTitle
            // 
            windowTitle.AutoSize = true;
            windowTitle.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            windowTitle.ForeColor = Color.White;
            windowTitle.Location = new Point(32, 7);
            windowTitle.Name = "windowTitle";
            windowTitle.Size = new Size(88, 17);
            windowTitle.TabIndex = 9;
            windowTitle.Text = "windowTitle";
            // 
            // messageTitle
            // 
            messageTitle.AutoSize = true;
            messageTitle.Font = new Font("Arial Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            messageTitle.ForeColor = Color.White;
            messageTitle.Location = new Point(12, 43);
            messageTitle.Name = "messageTitle";
            messageTitle.Size = new Size(121, 22);
            messageTitle.TabIndex = 12;
            messageTitle.Text = "messageTitle";
            // 
            // messageText
            // 
            messageText.AutoSize = true;
            messageText.BackColor = Color.FromArgb(38, 45, 59);
            messageText.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            messageText.ForeColor = Color.FromArgb(108, 115, 129);
            messageText.Location = new Point(13, 65);
            messageText.Name = "messageText";
            messageText.Size = new Size(81, 15);
            messageText.TabIndex = 13;
            messageText.Text = "messageText";
            // 
            // accept
            // 
            accept.BackColor = Color.FromArgb(67, 110, 191);
            accept.FlatAppearance.BorderSize = 0;
            accept.FlatStyle = FlatStyle.Flat;
            accept.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            accept.ForeColor = Color.White;
            accept.Location = new Point(9, 182);
            accept.Margin = new Padding(0);
            accept.Name = "accept";
            accept.Size = new Size(304, 29);
            accept.TabIndex = 14;
            accept.Text = "Принять";
            accept.UseVisualStyleBackColor = false;
            accept.Click += accept_Click;
            // 
            // notification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(38, 45, 59);
            ClientSize = new Size(322, 220);
            Controls.Add(accept);
            Controls.Add(messageText);
            Controls.Add(messageTitle);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "notification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "notification";
            Load += notification_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label windowTitle;
        private Label messageTitle;
        private Label messageText;
        private Button accept;
    }
}