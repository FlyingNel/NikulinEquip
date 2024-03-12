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
    /// Логика взаимодействия для EquipmentList.xaml
    /// </summary>
    public partial class EquipmentList : Page
    {
        private List<Equipment> allEquip; 
        public EquipmentList()
        {
            InitializeComponent();
            EquipList.ItemsSource = DbConnect.prObj.Equipment.Take(15).ToList();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                EquipList.ItemsSource = DbConnect.prObj.Equipment.Where(x => x.Name.Contains(TxbSearch.Text)).Take(15).ToList();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FrameApp.frmObj.GoBack();
        }
    }
}
