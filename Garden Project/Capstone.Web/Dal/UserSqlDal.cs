using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Capstone.Web.Models;
using System.Web.Mvc;

namespace Capstone.Web.Dal
{
    public class UserSqlDal
    {
        private readonly string connectionString;
        private string addPlant = @"INSERT INTO plantuserinfo VALUES (@name, @count, GETDATE(), DATEADD(dd, @daysToMaturity, GETDATE()));";
        private string getUserInfo = @"SELECT * FROM plantuserinfo;";

        public UserSqlDal(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<User> GetUserInfo()
        {
            List<User> userInfo = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(getUserInfo, conn);
                    SqlDataReader results = cmd.ExecuteReader();
                    while (results.Read())
                    {
                        User u = new User();
                        u.Name = Convert.ToString(results["name"]);
                        u.Count = Convert.ToInt32(results["count"]);
                        u.PlantDate = Convert.ToDateTime(results["dateplanted"]);
                        u.MaturityDate = Convert.ToDateTime(results["expectedmaturity"]);
                        userInfo.Add(u);
                    }
                }
            }
            catch(SqlException ex)
            {
                throw;
            }
            return userInfo;
        }
        public bool NewInfo(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(addPlant, conn);
                    cmd.Parameters.AddWithValue("@name", user.Name);
                    cmd.Parameters.AddWithValue("@count", user.Count);
                    cmd.Parameters.AddWithValue("@daysToMaturity", user.DaysToMaturity);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch(SqlException ex)
            {
                return false;
            }
        }
    }
}
//        public bool SubmitSurvey(Survey survey)
//        {
//            try
//            {
//                using (SqlConnection conn = new SqlConnection(connectionString))
//                {
//                    conn.Open();

//                    SqlCommand cmd = new SqlCommand(SQL_SubmitSurvey, conn);
//                    cmd.Parameters.AddWithValue("@parkCode", survey.ParkCode);
//                    cmd.Parameters.AddWithValue("@emailAddress", survey.Email);
//                    cmd.Parameters.AddWithValue("@activityLevel", survey.ActivityLevel);
//                    cmd.Parameters.AddWithValue("@state", survey.State);
//                    int rowsAffected = cmd.ExecuteNonQuery();

//                    return rowsAffected > 0;
//                }
//            }
//            catch (SqlException ex)
//            {
//                return false;
//            }
//        }
//{
//    public class SurveySqlDAL
//    {
//        public List<Survey> GetResults()
//        {
//            List<Survey> surveyResults = new List<Survey>();
//            try
//            {
//                using (SqlConnection conn = new SqlConnection(connectionString))
//                {
//                    conn.Open();

//                    SqlCommand cmd = new SqlCommand(SQL_DisplaySurveyResults, conn);
//                    SqlDataReader results = cmd.ExecuteReader();

//                    while (results.Read())
//                    {
//                        Survey s = new Survey();
//                        s.Votes = Convert.ToInt32(results["votes"]);
//                        s.Name = Convert.ToString(results["parkName"]);
//                        surveyResults.Add(s);
//                    }
//                }
//            }
//            catch (SqlException ex)
//            {
//                throw;
//            }
//            return surveyResults;
//        }

//        //to use with List<SelectListItem> ChoosePark
//        public SelectList GetParkList()
//        {
//           Survey survey = new Survey();
//           List<Survey> list = new List<Survey>();
//            try
//            {
//                using (SqlConnection conn = new SqlConnection(connectionString))
//                {
//                    conn.Open();

//                    SqlCommand cmd = new SqlCommand(SQL_GetParkNames, conn);
//                    SqlDataReader results = cmd.ExecuteReader();

//                    while (results.Read())
//                    {
//                        list.Add(new Survey
//                        {
//                            Text = Convert.ToString(results["parkName"]),
//                            Value = Convert.ToString(results["parkCode"])
//                        });
//                    }
//                }
//                survey.DropDownList = new SelectList(list, "Value", "Text");
//            }
//            catch (SqlException ex)
//            {
//                throw;
//            }
//            return survey.DropDownList;
//        }
//    }
//}