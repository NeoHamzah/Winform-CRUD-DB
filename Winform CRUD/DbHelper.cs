using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Winform_CRUD_DB
{
    class CrudDatabasePBO
    {
        public static void CreateData(string nama, string deskripsi, string kualifikasi, string skills, string rerata, string lokasi)
        {
            ConnectDB connectData = new ConnectDB();
            string querycreate = $"insert into pekerjaan_it (nama_pekerjaan, deskripsi_pekerjaan, kualifikasi_pendidikan, skills, rerata_gaji, lokasi_kerja) values ('{nama}', '{deskripsi}', '{kualifikasi}', '{skills}', '{rerata}', '{lokasi}');";
            connectData.ExecuteSQL(querycreate);
        }
        public static DataTable ReadData()
        {
            ConnectDB connectData = new ConnectDB();
            DataTable dt = connectData.ExecuteSQL("select * from pekerjaan_it");

            return dt;
        }
        public static void UpdateData(string nama, string deskripsi, string kualifikasi, string skills, string rerata, string lokasi, int id_pekerjaan)
        {
            ConnectDB connectData = new ConnectDB();
            string queryupdate = $"update pekerjaan_it set nama_pekerjaan = '{nama}', deskripsi_pekerjaan = '{deskripsi}', kualifikasi_pendidikan = '{kualifikasi}', skills = '{skills}', rerata_gaji = '{rerata}', lokasi_kerja = '{lokasi}' where id_pekerjaan_it = {id_pekerjaan}";
            connectData.ExecuteSQL(queryupdate);
        }
        public static void DeleteData(int id_pekerjaan)
        {
            ConnectDB connectData = new ConnectDB();
            string querydelete = $"delete from pekerjaan_it where id_pekerjaan_it = {id_pekerjaan}::integer;;";
            connectData.ExecuteSQL(querydelete);
        }

    }

    class ConnectDB
    {
        public NpgsqlConnection connect;

        public ConnectDB()
        {
            connect = new NpgsqlConnection();
            string constr = "Server=localhost;Port=5432;User Id=hamzah;Password=adminpbo;Database=Pekerjaan"; 
            connect.ConnectionString = constr;
        }

        public DataTable ExecuteSQL(string syntax)
        {

            DataTable dt = new DataTable();
            try
            {
                connect.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = syntax;
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                da.Fill(dt);
                cmd.Dispose();
                connect.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex);
            }
            return dt;
        }
    }
}
