using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Utilities
{
    public class StoredProcedures
    {

        SqlCommand myCommand = new SqlCommand();


        public void AddMember(string email, string password, string firstName, string lastName, string address, string billingAddress)
        {
            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.CommandText = "AddMember";

            //for each input in memberAccounts these sqlParams add the corresponding input. minus confirmed or not
            //SqlParameter inputParamaterCourseID = new SqlParameter("@memberID", memberID);

            //inputParamaterCourseID.Direction = ParameterDirection.Input;
            //inputParamaterCourseID.SqlDbType = SqlDbType.Int;
            //inputParamaterCourseID.Size = 5;
            //myCommand.Parameters.Add(inputParamaterCourseID);

            SqlParameter inputParamaterProfID = new SqlParameter("@email", email);

            inputParamaterProfID.Direction = ParameterDirection.Input;
            inputParamaterProfID.SqlDbType = SqlDbType.VarChar;
            inputParamaterProfID.Size = 50;
            myCommand.Parameters.Add(inputParamaterProfID);

            SqlParameter inputParamaterTitle = new SqlParameter("@password", password);

            inputParamaterTitle.Direction = ParameterDirection.Input;
            inputParamaterTitle.SqlDbType = SqlDbType.VarChar;
            inputParamaterTitle.Size = 50;
            myCommand.Parameters.Add(inputParamaterTitle);

            SqlParameter inputParamaterDesc = new SqlParameter("@firstName", firstName);

            inputParamaterDesc.Direction = ParameterDirection.Input;
            inputParamaterDesc.SqlDbType = SqlDbType.VarChar;
            inputParamaterDesc.Size = 50;
            myCommand.Parameters.Add(inputParamaterDesc);

            SqlParameter inputParamaterDepartment = new SqlParameter("@lastName", lastName);

            inputParamaterDepartment.Direction = ParameterDirection.Input;
            inputParamaterDepartment.SqlDbType = SqlDbType.VarChar;
            inputParamaterDepartment.Size = 50;
            myCommand.Parameters.Add(inputParamaterDepartment);

            SqlParameter inputParamaterSemester = new SqlParameter("@address", address);

            inputParamaterSemester.Direction = ParameterDirection.Input;
            inputParamaterSemester.SqlDbType = SqlDbType.VarChar;
            inputParamaterSemester.Size = 50;
            myCommand.Parameters.Add(inputParamaterSemester);

            SqlParameter inputParamaterImage = new SqlParameter("@billingAddress", billingAddress);

            inputParamaterImage.Direction = ParameterDirection.Input;
            inputParamaterImage.SqlDbType = SqlDbType.VarChar;
            inputParamaterImage.Size = 50;
            myCommand.Parameters.Add(inputParamaterImage);

            DBConnect objDB = new DBConnect();
            objDB.DoUpdateUsingCmdObj(myCommand);
        }


        public DataSet GetProfilesByMovie(string movieTitle)
        {
            DataSet dsMembers = new DataSet();

            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.CommandText = "GetProfilesByMovie";


            SqlParameter inputParamaterMovie = new SqlParameter("@movieTitle", movieTitle);

            inputParamaterMovie.Direction = ParameterDirection.Input;
            inputParamaterMovie.SqlDbType = SqlDbType.VarChar;
            inputParamaterMovie.Size = 50;
            myCommand.Parameters.Add(inputParamaterMovie);


            DBConnect objDB = new DBConnect();
            dsMembers = objDB.GetDataSetUsingCmdObj(myCommand);

            return dsMembers;
        }

        public DataSet GetProfilesByPoem(string poemTitle)
        {
            DataSet dsMembers = new DataSet();

            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.CommandText = "GetProfilesByPoem";


            SqlParameter inputParamaterMovie = new SqlParameter("@poemTitle", poemTitle);

            inputParamaterMovie.Direction = ParameterDirection.Input;
            inputParamaterMovie.SqlDbType = SqlDbType.VarChar;
            inputParamaterMovie.Size = 50;
            myCommand.Parameters.Add(inputParamaterMovie);


            DBConnect objDB = new DBConnect();
            dsMembers = objDB.GetDataSetUsingCmdObj(myCommand);

            return dsMembers;
        }

        public DataSet GetProfilesByRestaurants(string restaurant)
        {
            DataSet dsMembers = new DataSet();

            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.CommandText = "GetProfilesByRestaurants";


            SqlParameter inputParamaterMovie = new SqlParameter("@restaurantName", restaurant);

            inputParamaterMovie.Direction = ParameterDirection.Input;
            inputParamaterMovie.SqlDbType = SqlDbType.VarChar;
            inputParamaterMovie.Size = 50;
            myCommand.Parameters.Add(inputParamaterMovie);


            DBConnect objDB = new DBConnect();
            dsMembers = objDB.GetDataSetUsingCmdObj(myCommand);

            return dsMembers;
        }

        public DataSet GetPrByMoviesGender (string movieTitle, string gender)
        {
            DataSet dsMembers = new DataSet();

            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.CommandText = "GetPrByMoviesGender";


            SqlParameter inputParamaterMovie = new SqlParameter("@movieTitle", movieTitle);

            inputParamaterMovie.Direction = ParameterDirection.Input;
            inputParamaterMovie.SqlDbType = SqlDbType.VarChar;
            inputParamaterMovie.Size = 50;
            myCommand.Parameters.Add(inputParamaterMovie);


            SqlParameter inputParamaterGender = new SqlParameter("@gender", gender);

            inputParamaterGender.Direction = ParameterDirection.Input;
            inputParamaterGender.SqlDbType = SqlDbType.VarChar;
            inputParamaterGender.Size = 50;
            myCommand.Parameters.Add(inputParamaterGender);

            DBConnect objDB = new DBConnect();
            dsMembers = objDB.GetDataSetUsingCmdObj(myCommand);

            return dsMembers;
        }

        public DataSet GetPrByPoemGender(string poemTitle, string gender)
        {
            DataSet dsMembers = new DataSet();

            myCommand.CommandType = System.Data.CommandType.StoredProcedure;
            myCommand.CommandText = "GetPrByMoviesGender";


            SqlParameter inputParamaterPoem = new SqlParameter("@poemTitle", poemTitle);

            inputParamaterPoem.Direction = ParameterDirection.Input;
            inputParamaterPoem.SqlDbType = SqlDbType.VarChar;
            inputParamaterPoem.Size = 50;
            myCommand.Parameters.Add(inputParamaterPoem);

            SqlParameter inputParamaterGender = new SqlParameter("@gender", gender);

            inputParamaterGender.Direction = ParameterDirection.Input;
            inputParamaterGender.SqlDbType = SqlDbType.VarChar;
            inputParamaterGender.Size = 50;
            myCommand.Parameters.Add(inputParamaterGender);

            DBConnect objDB = new DBConnect();
            dsMembers = objDB.GetDataSetUsingCmdObj(myCommand);

            return dsMembers;
        }

    }
}
