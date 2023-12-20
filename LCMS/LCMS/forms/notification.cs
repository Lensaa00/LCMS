using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LCMS.forms
{
    public partial class notification : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        public notification()
        {
            InitializeComponent();
        }

        private void notification_Load(object sender, EventArgs e)
        {

        }

        public void notif(string windowTitleT, string messageTitleT, string messageTextT)
        {
            windowTitle.Text = windowTitleT;
            messageTitle.Text = messageTitleT;
            messageText.Text = messageTextT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // Сохраняем текущую позицию мыши при нажатии
                mouseOffset = new Point(-e.X, -e.Y);
                isMouseDown = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                // Получаем новую позицию окна относительно начальной точки
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);

                // Перемещаем окно на новую позицию
                Location = mousePos;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
