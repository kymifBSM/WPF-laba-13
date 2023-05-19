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

namespace WPF_laba13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {

            if (TW.SelectedItem != null)
            {
                var par = ((TreeViewItem)TW.SelectedItem).Parent as TreeViewItem;

                if (par != null)
                {
                    par.Items.Remove(TW.SelectedItem);
                }
                else
                {
                    ((TreeViewItem)TW.SelectedItem).Items.Clear();
                    TW.Items.Remove(TW.SelectedItem);
                }

            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Task2(object sendr, RoutedEventArgs e)
        {
            task2 t2 = new task2();
            t2.Show();
            Close();
        }
    }
}
