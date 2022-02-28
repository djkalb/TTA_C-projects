using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Casino;
using Casino.Blackjack;
using System.Runtime;
using System.Data;

using System.Data.SqlClient;


namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("come play blackjack. what is your name");
            string playerName = Console.ReadLine().ToLower();
            if (playerName == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.ExceptionType + " | \n");
                }
                Console.Read();
                return;
            }
            int bank = 0;
            bool validAnswer = false;
            while (!validAnswer)
            {
                Console.WriteLine("how much you going to put down");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);
                if (!validAnswer)
                {
                    Console.WriteLine("enter an integer only");
                }
            }
            
            Console.WriteLine("{0}, Do you want to play", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\David\Documents\Basic_C#_Programs\blackjack\blackjack\logs\log.txt", true))
                {
                    file.WriteLine(DateTime.Now);
                    file.WriteLine(player.Id);
                }
                Game game = new Blackjack();
                game = game + player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("errors occurred try again later");
                        UpdateDbWithException(ex);
                        return;
                    }
                    
                }
                game = game - player;
                Console.WriteLine("thank you for playing");

            }
            Console.WriteLine("try playing -- cheapskate");
        }
        private static void UpdateDbWithException (Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Blackjack;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                   (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=Blackjack;
                                    Integrated Security=True;Connect Timeout=30;Encrypt=False;
                                    TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                    MultiSubnetFailover=False";
            string queryString = @"Select * From Exceptions";
            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, conn);
                conn.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    var exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["Timestamp"]);
                    Exceptions.Add(exception);
                }
                conn.Close();
                return Exceptions;

            }

        }
        
    }
}
