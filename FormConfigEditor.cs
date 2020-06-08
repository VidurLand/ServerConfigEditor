﻿using System;
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
        int selNum;
        public FormConfigEditor()
        {
            InitializeComponent();
        }
        #region Форма
        private void FormConfigEditor_Load(object sender, EventArgs e) // при загрузке формы
        {
            string[] boxtext = File.ReadAllLines(@"path.txt");          // загружаем данные из файла в массив
            comboBoxPath.Items.AddRange(boxtext);                       // помещаем массив в Combobox
        }
        private void FormConfigEditor_Activated(object sender, EventArgs e) // при активации формы
        {
            string ServerIP = Properties.Settings.Default.ServerIP; // IP СЕРВЕРА
            int ServerPort = Properties.Settings.Default.PortIP;    // ПОРТ СЕРВЕРА
            string PasswordRoot = Properties.Settings.Default.UserPassword; // Пароль root ( при выходе из приложения пароль сбрасывается)
            buttonOpenServerConnector.Text = ServerIP + ":" + ServerPort.ToString(); // вывод в текст кнопки адрес и порт
        }
        private void FormConfigEditor_FormClosing(object sender, FormClosingEventArgs e)//закрытие формы и выход из программы
        {
            Properties.Settings.Default.UserPassword = "";                      // присваем root пустой пароль
            Properties.Settings.Default.Save();                                 // сохраняемся
            saveComboboxList();                                                 //сохраняем массив ComboBox в файл
        }
        #endregion

        #region кнопки формы (выход, конфиг подключения)
        private void ButtonOpenServerConnector_Click(object sender, EventArgs e) // вызов формы параметров подключения
        {
            FormServerConnector FormServerConnector = new FormServerConnector();
            FormServerConnector.ShowDialog();
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserPassword = ""; // присваем root пустой пароль
            Properties.Settings.Default.Save(); // сохраняемся
            Close();
        }
        #endregion

        #region ComboBox
        private void comboBoxPath_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPath = comboBoxPath.SelectedItem.ToString();
            selNum = comboBoxPath.SelectedIndex;
        }
        #endregion

        #region Кнопки управления файлами
        private void ButtonReadFile_Click(object sender, EventArgs e)// чтение файла с сервера
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
        private void ButtonSaveFile_Click(object sender, EventArgs e)// сохранение файла на сервер
        {
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

                            if (sftp.Exists(FilePath + ".old")) // если файл old существует
                            {
                                sftp.Delete(FilePath + ".old"); //то удаляем его
                            }

                            sftp.RenameFile(FilePath, FilePath + ".old"); // переименование старого файла в .old
                            sftp.WriteAllText(FilePath, TextBoxEditor.Text); // запись нового файла 

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
        #endregion

        #region Кнопки путей к файлам
        private void ButtonAdd_Click(object sender, EventArgs e)    // добавление пути
        {
            string a = "";                                          // временная переменная

            for (int i = 0; i < comboBoxPath.Items.Count; i++)      // перебор массива ComboBox
            {
                a = GetItemText(i);                                 // вывод списка построчно
                if (comboBoxPath.Text == a)                         // если строка существует
                {
                    MessageBox.Show("Заданный путь уже существует"); // вывод сообщения
                    //continue;
                    break;                                           // прекращаем перебор значений 
                }
            }
            if (comboBoxPath.Text != a)                             // если строки не существует или она пустая
            {
                if (comboBoxPath.Text == "")
                {
                    MessageBox.Show("Нечего Добавлять!");
                    return;
                }
                comboBoxPath.Items.Add(comboBoxPath.Text);          // добавляем новую строку в список
                saveComboboxList();                                 //сохраняем листинг в файл
            }
        }
        private void ButtonEdit_Click(object sender, EventArgs e) // редактирование пути
        {
            if (comboBoxPath.Text == "")
            {
                MessageBox.Show("Нечего Редактировать!");
                return;
            }
            comboBoxPath.Items[selNum] = comboBoxPath.Text;
            saveComboboxList();
        }
        private void ButtonList_Click(object sender, EventArgs e)//получение списка доступных адресов
        {
            TextBoxEditor.Clear();
            for (int i = 0; i < comboBoxPath.Items.Count; i++)      // comboBoxPath.Items.Count - счетчик количества элементов в списке
            {
                TextBoxEditor.Text += GetItemText(i) + '\r' + '\n'; // вывод списка построчно
                comboBoxPath.Text = "";                             // на всякий случай чистим Комбо
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxPath.Text == "")
                {
                    MessageBox.Show("ОШИБКА." + "\r\n" + "Нельзя удалить НЕСУЩЕСТВУЮЩЕЕ");
                    return;
                }
                comboBoxPath.Items.RemoveAt(selNum);
                comboBoxPath.Text = "";
                saveComboboxList();
            }
            catch { }
        }
        #endregion

        #region Дополнительные функции
        private string GetItemText(int i) // получение элемента списка из массива ComboBox
        {
            return (comboBoxPath.Items[i].ToString()); // Возвращает текст элемента с помощью индекса
        }

        private void saveComboboxList() // функция сохранения массива комбо в файл
        {
            string[] boxtext = comboBoxPath.Items.OfType<string>().ToArray(); // сохраняем все элементы бокса в массив
            File.WriteAllLines(@"path.txt", boxtext); // записываем массив в файл
        }



        #endregion


    }
}
