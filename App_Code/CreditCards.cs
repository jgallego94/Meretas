using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


public class CreditCards
{
    public SqlConnection Meretas()
    {
        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();
        meretas.ConnectionString = WebSettings.ConnectionString;

        return meretas;
    }
    public bool AddCreditCard(CreditCard creditCard)
    {
        

        CreditCard card = new CreditCard();
        int rowsAffected = 0;
        bool success = false;

        using (SqlConnection meretas = Meretas())
        {
            try
            {
                meretas.Open();

                SqlCommand AddCommand = new SqlCommand();
                AddCommand.Connection = meretas;
                AddCommand.CommandType = CommandType.StoredProcedure;
                AddCommand.CommandText = "AddCreditCard";

                SqlParameter AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@CreditCardName";
                AddParameter.SqlDbType = SqlDbType.NVarChar;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = creditCard.CardName;

                AddCommand.Parameters.Add(AddParameter);

                //AddParameter = new SqlParameter();
                //AddParameter.ParameterName = "@CardImage";
                //AddParameter.SqlDbType = SqlDbType.VarBinary;
                //AddParameter.Direction = ParameterDirection.Input;
                //AddParameter.Value = creditCard.CardImage;

                //AddCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@RedirectLink";
                AddParameter.SqlDbType = SqlDbType.NVarChar;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = creditCard.CardLink;

                AddCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@DateAdded";
                AddParameter.SqlDbType = SqlDbType.Date;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = creditCard.DateAdded;

                AddCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@TimeAdded";
                AddParameter.SqlDbType = SqlDbType.Time;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = creditCard.TimeAdded;

                AddCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@CreditCardID";
                AddParameter.SqlDbType = SqlDbType.Int;
                AddParameter.Direction = ParameterDirection.Output;

                AddCommand.Parameters.Add(AddParameter);

                using (SqlDataReader reader = AddCommand.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        if(reader.HasRows)
                        {
                            card.CreditCardID = Convert.ToInt32(reader[0].ToString());
                        }
                    }
                }                    
            }
            catch(Exception e)
            {
                throw new Exception("AddCreditCard error: " + e.Message);
            }
            finally
            {
                meretas.Close();
            }            
        }

        if (card != null)
        {
            using (SqlConnection meretas = Meretas())
            {
                try
                {
                    meretas.Open();

                    SqlCommand AddCommand = new SqlCommand();
                    AddCommand.Connection = meretas;
                    AddCommand.CommandType = CommandType.StoredProcedure;
                    AddCommand.CommandText = "AddCreditCardProperties";

                    SqlParameter AddParameter = new SqlParameter();
                    AddParameter.ParameterName = "@CreditCardID";
                    AddParameter.SqlDbType = SqlDbType.Int;
                    AddParameter.Direction = ParameterDirection.Input;
                    AddParameter.Value = card.CreditCardID;

                    AddCommand.Parameters.Add(AddParameter);

                    AddParameter = new SqlParameter();
                    AddParameter.ParameterName = "@Type";
                    AddParameter.SqlDbType = SqlDbType.NVarChar;
                    AddParameter.Direction = ParameterDirection.Input;
                    AddParameter.Value = creditCard.CardType;

                    AddCommand.Parameters.Add(AddParameter);

                    AddParameter = new SqlParameter();
                    AddParameter.ParameterName = "@EmploymentStatus";
                    AddParameter.SqlDbType = SqlDbType.NVarChar;
                    AddParameter.Direction = ParameterDirection.Input;
                    AddParameter.Value = creditCard.EmploymentStatus;

                    AddCommand.Parameters.Add(AddParameter);

                    AddParameter = new SqlParameter();
                    AddParameter.ParameterName = "@Features";
                    AddParameter.SqlDbType = SqlDbType.NVarChar;
                    AddParameter.Direction = ParameterDirection.Input;
                    AddParameter.Value = creditCard.Features;

                    AddCommand.Parameters.Add(AddParameter);

                    AddParameter = new SqlParameter();
                    AddParameter.ParameterName = "@Balance";
                    AddParameter.SqlDbType = SqlDbType.NVarChar;
                    AddParameter.Direction = ParameterDirection.Input;
                    AddParameter.Value = creditCard.BalanceLength;

                    AddCommand.Parameters.Add(AddParameter);

                    rowsAffected = AddCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        success = true;
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("AddCreditCardProperties error: " + e.Message);
                }
                finally
                {
                    meretas.Close();
                }
            }
        }
        return success;
    }
    public List<CreditCard> RecommendCreditCards(string type, string employmentStatus, string features, string balance)
    {
        ConnectionStringSettings WebSettings = ConfigurationManager.ConnectionStrings["Meretas"];
        SqlConnection meretas = new SqlConnection();
        meretas.ConnectionString = WebSettings.ConnectionString;

        List<CreditCard> creditCards = new List<CreditCard>();
        CreditCard creditCard;

        using (meretas)
        {
            try
            {
                meretas.Open();

                SqlCommand GetCommand = new SqlCommand();
                GetCommand.Connection = meretas;
                GetCommand.CommandType = CommandType.StoredProcedure;
                GetCommand.CommandText = "RecommendCreditCards";

                SqlParameter AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@Type";
                AddParameter.SqlDbType = SqlDbType.NVarChar;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = type;

                GetCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@EmploymentStatus";
                AddParameter.SqlDbType = SqlDbType.NVarChar;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = employmentStatus;

                GetCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@Features";
                AddParameter.SqlDbType = SqlDbType.NVarChar;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = features;

                GetCommand.Parameters.Add(AddParameter);

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@Balance";
                AddParameter.SqlDbType = SqlDbType.NVarChar;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = balance;

                GetCommand.Parameters.Add(AddParameter);

          

                using (SqlDataReader reader = GetCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            creditCard = new CreditCard();

                            creditCard.CardName = reader["CreditCardName"].ToString();
                            creditCard.CardLink = reader["RedirectLink"].ToString();
                            creditCard.CardType = reader["Type"].ToString();
                            creditCard.EmploymentStatus = reader["EmploymentStatus"].ToString();
                            creditCard.Features = reader["Features"].ToString();
                            creditCard.BalanceLength = reader["Balance"].ToString();
                       

                            creditCards.Add(creditCard);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("RecommendCreditCards error: " + e.Message);
            }
            finally
            {
                meretas.Close();
            }
        }
        return creditCards;
    }
}