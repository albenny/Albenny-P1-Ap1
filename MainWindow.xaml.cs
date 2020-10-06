using Albenny_P1_AP1.UI.Consultas;
using Albenny_P1_AP1.UI.Registros;
using System.Windows;

namespace Albenny_P1_AP1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void rCiudadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            rCiudades rCiudades = new rCiudades();
            rCiudades.Show();
        }

        private void cCiudadMenuItem_Click(object sender, RoutedEventArgs e)
        {
            cCiudades cCiudades = new cCiudades();
            cCiudades.Show();
        }
    }
}
