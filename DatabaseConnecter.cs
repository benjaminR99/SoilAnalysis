using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;


namespace Front
{
    public static class DatabaseConnecter
    {
        //returns MySqlConnection
        public static MySqlConnection Connecter()
        {
            MySqlConnection connection = null;
            try
            {
                string connectionString = "Server=localhost;Database=geotech;User=root;Password=Rbenj@19;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return connection;

        }

        public static void AddSoilDetails(string sampleid, string location, string descrip, string date)
        {
            MySqlConnection connection = null;
            MySqlTransaction transaction = null;
            bool exist = DatabaseConnecter.SampleExists(DatabaseConnecter.Connecter(), sampleid);
            if (!exist)
            {
                try
                {
                    connection = Connecter();

                    transaction = connection.BeginTransaction();

                    // Perform the first query
                    string query1 = "INSERT INTO soilsampleDetails VALUES (@Value1, @Value2, @Value3, @Value4);";
                    MySqlCommand cmd1 = new MySqlCommand(query1, connection, transaction);
                    cmd1.Parameters.AddWithValue("@Value1", sampleid);
                    cmd1.Parameters.AddWithValue("@Value2", location);
                    cmd1.Parameters.AddWithValue("@Value3", descrip);
                    cmd1.Parameters.AddWithValue("@Value4", date);
                    int num1 = cmd1.ExecuteNonQuery();

                    // Perform the second query
                    string query2 = "INSERT INTO soilproperties (sampleid) VALUE (@Value5);";
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection, transaction);
                    cmd2.Parameters.AddWithValue("@Value5", sampleid);
                    int num2 = cmd2.ExecuteNonQuery();

                    // If both queries succeed, commit the transaction
                    if (num1 > 0 && num2 > 0)
                    {
                        transaction.Commit();
                        MessageBox.Show("Sample Added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                        transaction.Rollback();
                        MessageBox.Show("Failed to add sample", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    // Rollback the transaction 
                    transaction?.Rollback();
                }
                finally
                {
                    connection?.Close();
                }
            }
            else
            {
                throw new Exception("Duplicate entry : Sample ID already exists");
                
            }
        }

        public static void AddSG(string sampleid, float SG)
        {
            MySqlConnection connection = DatabaseConnecter.Connecter();
            String query = "update soilproperties set SG = @Value1 where sampleid = @Value2;";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Value1", SG);
                cmd.Parameters.AddWithValue("@Value2", sampleid);

                try
                {
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Added to soil property!");
                    }
                    else
                    {
                        MessageBox.Show("Coudnot add to soil property!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void AddLLPL(string sampleid, float LL, float PL)
        {
            MySqlConnection connection = DatabaseConnecter.Connecter();
            String query = "update soilproperties set LL = @Value2 , PL=@Value3 where sampleid = @Value1;";
             

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Value2", LL);
                cmd.Parameters.AddWithValue("@Value3", PL);
                cmd.Parameters.AddWithValue("@Value1", sampleid);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void AddCUCC(string sampleid, float CU, float CC)
        {
            MySqlConnection connection = DatabaseConnecter.Connecter();
            String query = "update soilproperties set CU = @Value2 , CC =@Value3 where sampleid = @Value1;";


            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Value2", CU);
                cmd.Parameters.AddWithValue("@Value3", CC);
                cmd.Parameters.AddWithValue("@Value1", sampleid);

                try
                {
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Added to soil property!");
                    }
                    else
                    {
                        MessageBox.Show("Coudnot add to soil property!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } ;
        }

        public static void AddInDenSandCone(string sampleid, float Density)
        {
            MySqlConnection connection = DatabaseConnecter.Connecter();
            String query = "update soilproperties set InSituDensitySandCone = @Value1 where sampleid = @Value2;";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Value1", Density);
                cmd.Parameters.AddWithValue("@Value2", sampleid);

                try
                {
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Added to soil property!");
                    }
                    else
                    {
                        MessageBox.Show("Coudnot add to soil property!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public static void AddInDenCorecutter(string sampleid, float Density)
        {
            MySqlConnection connection = DatabaseConnecter.Connecter();
            String query = "update soilproperties set InSituDensityCoreCutter = @Value1 where sampleid = @Value2;";

            using (MySqlCommand cmd = new MySqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@Value1", Density);
                cmd.Parameters.AddWithValue("@Value2", sampleid);

                try
                {
                    int num = cmd.ExecuteNonQuery();
                    if (num > 0)
                    {
                        MessageBox.Show("Added to soil property!");
                    }
                    else
                    {
                        MessageBox.Show("Coudnot add to soil property!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //to get the metadata of sample
        public static string[] GetSampleDetails(string sampleId)
        {
            string[] sampleDetails = null ;

            try
            {
                using (MySqlConnection connection = Connecter())
                {
                    if (SampleExists(connection, sampleId))
                    {
                        sampleDetails = new string[4];
                        sampleDetails = RetrieveSampleDetails(connection, sampleId);
                        
                    }
                    else
                    {
                        MessageBox.Show($" Sample ID '{sampleId}' not found.", "Not Found",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return sampleDetails;
        }

        private static bool SampleExists(MySqlConnection connection, string sampleId)
        {
            string query = "SELECT COUNT(*) FROM soilsampleDetails WHERE sampleid = @SampleId";
            int count=0;
            try
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@SampleId", sampleId);
                count = Convert.ToInt32(command.ExecuteScalar());
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count > 0;
        }

        //to retrieve the soil metadata from databse called in GetSampleDetail
        private static string[] RetrieveSampleDetails(MySqlConnection connection, string sampleId)
        {
            string query = "SELECT * FROM soilsampleDetails WHERE sampleid = @SampleId";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@SampleId", sampleId);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {  
                        return new string[]
                        {
                        reader["sampleid"].ToString(),
                        reader["location"].ToString(),
                        reader["descrip"].ToString(),
                        reader["ReceivedDate"].ToString()
                        };
                    }
                }
            }  
            return new string[4];
        }

        //to get the soil props
        public static string[] GetSoilProperties(string sampleId)
        {
            string[] soilProperties = new string[8];
            try
            {
                using (MySqlConnection connection = Connecter())
                {
                    string query = "SELECT * FROM soilproperties WHERE sampleid = @SampleId";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@SampleId", sampleId);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                                for (int i = 0; i < 8; i++)
                                {
                                    object value = reader[i];
                                    soilProperties[i] = (value != DBNull.Value) ? value.ToString() : "-";
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return soilProperties;
        }

        public static bool CheckUserCredentials(string userId, string password)
        {
            try
            {
                using (MySqlConnection connection = Connecter())
                {
                    string query = "SELECT COUNT(*) FROM users WHERE userid = @UserId AND pwd = @Password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserId", userId);
                        command.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(command.ExecuteScalar());

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false; // Return false in case of an exception
            }
        }

        public static List<string[]> GetThreeRecentSamples()
        {
            List<string[]> recentSamples = new List<string[]>();

            try
            {
                string query = "SELECT * FROM soilsampleDetails ORDER BY ReceivedDate DESC LIMIT 3";
                MySqlConnection connection = DatabaseConnecter.Connecter();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {
                    string[] sampleData = {
                        Convert.ToString(reader["sampleid"]),
                    Convert.ToString(reader["location"]),
                    Convert.ToString(reader["descrip"]),
                    Convert.ToString(reader["ReceivedDate"])
                    };
                    recentSamples.Add(sampleData);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return recentSamples;
        }

    }
}
