﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace WpfOfficeTheme
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Users = new List<User>
            {
                new User {Id = 1, Name = "John", PhoneNumber = 777666880},
                new User {Id = 2, Name = "Jane", PhoneNumber = 777666881},
                new User {Id = 3, Name = "Jimmy", PhoneNumber = 777666882},
                new User {Id = 4, Name = "Mary", PhoneNumber = 777666883},
                new User {Id = 5, Name = "Simon", PhoneNumber = 777666884},
                new User {Id = 6, Name = "Ann", PhoneNumber = 777666885},
                new User {Id = 1, Name = "John", PhoneNumber = 777666880},
                new User {Id = 2, Name = "Jane", PhoneNumber = 777666881},
                new User {Id = 3, Name = "Jimmy", PhoneNumber = 777666882},
                new User {Id = 4, Name = "Mary", PhoneNumber = 777666883},
                new User {Id = 5, Name = "Simon", PhoneNumber = 777666884},
                new User {Id = 6, Name = "Ann", PhoneNumber = 777666885}
            };
            ListView.ItemsSource = Users;
            DataGrid.ItemsSource = Users;
            DataGrid1.ItemsSource = Users;
        }

        public List<User> Users { get; set; }

        public override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            var accentBrush = TryFindResource("AccentColorBrush") as SolidColorBrush;
            if (accentBrush != null) accentBrush.Color.CreateAccentColors();
        }

        private void Ribbon_Click(object sender, RoutedEventArgs e)
        {
            SubWindow sub = new SubWindow();
            sub.Show();
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
    }
}