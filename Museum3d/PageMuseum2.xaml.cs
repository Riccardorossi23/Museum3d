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

namespace Museum3d
{
    /// <summary>
    /// Interaction logic for PageMuseum2.xaml
    /// </summary>
    public partial class PageMuseum2 : Window  
    {
        public PageMuseum2()
        {
            InitializeComponent();
        }

        private void Stampa_Click(object sender, RoutedEventArgs e)
        {
            if (rdbQuadro1.IsChecked == true)
            {
               string quadro = "The volkswagen, Hitler's invention for the people, to have the latter's\nsupport, Ferdinand Porsche built the economic car (volkswagen), with\nsome modifications to the engine to make the car lighter...";
                lblQuadro.Content = quadro;
            }
            if (rdbQuadro2.IsChecked == true)
            {
                string quadro2 = "The First World War was won by England and other countries,\noverturning German attacks mainly thanks to the various modifications\nmade to the planes, improving their speed thanks to Owen Bentley's\npistons, on this photo reported by the New York times,\nthe first plane to have Bentley's pistons fitted is shown.";
                lblQuadro.Content = quadro2;
            }
            if (rdbQuadro3.IsChecked == true)
            {
                string quadro3 = "In this photo reported in the New York Time, you can see Henry Ford\ntesting his car before he started selling it across America, Henry Ford\nmanaged to create his own domain in the car world, selling it cheaply.";
                lblQuadro.Content = quadro3; 
            }
            else if (rdbQuadro3.IsChecked == false && rdbQuadro2.IsChecked == false && rdbQuadro1.IsChecked == false)
            {
                MessageBox.Show("selezionare un quadro", "ERROR", MessageBoxButton.OKCancel, MessageBoxImage.Error);
            }
        }

        private void Prossima_Pagina2_Click(object sender, RoutedEventArgs e)
        {
            new PageMuseum3().ShowDialog();
        }
    }
}

    


