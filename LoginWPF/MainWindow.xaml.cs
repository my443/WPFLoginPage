﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginWPF
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

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            string usernameText = UserName.Text;
            string passwordText = PasswordBox.Password;
            LoginBorder.Visibility = Visibility.Collapsed;
            textBoxMultiLine.Visibility = Visibility.Visible;
            headingTextBlock.Visibility = Visibility.Visible;

            AddRowToTextBox("Username: " + usernameText);
            AddRowToTextBox("Password: " + passwordText);
        }

        private void AddRowToTextBox(string text)
        {
            textBoxMultiLine.Text += "\n"+text;
        }
    }
}