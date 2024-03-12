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
    /// Логика взаимодействия для AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Page
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new EquipmentList());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new EquipStatus());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.Navigate(new LoginHistory());
        }
    }
}
