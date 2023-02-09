using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Xml.Linq;

namespace StoreProcedureWithADO_003
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private string _mail;
        private int _mobile;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Mail { get { return _mail; } set { _mail = value; } }
        public int Mobile { get { return _mobile; } set { _mobile = value; } }

        public string InputInfo(string message)
        {
            WriteLine(message);
            return ReadLine();
        }

        public void InsertEmployee()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand("spInsertStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(InputInfo(DisplayConstant.ID));
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = InputInfo(DisplayConstant.NAME);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = InputInfo(DisplayConstant.EMAIL);
                cmd.Parameters.Add("@Mobile", SqlDbType.Int).Value = Convert.ToInt32(InputInfo(DisplayConstant.MOBILE));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                WriteLine(DisplayConstant.INSERT_SUCCESS);
            }
            catch(Exception ex)
            {
                WriteLine(DisplayConstant.WARNING + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void UpdateEmployee()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            try
            {
                SqlCommand cmd = new SqlCommand("spUpdateStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(InputInfo(DisplayConstant.ID));
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = InputInfo(DisplayConstant.NAME);
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = InputInfo(DisplayConstant.EMAIL);
                cmd.Parameters.Add("@Mobile", SqlDbType.Int).Value = Convert.ToInt32(InputInfo(DisplayConstant.MOBILE));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                WriteLine(DisplayConstant.UPDATE_SUCCESS);
            }
            catch(Exception ex)
            {
                WriteLine(DisplayConstant.WARNING + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void DeleteEmployee()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

            try
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudent", conn)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = Convert.ToInt32(InputInfo(DisplayConstant.DELETE_ID));

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                WriteLine(DisplayConstant.DELETE_SUCCESS);
            }
            catch (Exception ex)
            {
                WriteLine(DisplayConstant.WARNING + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
