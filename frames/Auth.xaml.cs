using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using equip.frames;

namespace equip.frames
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            var datalog = DbConnect.prObj.Users.FirstOrDefault(x => x.Login == TxbLogin.Text && x.Password == TxbPassword.Password);
            string log = "Провал";
            if (datalog == null)
            {
                log = "Провал";
            }
            else
            {
                log = "Успех";
            }
            DataLogin logObj = new DataLogin()
            {
                UserName = TxbLogin.Text,
                Status = log,
                Data = DateTime.Now
            };
            DbConnect.prObj.DataLogin.Add(logObj);
            DbConnect.prObj.SaveChanges();

            try
            {
                var user = DbConnect.prObj.Users.FirstOrDefault(x => x.Login == TxbLogin.Text && x.Password == TxbPassword.Password);
                if (user == null)
                {
                    MessageBox.Show("Такой пользователь не найден!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                }
                else
                {
                    switch (user.Role.Id)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте, Администратор " + user.Name + "!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new AdminMenu());
                            break;
                        case 2:
                            MessageBox.Show("Здравствуйте, работник " + user.Name + "!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new EquipmentList());
                            break;
                        case 3:
                            MessageBox.Show("Здравствуйте, Руководитель " + user.Name + "!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                            FrameApp.frmObj.Navigate(new EquipmentList());
                            break;
                        default:
                            MessageBox.Show("Такой пользователь не найден!",
                               "Уведомление",
                               MessageBoxButton.OK,
                               MessageBoxImage.Information);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Критический сбой в работе предложения: " + ex.Message.ToString(),
                                "Уведомление",
                                MessageBoxButton.OK,
                                MessageBoxImage.Warning);
            }
        }
    }
}
