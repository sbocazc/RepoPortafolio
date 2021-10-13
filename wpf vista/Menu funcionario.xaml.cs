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
    /// Lógica de interacción para Menu_funcionario.xaml
    /// </summary>
    public partial class Menu_funcionario : Window
    {
        public Menu_funcionario()
        {
            InitializeComponent();
        }

        private void Btn_crear_tarea_Click(object sender, RoutedEventArgs e)
        {
            Crear_tarea ct = new Crear_tarea();
            ct.Show();
            Close();
        }

        private void Btn_crear_subordi_Click(object sender, RoutedEventArgs e)
        {
            Crear_tarea_subordinada ts = new Crear_tarea_subordinada();
            ts.Show();
            Close();
        }

        private void Btn_reasignar_Click(object sender, RoutedEventArgs e)
        {
            Reasignar_tarea rt = new Reasignar_tarea();
            rt.Show();
            Close();
        }

        private void Btn_asi_responsable_Click(object sender, RoutedEventArgs e)
        {
            Asignar_responsable ar = new Asignar_responsable();
            ar.Show();
            Close();
        }

        private void Btn_ejecutar_flujo_Click(object sender, RoutedEventArgs e)
        {
            Ejecutar_flujo ef = new Ejecutar_flujo();
            ef.Show();
            Close();
        }

        private void Btn_salir_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            Close();
        }
    }
}
