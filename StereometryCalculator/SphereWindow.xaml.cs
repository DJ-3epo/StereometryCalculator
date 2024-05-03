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
    /// Логика взаимодействия для SphereWindow.xaml
    /// </summary>
    public partial class SphereWindow : Window
    {
        public SphereWindow()
        {
            InitializeComponent();
        }

        public class Sphere
        {
            public double Radius { get; set; }

            public Sphere(double radius)
            {
                Radius = radius;
            }

            public double GetBaseArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            public double GetSurfaceArea()
            {
                return 4 * Math.PI * Math.Pow(Radius, 2);
            }

            public double GetVolume()
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
            }
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double radius;
            if (double.TryParse(RadiusTextBox.Text, out radius))
            {
                Sphere sphere = new Sphere(radius);
                SurfaceAreaTextBlock.Text = sphere.GetSurfaceArea().ToString();
                VolumeSphereTextBlock.Text = (4.0 / 3.0 * Math.PI * Math.Pow(radius, 3)).ToString(); // объем шара, ограниченного сферой
            }
            else
            {
                MessageBox.Show("Неверный формат радиуса");
            }
        }
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}