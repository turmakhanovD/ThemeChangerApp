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

namespace TelegramThemeApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ThirdDialogClicked(object sender, MouseButtonEventArgs e)
        {
            groupBox.Content = "Привет, сходим в ресторан за твой счет?";
        }

        private void SecondDialogClicked(object sender, MouseButtonEventArgs e)
        {
            groupBox.Content = "Чувак косарь в долг дашь?";
        }

        private void FirstDialogClicked(object sender, MouseButtonEventArgs e)
        {
            groupBox.Content = "Привет, ты как?";
            
        }

        private void DarkThemeTrue(object sender, RoutedEventArgs e)
        {
                var uri = new Uri("DarkTheme" + ".xaml", UriKind.Relative);

                ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

                Application.Current.Resources.Clear();

                Application.Current.Resources.MergedDictionaries.Add(resourceDict);
            
        }

        private void DefaultThemeChecked(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("DefaultTheme" + ".xaml", UriKind.Relative);

            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;

            Application.Current.Resources.Clear();

            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
