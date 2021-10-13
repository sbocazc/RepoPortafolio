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
using Gestion_de_tareas;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Configuration;


namespace wpf_vista
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Menu logeo;
        Menu_funcionario menufun;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        OracleConnection conn = new OracleConnection("DATA SOURCE =localhost ; PASSWORD = 1234 ; USER ID = PORTAFOLIO");
        private void Btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand comando = new OracleCommand("SELECT * FROM USU WHERE NOMBRE_USUARIO = :usuario AND CONTRASENA = :contra AND TIPO_USUARIO = 1", conn);
                comando.Parameters.Add(":usuario", txt_usuario.Text);
                comando.Parameters.Add(":contra", txt_contraseña.Text);

                OracleDataReader lector = comando.ExecuteReader();

                OracleCommand comando2 = new OracleCommand("SELECT * FROM USU WHERE NOMBRE_USUARIO = :usuario AND CONTRASENA = :contra AND TIPO_USUARIO= 2", conn);
                comando2.Parameters.Add(":usuario", txt_usuario.Text);
                comando2.Parameters.Add(":contra", txt_contraseña.Text);

                OracleDataReader lector2 = comando2.ExecuteReader();

                if (lector.Read())
                {
                    Menu form = new Menu();
                    conn.Close();
                    form.Show();

                }
                else if (lector2.Read())
                {
                    Menu_funcionario form2 = new Menu_funcionario();
                    conn.Close();
                    form2.Show();
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrectas");
                }
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR! NO HAY CONEXIÓN CON ORACLE");
            }
          

        }
    }
}
