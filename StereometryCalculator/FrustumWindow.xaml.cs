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
    /// Логика взаимодействия для FrustumWindow.xaml
    /// </summary>
    public partial class FrustumWindow : Window
    {
        public FrustumWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получаем значения радиусов и высоты из текстовых полей
                double upperRadius = double.Parse(UpperRadiusTextBox.Text);
                double lowerRadius = double.Parse(LowerRadiusTextBox.Text);
                double height = double.Parse(HeightTextBox.Text);

                // Вычисляем площади оснований
                double upperBaseArea = Math.PI * upperRadius * upperRadius;
                double lowerBaseArea = Math.PI * lowerRadius * lowerRadius;

                // Вычисляем площадь боковой поверхности
                double sideArea = Math.PI * (upperRadius + lowerRadius) *
                                  Math.Sqrt((upperRadius - lowerRadius) * (upperRadius - lowerRadius) + height * height);

                // Общая площадь
                double totalArea = upperBaseArea + lowerBaseArea + sideArea;

                // Объем
                double volume = (Math.PI / 3) * height * (upperRadius * upperRadius + upperRadius * lowerRadius + lowerRadius * lowerRadius);

                // Выводим результаты
                UpperBaseAreaTextBlock.Text = $"{upperBaseArea:F2}";
                LowerBaseAreaTextBlock.Text = $"{lowerBaseArea:F2}";
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
