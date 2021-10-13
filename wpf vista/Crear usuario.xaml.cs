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
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Configuration;

namespace wpf_vista
{
    /// <summary>
    /// Lógica de interacción para Crear_usuario.xaml
    /// </summary>
    public partial class Crear_usuario : Window
    {
        public Crear_usuario()
        {
            InitializeComponent();
        }

        OracleConnection conn = new OracleConnection("DATA SOURCE =PORTAFOLIO ; PASSWORD = PORTAFOLIO ; USER ID = PORTAFOLIO");

        private void Btn_volver_Click(object sender, RoutedEventArgs e)
        {
            Menu m = new Menu();
            m.Show();
            this.Close();
        }

        private void btn_ingresar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_USU", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE_USUARIO", OracleDbType.Varchar2).Value = txt_nombre.Text;
                comando.Parameters.Add("CONTRASENA", OracleDbType.Varchar2).Value = txt_contrasena.Text;
                comando.Parameters.Add("EMPRESA_ID_EMPRESA", OracleDbType.Int64).Value = txt_empresa_id.Text;
                comando.Parameters.Add("TIPO_USUARIO", OracleDbType.Varchar2).Value = txt_tipo_usuario.Text;
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado");
            }
            catch (Exception)
            {

                MessageBox.Show("Algo falló");
            }
            conn.Close();
        }
    }
}
