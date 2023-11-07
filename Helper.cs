using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViolinSuzuki_Leila
{
    class Helper
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string cnnString;

        public Helper()
        {
            cnnString = @"Data Source=NTB62275\SQLEXPRESS;Initial Catalog=VIOLIN_SUZUKI_LEILA;Integrated Security=True";
            cnn = new SqlConnection(cnnString);
            cmd = new SqlCommand();
        }

        public DataTable Consultar(string nombreSP, List<Parametro> lstParametros)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();

            foreach (Parametro p in lstParametros)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public DataTable Consultar(string nombreSP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }

        public int? ConsultarID(string nombreSP)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            int? result = Convert.ToInt32(dt.Rows[0][0]);
            cnn.Close();
            return result;
        }

        public DataTable Consultar(string nombreSP, Parametro param)
        {
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue(param.Nombre, param.Valor);


            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            cnn.Close();
            return dt;
        }
        public bool Insertar(string nombreSP, List<Parametro> lstParametros)
        {
            bool res = false;
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();

            foreach (Parametro p in lstParametros)
            {
                cmd.Parameters.AddWithValue(p.Nombre, p.Valor);
            }

            //DataTable dt = new DataTable();
            //dt.Load(cmd.ExecuteReader()); //Estamos cargando aca de vuelta en el data table, por eso se duplican
            if (cmd.ExecuteNonQuery() > 0)
            {
                res = true;
            }
            cnn.Close();
            return res;
        }
    }
}
