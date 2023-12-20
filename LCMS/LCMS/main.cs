using LCMS.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LCMS
{
    public partial class main : Form
    {
        string gamePath = "";
        string profilesPath = "";
        string selectedProfile = "";

        private Point mouseOffset;
        private bool isMouseDown = false;

        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {
            if (!File.Exists("paths.xml"))
            {
                settings form = new settings();
                if (form.ShowDialog() == DialogResult)
                {
                    readConfig();
                    loadProfiles(profilesPath);
                }
            }
            else
            {
                readConfig();
                loadProfiles(profilesPath);
            }
        }

        public void readConfig()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("paths.xml");

            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Paths");

            foreach (XmlNode node in nodeList)
            {
                gamePath = node.SelectSingleNode("GamePath").InnerText;
                profilesPath = node.SelectSingleNode("ProfilesPath").InnerText;
            }

            Console.WriteLine(gamePath);
            Console.WriteLine(profilesPath);
        }

        public void loadProfiles(string folderPath)
        {
            profilesListBox.Items.Clear();

            if (Directory.Exists(folderPath))
            {
                string[] directories = Directory.GetDirectories(folderPath);

                foreach (string directory in directories)
                {
                    // Получаем только имя папки, без пути к ней
                    string folderName = new DirectoryInfo(directory).Name;

                    // Добавляем имя папки в ListBox
                    profilesListBox.Items.Add(folderName);
                }
            }
            else
            {
                notification form = new notification();
                form.notif("Ошибка", "", "Указанный путь не существует.");
                form.ShowDialog();
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            settings form = new settings();
            form.ShowDialog();
        }

        private void profilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedProfile = profilesListBox.SelectedItems[0].ToString();
            }
            catch (Exception ex)
            {
                notification form = new notification();
                form.notif("Ошибка", ex.Message, ex.Message);
                form.ShowDialog();
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            readConfig();
            if (selectedProfile != "")
            {
                string path = $"{profilesPath}/{selectedProfile}/BepInEx/core/BepInEx.Preloader.dll";

                if (File.Exists(gamePath) && File.Exists(path))
                {
                    string arguments = $"--doorstop-enable true --doorstop-target \"{path}\"";

                    ProcessStartInfo startInfo = new ProcessStartInfo();
                    startInfo.FileName = gamePath;
                    startInfo.Arguments = arguments;

                    Process.Start(startInfo);
                }
                else
                {
                    notification form = new notification();
                    form.notif("Ошибка", "", "Не удалось найти Lethal Company.exe");
                    form.ShowDialog();
                }
            }
            else
            {
                notification form = new notification();
                form.notif("Ошибка", "Не выбран профиль для запуска", "Не выбран профиль для запуска");
                form.ShowDialog();
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            readConfig();
            loadProfiles(profilesPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void main_Activated(object sender, EventArgs e)
        {

        }
    }
}
