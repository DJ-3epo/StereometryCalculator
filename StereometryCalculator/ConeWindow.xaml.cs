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
    /// Логика взаимодействия для ConeWindow.xaml
    /// </summary>
    public partial class ConeWindow : Window
    {
       public ConeWindow()
        {
            InitializeComponent();
        }
        public class Cone
        {
            public double Radius { get; set; }
            public double Height { get; set; }

            public Cone(double radius, double height)
            {
                Radius = radius;
                Height = height;
            }

            public double GetBaseArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }

            public double GetSideArea()
            {
                return Math.PI * Radius * Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Radius, 2));
            }

            public double GetTotalArea()
            {
                return GetBaseArea() + GetSideArea();
            }

            public double GetVolume()
            {
                return (Math.PI * Math.Pow(Radius, 2) * Height) / 3;
            }

        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            double radius, height;
            if (double.TryParse(RadiusTextBox.Text, out radius) && double.TryParse(HeightTextBox.Text, out height))
            {
                Cone cone = new Cone(radius, height);
                BaseAreaTextBlock.Text = cone.GetBaseArea().ToString();
                SideAreaTextBlock.Text = cone.GetSideArea().ToString();
                TotalAreaTextBlock.Text = cone.GetTotalArea().ToString();
                VolumeTextBlock.Text = cone.GetVolume().ToString();
            }
            else
            {
                MessageBox.Show("Неверный формат ввода");
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}