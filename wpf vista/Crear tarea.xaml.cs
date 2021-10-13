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
using Gestion_de_tareas;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Data;
using System.Configuration;

namespace wpf_vista
{
    /// <summary>
    /// Lógica de interacción para Crear_tarea.xaml
    /// </summary>
    public partial class Crear_tarea : Window
    {
        public Crear_tarea()
        {
            InitializeComponent();
            cargar_cbo();


        }

        private void Btn_volver_Click(object sender, RoutedEventArgs e)
        {
            Menu_funcionario mf = new Menu_funcionario();
            mf.Show();
            Close();
        }
        OracleConnection conn = new OracleConnection("DATA SOURCE =localhost ; PASSWORD = 1234 ; USER ID = PORTAFOLIO");

        private void cargar_cbo()
        {
            conn.Open();
            OracleCommand cmd = new OracleCommand("SELECT ID_USUARIO, NOMBRE_USUARIO FROM USU", conn);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            OracleDataReader dr = cmd.ExecuteReader();
            OracleDataAdapter oda = new OracleDataAdapter(cmd);
            DataTable ds = new DataTable();
            oda.Fill(ds);
            
            cboResponsable.ItemsSource = ds.AsDataView();
            cboResponsable.DisplayMemberPath = "NOMBRE_USUARIO";
            cboResponsable.SelectedValuePath = "ID_USUARIO";
        }

        private void btn_crear_tarea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                OracleCommand comando = new OracleCommand("SP_AGREGAR_TAREA", conn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("PRIORIDAD", OracleDbType.Varchar2).Value = cboPriori.Text;
                comando.Parameters.Add("NOMBRE_TAREA", OracleDbType.Varchar2).Value = txt_nombre_tarea.Text;
                comando.Parameters.Add("DESCRIPCION_TAREA", OracleDbType.Int64).Value = txt_descripcion.Text;
                comando.Parameters.Add("FECHA_INI", OracleDbType.Int64).Value = date_ini;
                comando.Parameters.Add("FECHA_TER", OracleDbType.Varchar2).Value = date_ter.Text;
                comando.Parameters.Add("NOMBRE_RESPONSABLE", OracleDbType.Varchar2).Value = cboResponsable.Text;
                comando.ExecuteNonQuery();

                MessageBox.Show("Tarea Agregada");
            }
            catch (Exception)
            {

                MessageBox.Show("Algo falló");
            }
            conn.Close();

        }

        
    }
}
