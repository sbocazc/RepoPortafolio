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
    /// Lógica de interacción para agregar_empresa.xaml
    /// </summary>
    public partial class agregar_empresa : Window
    {
        public agregar_empresa()
        {
            InitializeComponent();
        }

        OracleConnection conn = new OracleConnection("DATA SOURCE =localhost ; PASSWORD = 1234 ; USER ID = portafolio");
        private void btn_crear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_EMPRESA", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("NOMBRE_EMPRESA", OracleDbType.Varchar2).Value = txt_nom_empresa.Text;
                comando.Parameters.Add("RAZON_SOCIAL", OracleDbType.Varchar2).Value = txt_razon_social.Text;
                comando.Parameters.Add("RUN_CLIENTE", OracleDbType.Int64).Value = txt_run_cliente.Text;
                comando.Parameters.Add("DV_CLIENTE", OracleDbType.Int64).Value = txt_dv_cliente.Text;
                comando.Parameters.Add("PRIMER_NOMBRE", OracleDbType.Varchar2).Value = txt_primer_nombre.Text;
                comando.Parameters.Add("SEGUNDO_NOMBRE", OracleDbType.Varchar2).Value = txt_segundo_nombre.Text;
                comando.Parameters.Add("APELLIDO_PATERNO", OracleDbType.Varchar2).Value = txt_ape_paterno.Text;
                comando.Parameters.Add("APELLIDO_MATERNO", OracleDbType.Varchar2).Value = txt_ape_materno.Text;
                comando.Parameters.Add("EMAIL", OracleDbType.Varchar2).Value = txt_email.Text;
                comando.Parameters.Add("NUMERO_CELULAR", OracleDbType.Int64).Value = txt_nu_celular.Text;
                comando.ExecuteNonQuery();

                MessageBox.Show("Usuario agregado");
            }
            catch (Exception)
            {

                MessageBox.Show("Algo falló");
            }
            conn.Close();

        }

        private void Btn_volver_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    }

