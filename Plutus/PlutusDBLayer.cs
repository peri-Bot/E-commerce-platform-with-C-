using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Plutus
{
    class PlutusDBLayer
    {

        string conString = "Data Source=sphinx;Initial Catalog=plutusDB;Integrated Security=True";

        public void saveUserBySP(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_Insert_User", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@varUserName", u.UserName);
                    cmd.Parameters.AddWithValue("@varFirstName", u.FirstName);
                    cmd.Parameters.AddWithValue("@varLastName", u.LastName);
                    cmd.Parameters.AddWithValue("@varEmail", u.Email);
                    cmd.Parameters.AddWithValue("@varTelephone", u.Phone);
                    cmd.Parameters.AddWithValue("@varPassw", u.Passw);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        public void saveAddressBySp(User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlCommand sqlCommand = new SqlCommand("SP_Insert_Address", con);
                    sqlCommand.CommandType = CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@varUserName", user.UserName);
                    sqlCommand.Parameters.AddWithValue("@varAddressLine", user.AddressLine);
                    sqlCommand.Parameters.AddWithValue("@varCity", user.City);
                    sqlCommand.Parameters.AddWithValue("@varPostalCode", user.PostalCode);
                    sqlCommand.Parameters.AddWithValue("@varZipCode", user.ZipCode);


                    int row = sqlCommand.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Account Created Succesfully");
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool Login_AuthenticateBySp(User user)
        {
            bool auth = false;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {

                    int userId = 0;
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SP_Validate_User", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@varEmail", user.Email);
                        cmd.Parameters.AddWithValue("@varPassw", user.Passw);


                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                        con.Close();
                    }
                    if (userId == -1)
                    {
                        auth = false;

                    } else
                    {
                        auth = true;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return auth;
        }

        public void startShoppingSessionBySp(User user)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SP_start_shopping_session", con))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                        sqlCommand.Parameters.AddWithValue("@varEmail", user.Email);

                        int row = sqlCommand.ExecuteNonQuery();
                        con.Close();
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void endShoppingSessionBySP()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SP_end_shopping_session", con))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        int row = sqlCommand.ExecuteNonQuery();
                        con.Close();
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public User getUser()
        {
            string userName = "";
            string firstName = "";
            string lastName = "";
            string passw = "";
            string email = "";
            string phone = "";
            string addressLine = "";
            string city = "";
            string postalCode = "";
            string zipCode = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SP_get_user", con))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                userName = dr["userName"].ToString();
                                firstName = dr["firstName"].ToString();
                                lastName = dr["lastName"].ToString();
                                passw = dr["passw"].ToString();
                                email = dr["email"].ToString();
                                phone = dr["telephone"].ToString();
                            }
                        }
                        con.Close();
                    }
                }

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand sqlCommand = new SqlCommand("SP_get_Address", con))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader dr = sqlCommand.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                addressLine = dr["addressLine"].ToString();
                                city = dr["city"].ToString();
                                postalCode = dr["postalCode"].ToString();
                                zipCode = dr["zipCode"].ToString();                              
                            }
                        }
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return new User(userName,firstName,lastName,passw,email,phone,addressLine,city,postalCode,zipCode);
        }

        public int getNumberOfProducts(Button button)
        {
            int retunvalue = 0;
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_get_product_number_cat", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@varCatagoryName", button.Text);
                    cmd.Parameters.Add("@pCount", SqlDbType.Int);
                    cmd.Parameters["@pCount"].Direction = ParameterDirection.Output;

                    int row = cmd.ExecuteNonQuery();
                    retunvalue =Convert.ToInt32(cmd.Parameters["@pCount"].Value);
                   
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return retunvalue;
        }

        public Product[] retriveProductBySp(Button button)
        {
            Product[] products;
            int retunvalue = getNumberOfProducts(button), i = 0;
               

            
            products = new Product[retunvalue];         

            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_get_product_by_cat_name", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@varCatagoryName", button.Text);

                    

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {

                            string productName = dr["PName"].ToString();
                            string productDesc = dr["pdesc"].ToString(); 
                            string productVendor = dr["vendor"].ToString(); 
                            double price = Convert.ToDouble(dr["price"]);
                           

                         //   System.Drawing.Image productImage = (System.Drawing.Image)dr["pimage"]; 

                            products[i] = new Product(productName, productDesc, productVendor,price);
                            i++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ ex.StackTrace);
            }


            return products;
        }

        public Product getProductBySp(string productName)
        {
            Product product = new Product();
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("SP_get_product_by_name", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@varProductName", productName);

                    using(SqlDataReader dataReader = cmd.ExecuteReader())
                    {
                        if (dataReader.Read())
                        {
                           

                            product.ProductName = dataReader["PName"].ToString();
                            product.ProductDesc = dataReader["pdesc"].ToString();
                            product.ProductVendor = dataReader["vendor"].ToString();
                            product.Price = Convert.ToDouble(dataReader["price"]);
                            // product.ProductImage = (System.Drawing.Image)dr["pimage"]; 
                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }

            
            return product;
        }

    //    public 
    }
}
