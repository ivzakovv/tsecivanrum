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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            WpfApp2.aeroDataSet aeroDataSet = ((WpfApp2.aeroDataSet)(this.FindResource("aeroDataSet")));
            // Загрузить данные в таблицу aero. Можно изменить этот код как требуется.
            WpfApp2.aeroDataSetTableAdapters.aeroTableAdapter aeroDataSetaeroTableAdapter = new WpfApp2.aeroDataSetTableAdapters.aeroTableAdapter();
            aeroDataSetaeroTableAdapter.Fill(aeroDataSet.aero);
            System.Windows.Data.CollectionViewSource aeroViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("aeroViewSource")));
            aeroViewSource.View.MoveCurrentToFirst();
        }

        private void AeroDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
