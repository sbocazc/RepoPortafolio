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

namespace wpf_vista
{
    /// <summary>
    /// Lógica de interacción para Crear_roles.xaml
    /// </summary>
    public partial class Crear_roles : Window
    {
        public Crear_roles()
        {
            InitializeComponent();
        }

        private void Btn_volver__Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }
    }
}
