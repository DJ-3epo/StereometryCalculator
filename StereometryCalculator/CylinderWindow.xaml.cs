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

namespace StereometryCalculator
{
    /// <summary>
    /// Логика взаимодействия для CylinderWindow.xaml
    /// </summary>
    public partial class CylinderWindow : Window
    {
        public CylinderWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем значения радиуса и высоты из текстовых полей
                double radius = double.Parse(RadiusTextBox.Text);
                double height = double.Parse(HeightTextBox.Text);

                // Вычисляем площади и объем цилиндра
                double baseArea =  radius * radius; 
                double sideArea = 2 * radius * height; 
                double totalArea = 2 * baseArea + sideArea; 
                double volume = Math.PI * radius * radius * height;

                // Выводим результаты
                BaseAreaTextBlock.Text = $"{baseArea:F2}";
                SideAreaTextBlock.Text = $"{sideArea:F2}";
                TotalAreaTextBlock.Text = $"{totalArea:F2}";
                VolumeTextBlock.Text = $"{volume:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}