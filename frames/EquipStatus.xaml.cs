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
    /// Логика взаимодействия для EquipStatus.xaml
    /// </summary>
    public partial class EquipStatus : Page
    {
        public EquipStatus()
        {
            InitializeComponent();
            EquipList.ItemsSource = DbConnect.prObj.EquipmentStatus.Take(15).ToList();
            var statlog = DbConnect.prObj.EquipmentStatus.FirstOrDefault(x => x.Status == 1);
            string imageSource = "/Image/green.png";
            if (Convert.ToString(statlog) == "1")
            {
                imageSource = "/Image/red.png";
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                EquipList.ItemsSource = DbConnect.prObj.EquipmentStatus.Where(x => x.SerialNumber.Contains(TxbSearch.Text)).Take(15).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
