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

namespace ProyectoFinal
{
    /// <summary>
    /// Lógica de interacción para CFTema1.xaml
    /// </summary>
    public partial class CFTema1 : Page
    {
        public CFTema1()
        {
            InitializeComponent();
            Application.Current.MainWindow.Height = 550;
        }

        private void teoria_Click(object sender, RoutedEventArgs e)
        {
            CFTeoria1 w = new CFTeoria1();
            w.Show();
        }

        private void Siguiente_Click(object sender, RoutedEventArgs e)
        {
            NavigationService next = NavigationService.GetNavigationService(this);
            next.Navigate(new Uri("CFTema2.xaml", UriKind.RelativeOrAbsolute));
        }

        private void puntuacion_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ejercicios_Click(object sender, RoutedEventArgs e)
        {
            CFEjercicios1 w = new CFEjercicios1();
            w.Show();
        }
    }
}
