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
    /// Lógica de interacción para Asignar_responsable.xaml
    /// </summary>
    public partial class Asignar_responsable : Window
    {
        public Asignar_responsable()
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
