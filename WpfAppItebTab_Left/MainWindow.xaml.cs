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

namespace WpfAppItebTab_Left
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


        private void addTabItemFigur_Click(object sender, RoutedEventArgs e)
        {
            int count = tabControlFigur.Items.Count;
            count++;
            TabItem newItem = new TabItem();
            newItem.Header = $"Шаблон{count}";
            //Заполняем контент
            newItem.Content = "text";
            tabControlFigur.Items.Add(newItem);
        }
    }
}
