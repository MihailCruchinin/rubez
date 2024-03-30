using _21._102_Kruchinin_3.Entity;
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

namespace _21._102_Kruchinin_3
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

        private void FindButton_Click(object sender, RoutedEventArgs e)
        {
            try 
            {
            Entities entities = new Entities();
            Discipline[] FindResult = entities.Discipline.Where(x => x.Title.Contains(FindText.Text)).ToArray();
                if (FindResult.Length == 0)
                { MessageBox.Show("Таких обьектов не существует", "Ничего не найдено"); }
                if (_3.IsChecked==true)
                {
                    FindResult.OrderBy(x => x.Title);
                }
                if (_2.IsChecked == true) 
                {
                    FindResult.OrderByDescending(x => x.Title);
                }

            LoadData.DataContext = FindResult;
            }
            catch { MessageBox.Show("Произошла ошибка", "Ошибка"); }
        }
    }
}
