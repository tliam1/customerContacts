using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customerContacts.onlineContactClasses
{
    class ContactsClass
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Gender { get; set; }


        private static string connString = ConfigurationManager.ConnectionStrings["customerContacts.Properties.Settings.OnlineContactsConnectionString"].ConnectionString;

        // Select Data from DB
        public DataTable SelectAll()
        {
            // create connection and run query
            SqlConnection conn = new SqlConnection(connString);
            DataTable dt = new DataTable();
            try
            {
                string query = $"SELECT * FROM tbl_contacts";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                // this executes the query and applys results on to the dt
                adapter.Fill(dt); // hover over to review what it does, straight forward, but bad naming imo
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public bool Insert(ContactsClass c)
        {
            SqlConnection conn = new SqlConnection(connString);
            int rows;
            try
            {
                string query = "INSERT INTO tbl_contacts (firstName, lastName, email, number, address, gender)" +
                               "VALUES (@firstName, @lastName, @email, @number, @address, @gender)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", c.FirstName);
                cmd.Parameters.AddWithValue("@lastName", c.LastName);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@number", c.Number);
                cmd.Parameters.AddWithValue("@address", c.Address);
                cmd.Parameters.AddWithValue("@gender", c.Gender);

                //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                rows = cmd.ExecuteNonQuery();
                /*
                 * rows = the effects of the queries effected x number of rows
                 * >0 means it made some change
                 */
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine("SQL Error: " + sqlEx.Message);
                throw; // Optionally rethrow to handle it elsewhere
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }

            return rows > 0;
        }

        public bool Update(ContactsClass c)
        {
            SqlConnection conn = new SqlConnection(connString);
            int rows;
            try
            {
                string query =
                    "UPDATE tbl_contacts SET firstName = @firstName, lastName = @lastName, email = @email, " +
                    "number = @number, address = @address, gender = @gender WHERE contactID = @contactID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@firstName", c.FirstName);
                cmd.Parameters.AddWithValue("@lastName", c.LastName);
                cmd.Parameters.AddWithValue("@email", c.Email);
                cmd.Parameters.AddWithValue("@number", c.Number);
                cmd.Parameters.AddWithValue("@address", c.Address);
                cmd.Parameters.AddWithValue("@gender", c.Gender);
                cmd.Parameters.AddWithValue("@contactID", c.ContactID);
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }

            return rows > 0;
        }

        public bool Delete(ContactsClass c)
        {
            SqlConnection conn = new SqlConnection(
                connString);
            int rows;
            try
            {
                string query =
                    "DELETE FROM tbl_contacts WHERE contactID = @contactID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@contactID", c.ContactID);
                conn.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                conn.Close();
            }

            return rows > 0;
        }

        public static string GetConnString()
        {
            return connString;
        }
    }
}
