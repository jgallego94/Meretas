using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


public class CreditCards
{
    public List<CreditCard> RecommendCreditCards(string type, string employmentStatus, string features, string balance, string discharged)
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

                AddParameter = new SqlParameter();
                AddParameter.ParameterName = "@Discharged";
                AddParameter.SqlDbType = SqlDbType.NVarChar;
                AddParameter.Direction = ParameterDirection.Input;
                AddParameter.Value = discharged;

                GetCommand.Parameters.Add(AddParameter);

                using (SqlDataReader reader = GetCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader.HasRows)
                        {
                            creditCard = new CreditCard();

                            creditCard.CardName = reader["CreditCardName"].ToString();
                            creditCard.CardType = reader["Type"].ToString();
                            creditCard.EmploymentStatus = reader["EmploymentStatus"].ToString();
                            creditCard.Features = reader["Features"].ToString();
                            creditCard.BalanceLength = reader["Balance"].ToString();
                            creditCard.Discharged = reader["Discharged"].ToString();

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