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

namespace StereometryCalculator
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

        private void OpenShapeWindow(Window shapeWindow)
        {
            shapeWindow.Owner = this;
            shapeWindow.Closed += (sender, e) => this.Show();
            shapeWindow.Show();
            this.Hide();
        }

        private void SphereButton_Click(object sender, RoutedEventArgs e)
        {
            // Открыть окно сферы
            OpenShapeWindow(new SphereWindow());
        }

        private void ConeButton_Click(object sender, RoutedEventArgs e)
        {
            // Открыть окно конуса
            OpenShapeWindow(new ConeWindow());
        }

        private void TruncatedConeButton_Click(object sender, RoutedEventArgs e)
        {
            // Открыть окно усеченного конуса
            OpenShapeWindow(new FrustumWindow());
        }

        private void CylinderButton_Click(object sender, RoutedEventArgs e)
        {
            // Открыть окно цилиндра
            OpenShapeWindow(new CylinderWindow());
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрыть приложение
            this.Close();
        }
    }
}