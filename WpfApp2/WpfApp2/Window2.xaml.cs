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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (logzareg.Text.Length > 0)
            {
                if (parolzareg.Text.Length > 0)
                {
                    if (povtorzaregpar.Text.Length > 0) {
                        if (povtorzaregpar.Text == parolzareg.Text)
                        {
                            MainWindow zllp = new MainWindow();
                            zllp.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Неверный повтор пароля", "ошибка ", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Повторите пароль", "ошибка ", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Введите пароль", "ошибка ", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите логин", "ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
