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
    /// Lógica de interacción para Crear_tarea_subordinada.xaml
    /// </summary>
    public partial class Crear_tarea_subordinada : Window
    {
        public Crear_tarea_subordinada()
        {
            InitializeComponent();
        }

        private void Btn_volver_Click(object sender, RoutedEventArgs e)
        {
            Menu_funcionario mf = new Menu_funcionario();
            mf.Show();
            Close();
        }
    }
}
