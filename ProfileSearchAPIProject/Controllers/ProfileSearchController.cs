using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using Utilities;


namespace ProfileSearchAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileSearchController : ControllerBase
    {
        [HttpGet("GetProfilesByMovie")]
        public DataSet MovieProfiles(string movieTitle)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetProfilesByMovie(movieTitle);

            return dsProfiles;

        }

        [HttpGet("GetProfilesByPoem")]
        public DataSet PoemProfiles(string poemTitle)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetProfilesByPoem(poemTitle);

            return dsProfiles;
        }

        [HttpGet("GetProfilesByRestaurants")]
        public DataSet RestaurantProfiles(string restaurant)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetProfilesByRestaurants(restaurant);

            return dsProfiles;
        } 

        [HttpGet("GetPrByMovieGender")]
        public DataSet GetPrByMovieGender(string movieTitle, string gender)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetPrByMoviesGender(movieTitle, gender);

            return dsProfiles;
        }

        [HttpGet("GetPrByPoemGender")]
        public DataSet GetPrByPoemGender(string poemTitle, string gender)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetPrByMoviesGender(poemTitle, gender);

            return dsProfiles;
        }

        [HttpGet("GetPrByRestaurantGender")]
        public DataSet GetPrByRestaurantGender(string restaurant, string gender)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetPrByMoviesGender(restaurant, gender);

            return dsProfiles;
        }

    }
}