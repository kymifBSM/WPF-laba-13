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

namespace WPF_laba13
{
    public partial class task2 : Window
    {
        public task2()
        {
            InitializeComponent();

            List<Albums> albumsList = new List<Albums>
            {
                new Albums{ID = 1, Vocalist = "Michael Jackson", Album = "Thriller", Year = 1982},
                new Albums{ID = 2, Vocalist = "Brian Johnson", Album = "Back in Black", Year = 1980},
                new Albums{ID = 3, Vocalist = "Barry Gibb", Album = "Saturday Night Fever", Year = 1977},
                new Albums{ID = 4, Vocalist = "Pink Floyd", Album = "The Dark Side of the Moon", Year = 1973}
            };

            albumsGrid.ItemsSource = albumsList;
        }

        private void Change(object sender, MouseButtonEventArgs e)
        {
            if ( albumsGrid.SelectedItem != null)
            {
                Albums selectedAlbum = (Albums)albumsGrid.SelectedItem;
                MessageBox.Show($"ID: {selectedAlbum.ID}\nVocalist: {selectedAlbum.Vocalist}\nAlbum: {selectedAlbum.Album}\nYear: {selectedAlbum.Year}");
                albumsGrid.MouseDoubleClick += Change;
            }
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Task3(object sendr, RoutedEventArgs e)
        {
            task3 t3 = new();
            t3.Show();
            Close();
        }

        private void Task1(object sendr, RoutedEventArgs e)
        {
            MainWindow t1 = new();
            t1.Show();
            Close();
        }
    }
}
