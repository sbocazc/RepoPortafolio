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
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }

        private void Btn_crear_usuario_Click(object sender, RoutedEventArgs e)
        {
            Crear_usuario c = new Crear_usuario();
            c.Show();
            this.Close();
        }

        private void Btn_crear_rol_Click(object sender, RoutedEventArgs e)
        {
            Crear_roles rol = new Crear_roles();
            rol.Show();
            this.Close();
        }

        private void Btn_crear_flujo_tarea_Click(object sender, RoutedEventArgs e)
        {
            crear_flujo_tarea cf = new crear_flujo_tarea();
            cf.Show();
            Close();
        }

        private void btn_empresa_Click(object sender, RoutedEventArgs e)
        {
            agregar_empresa agr = new agregar_empresa();
            agr.Show();
            Close();
        }
    }
}
