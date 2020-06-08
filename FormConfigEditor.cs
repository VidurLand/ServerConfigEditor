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
using Renci.SshNet.Common;
using System.Net.Sockets;

namespace ServerConfigEditor
{
    public partial class FormConfigEditor : Form
    {
        #region Область переменных

        string ServerIP;            // ip сервера
        int ServerPort;             // порт сервера (по умолчанию 22)
        string PasswordRoot;        // пароль пользователя root

        #endregion
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

            //ButtonOpenServerConnector_Click(sender, e); // вызов формы параметров подключения (можно раскомментировать
            // тогда при запуске будет сразу вызываться форма подключения)
        }
        private void FormConfigEditor_Activated(object sender, EventArgs e) // при активации формы
        {
            ServerIP = Properties.Settings.Default.ServerIP; // IP СЕРВЕРА
            ServerPort = Properties.Settings.Default.PortIP;    // ПОРТ СЕРВЕРА
            PasswordRoot = Properties.Settings.Default.UserPassword; // Пароль root ( при выходе из приложения пароль сбрасывается)
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
        private void ComboBoxPath_SelectedIndexChanged(object sender, EventArgs e) // изменение в комбобоксе
        {
            selNum = comboBoxPath.SelectedIndex; // номер выбранной строки из списка путей

            TextBoxEditor.Clear();                                              // очистка бокса


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
                            TextBoxEditor.Select();     // меняем фокус на поле редактора
                        }
                    }
                }
                catch (SshAuthenticationException) // ошибка аутентификации (доступ запрещен (пароль))
                {
                    MessageBox.Show("Доступ запрещен." + "\r\n" + "Введите пароль!");
                    ButtonOpenServerConnector_Click(sender, e);
                }

                catch (ArgumentException) // ошибка в адреме
                {
                    MessageBox.Show("Введен неопределенный адрес." + "\r\n" + "Введите HostName или IP сервера!");
                    ButtonOpenServerConnector_Click(sender, e);
                }

                catch (SocketException) // неизвестный хост
                {
                    MessageBox.Show("Неизвестный Хост." + "\r\n" + "Введите правильный HostName или IP сервера!");
                    ButtonOpenServerConnector_Click(sender, e);
                }

                catch (SftpPathNotFoundException)
                {
                    MessageBox.Show("Нет такого файла!");    // вывод описания ошибки подключения
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

        #region Кнопки управления файлами
        private void ButtonSaveFile_Click(object sender, EventArgs e)// сохранение файла на сервер
        {

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
                            if (!sftp.Exists(FilePath)) // если файл на пути не существует, 
                            {
                                sftp.Create(FilePath);  //то создаем его

                            }
                            else                                                // если файл существует
                            {
                                sftp.RenameFile(FilePath, FilePath + ".old"); // то переименовываем  файл в .old

                            }
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
