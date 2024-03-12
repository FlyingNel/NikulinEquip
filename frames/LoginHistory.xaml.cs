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

namespace equip.frames
{
    /// <summary>
    /// Логика взаимодействия для LoginHistory.xaml
    /// </summary>
    public partial class LoginHistory : Page
    {
        private List<DataLogin> allLogin;
        public LoginHistory()
        {
            InitializeComponent();
            EquipList.ItemsSource = DbConnect.prObj.DataLogin.Take(15).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                EquipList.ItemsSource = DbConnect.prObj.DataLogin.Where(x => x.UserName.Contains(TxbSearch.Text)).Take(15).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
