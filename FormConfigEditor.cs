using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Security.Cryptography;
using System.IO;

namespace ServerConfigEditor
{
    public partial class FormConfigEditor : Form
    {
        public FormConfigEditor()
        {
            InitializeComponent();
            TextBoxEditor.SelectionTabs = new int[] { 15, 30, 45, 60 }; //установка размера табуляции в окне редактора
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPassword = ""; // присваем root пустой пароль
            Properties.Settings.Default.Save(); // сохраняемся
            Close();
        }

        private void FormConfigEditor_Load(object sender, EventArgs e)
        {
            string[] text = File.ReadAllLines(@"path.txt"); // загружаем данные из файла в массив
            comboBoxPath.Items.AddRange(text); // помещаем массив в Combobox
        }

        private void buttonOpenServerConnector_Click(object sender, EventArgs e) // вызов формы параметров подключения
        {
            FormServerConnector FormServerConnector = new FormServerConnector();
            FormServerConnector.ShowDialog();
        }

        private void FormConfigEditor_Activated(object sender, EventArgs e)
        {
            string ServerIP = Properties.Settings.Default.ServerIP; // IP СЕРВЕРА
            int ServerPort = Properties.Settings.Default.PortIP;    // ПОРТ СЕРВЕРА
            string PasswordRoot = Properties.Settings.Default.UserPassword; // Пароль root ( при выходе из приложения пароль сбрасывается)
            buttonOpenServerConnector.Text = ServerIP + ":" + ServerPort.ToString(); // вывод в текст кнопки адрес и порт
        }

        private void buttonReadFile_Click(object sender, EventArgs e)// получение файла с сервера
        {
            TextBoxEditor.Clear();                                              // очистка бокса
            string ServerIP = Properties.Settings.Default.ServerIP;         // IP сервера
            int ServerPort = Properties.Settings.Default.PortIP;            //  Порт 
            string PasswordRoot = Properties.Settings.Default.UserPassword; // Пароль пользователя root
            buttonOpenServerConnector.Text = ServerIP + ":" + ServerPort.ToString(); // ??? (надо ли? )вывод в метку адрес и порт

            using (var sftp = new SftpClient(ServerIP, ServerPort, "root", PasswordRoot)) //переменная для подключения
            {
                try
                {
                    sftp.Connect();         // попытка подключения
                    if (sftp.IsConnected)   // если подключились
                    {
                        if (comboBoxPath.SelectedItem == null)  // проверяем поле ввода на нулевое значение
                        {
                            MessageBox.Show("Выберите существующий объект");    // если поле нулевое, то вывод сообщения
                        }
                        else
                        {
                            string FilePath = comboBoxPath.SelectedItem.ToString(); // преобразуем выбранный пункт в стринг                       
                            TextBoxEditor.Text = sftp.ReadAllText(FilePath);        // вывод содержимого в окно редактора
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);    // вывод описания ошибки подключения
                }
                finally
                {
                    sftp.Disconnect();              // отключаемся от сервера
                }
            }
        }

        private void ButtonList_Click(object sender, EventArgs e)//получениt списка доступных адресов
        {
            TextBoxEditor.Clear();
            for (int i = 0; i < comboBoxPath.Items.Count; i++)      // comboBoxPath.Items.Count - счетчик количества элементов в списке
            {
                TextBoxEditor.Text += GetItemText(i) + '\r' + '\n'; // вывод списка построчно
            }
        }
        private string GetItemText(int i) // получение элемента списка из массива ComboBox
        {
            return (comboBoxPath.Items[i].ToString()); // Возвращает текст элемента с помощью индекса
        }

        private void FormConfigEditor_FormClosing(object sender, FormClosingEventArgs e)//закрытие формы и выход из программы
        {
            Properties.Settings.Default.UserPassword = "";                      // присваем root пустой пароль
            Properties.Settings.Default.Save();                                 // сохраняемся
        }
    }
}
