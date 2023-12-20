using LCMS.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LCMS
{
    public partial class settings : Form
    {
        string gamePath = "";
        string profilesPath = "";

        private Point mouseOffset;
        private bool isMouseDown = false;

        public settings()
        {
            InitializeComponent();
        }

        private void openGameButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Устанавливаем фильтр для файлов
            openFileDialog1.Filter = "Lethal Company.exe|";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Если файл выбран, открываем его
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    gameDirectoryBox.Text = filePath;
                    gamePath = filePath;

                    Console.WriteLine($"Game path saved: " + gamePath);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening game path: " + ex.Message);
                }
            }
        }

        private void openProfilesButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();

            folderBrowserDialog1.SelectedPath = $@"C:\Users\{Environment.UserName}\AppData\Roaming\";


            if (profilesPath != "")
            {
                folderBrowserDialog1.SelectedPath = profilesPath;
            }

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedFolder = folderBrowserDialog1.SelectedPath;
                    profilesDirectoryBox.Text = selectedFolder;
                    profilesPath = selectedFolder;

                    Console.WriteLine("Profiles path saved: " + selectedFolder);
                    notification form = new notification();
                    form.notif("Информация", "Profiles path saved: " + selectedFolder, "Profiles path saved: " + selectedFolder);
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error opening profiles path: " + ex.Message);
                }
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (gamePath != "" && profilesPath != "")
            {
                // Создание XML-документа
                XmlDocument xmlDoc = new XmlDocument();

                // Создание корневого элемента
                XmlElement root = xmlDoc.CreateElement("Paths");
                xmlDoc.AppendChild(root);

                // Создание элементов для переменных и их значений
                XmlElement gamePathElement = xmlDoc.CreateElement("GamePath");
                gamePathElement.InnerText = gamePath;
                root.AppendChild(gamePathElement);

                XmlElement profilesPathElement = xmlDoc.CreateElement("ProfilesPath");
                profilesPathElement.InnerText = profilesPath;
                root.AppendChild(profilesPathElement);

                try
                {
                    // Сохранение XML-документа в файл
                    xmlDoc.Save("paths.xml");
                    notification form = new notification();
                    form.notif("Информация", "Paths saved to paths.xml", "Paths saved to paths.xml");
                    form.ShowDialog();
                }
                catch (Exception ex)
                {
                    notification form = new notification();
                    form.notif("Ошибка", "Paths saving error: " + ex.Message, "Paths saving error: " + ex.Message);
                    form.ShowDialog();
                }
            }
            else
            {
                notification form = new notification();
                form.notif("Ошибка", "Выбраны не все пути", "Выбраны не все пути");
                form.ShowDialog();
            }

            this.Close();
        }

        private void settings_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void settings_Load(object sender, EventArgs e)
        {
            readConfig();
            gameDirectoryBox.Text = gamePath;
            profilesDirectoryBox.Text = profilesPath;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void readConfig()
        {
            try
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
            catch
            {
                Console.WriteLine("");
            }
        }
    }
}
