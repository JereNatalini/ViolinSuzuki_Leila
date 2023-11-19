using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViolinSuzuki_Leila.Clases;

namespace ViolinSuzuki_Leila
{
    class Helper
    {
        SqlConnection cnn;
        SqlCommand cmd;
        string cnnString;

        public Helper()
        {
            cnnString = @"Data Source=JUANSANTACROCE\SQLEXPRESS;Initial Catalog=VIOLIN_SUZUKI_LEILA;Integrated Security=True";
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
            int? result;
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreSP;
            cmd.Parameters.Clear();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            //Este bloque es por si no hay ID´s porq no hay registros todavia
            try
            {
                result = Convert.ToInt32(dt.Rows[0][0]);
            }
            catch 
            {
                result = 0;
            }

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

        public bool Confirmar(Progreso p)
        {
            bool resultado = true;
            SqlTransaction t = null;

            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                //Insert Maestro
                SqlCommand cmdM = new SqlCommand("SP_INSERTAR_MAESTRO", cnn, t);
                cmdM.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idAlumno", p.pAlumno.IdAlumno);
                cmd.Parameters.AddWithValue("@idResponsable", p.pResponsable.IdResponsable);
                //Parametro de salida
                SqlParameter pOut = new SqlParameter();
                pOut.ParameterName = "@progresoNro";
                pOut.DbType = DbType.Int32;
                pOut.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pOut);
                cmd.ExecuteNonQuery();

                int progresoNro = (int)pOut.Value;

                //Insert Detalle
                SqlCommand cmdDetalle;
                int detalleNro = 1;
                foreach (DetalleProgreso item in p.detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLE", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@progresoNro", progresoNro);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@idCancion", item.pCancion.idCancion);
                    cmdDetalle.Parameters.AddWithValue("@observaciones", item.pObservaciones);
                    cmdDetalle.ExecuteNonQuery();

                    detalleNro++;
                }
                t.Commit();


            }
            catch (Exception)
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }

            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }
            return resultado;
        }
    }
}
