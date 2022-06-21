﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace PR5
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

        private void SaveFunction()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save text file...";
            sfd.Filter = "Text files (*.txt)|*.txt";
            if (sfd.ShowDialog().HasValue)
            {
                SaveToFile(sfd.FileName, TextBox1.Text);
            }
        }

        private void SaveToFile(string fileName, string Text)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(Text);
            }
        }

        private void Btn_Save(object sender, RoutedEventArgs e)
        {
            SaveFunction();
        }

        private void Btn_Exit(object sender, RoutedEventArgs e)
        {
            string text = "Ви впевнені?";
            string title = "EXIT";

            MessageBoxResult result = MessageBox.Show(text, title, MessageBoxButton.OKCancel);
            switch (result)
            {
                case MessageBoxResult.OK:
                    Close();
                    break;

                case MessageBoxResult.Cancel:
                    break;
            }
        }


    }
}
