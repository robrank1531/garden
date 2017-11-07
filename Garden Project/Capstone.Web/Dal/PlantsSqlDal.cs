using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Data.SqlClient;

namespace Capstone.Web.Dal
{
    public class PlantsSqlDal : IPlantsSqlDal
    {
        private readonly string connectionString;
        private string AllPlants = @"SELECT * FROM plants;";
        public PlantsSqlDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Plants> GetPlants()
        {
            List<Plants> allPlants = new List<Plants>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand(AllPlants, conn);
                    SqlDataReader results = cmd.ExecuteReader();

                    while (results.Read())
                    {
                        Plants p = new Plants();
                        p.Name = Convert.ToString(results["name"]);
                        p.Maturity = Convert.ToString(results["maturity"]);
                        p.Height = Convert.ToString(results["height"]);
                        p.Spread = Convert.ToString(results["spread"]);
                        p.Size = Convert.ToString(results["size"]);
                        p.Sun = Convert.ToString(results["sun"]);
                        p.Description = Convert.ToString(results["description"]);
                        allPlants.Add(p);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw;
            }
            return allPlants;
        }
    }
}
