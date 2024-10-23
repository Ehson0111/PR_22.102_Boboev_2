using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace PR_22._102_Boboev_2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string s = text1.Text;
                bool dd= Regex.IsMatch(s, @"^[a-zA-Z-' ']+$");
                if (dd)
                {


                    s = s.Trim();
                    char[] chars = s.ToCharArray();
                    char[] chars2 = new char[] { 'A', 'E', 'I', 'O', 'U', 'Y', 'a', 'e', 'i', 'o', 'u' };
                    int n = 0;

                    for (int i = 0; i < chars.Length; i++)
                    {

                        for (int j = 0; j < chars2.Length; j++)
                        {
                            if (chars[i] == chars2[j])
                            {
                                n++;
                            }
                        }
                    }
                    count.Text = Convert.ToString(n);
                    string[] sq = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int index = 0;
                    int max = sq[0].Length;
                    string ws = sq[0];
                    foreach (var item in sq)
                    {
                        if (item.Length > max)
                        {
                            max = item.Length;
                            ws = item;

                        }
                    }
                    result.Text = ws;


                }
                else
                {
                    MessageBox.Show($"Вводите только английские буквы : ", "Ошибка:", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка {ex}", "Ошибка :", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }
         
         

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
