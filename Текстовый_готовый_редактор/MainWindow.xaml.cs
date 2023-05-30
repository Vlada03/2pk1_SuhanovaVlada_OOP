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
using System.IO;
using Microsoft.Win32;

namespace Текстовый_редактор
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

        }

        private void Полужирный_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Курсив_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Подчеркнутый_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Закрыть_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Новый(object sender, RoutedEventArgs e)
        {
            TextBox.Clear();
        }

        private void Открыть(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
                TextBox.Text = File.ReadAllText(openFileDialog.FileName);
        }

        private void Сохранить(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
                File.WriteAllText(saveFileDialog.FileName, TextBox.Text);
        }
    }
}
