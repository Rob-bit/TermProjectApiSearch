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
    [Produces("application/json")]
    [Route("api/ProfileSearch")]
    //[ApiController]
    public class ProfileSearchController : ControllerBase
    {

        //Gets profiles by a movie
        [HttpGet("GetProfilesByMovie/{movieTitle}")]
        public List<ProfileSummary> MovieProfiles(string movieTitle)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetProfilesByMovie(movieTitle);
            List<ProfileSummary> profiles = new List<ProfileSummary>();
            profiles = returnProfileList(dsProfiles);

            return profiles;

        }


        //Gets profiles by a poem
        [HttpGet("GetProfilesByPoem/{poemTitle}")]
        public List<ProfileSummary> PoemProfiles(string poemTitle)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetProfilesByPoem(poemTitle);

            List<ProfileSummary> profiles = new List<ProfileSummary>();
            profiles = returnProfileList(dsProfiles);


            return profiles;
        }

        //Gets profile by a restaurant
        [HttpGet("GetProfilesByRestaurants/{restaurant}")]
        public List<ProfileSummary> RestaurantProfiles(string restaurant)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetProfilesByRestaurants(restaurant);

            List<ProfileSummary> profiles = new List<ProfileSummary>();
            profiles = returnProfileList(dsProfiles);


            return profiles;
        } 

        //Gets profile by a movie and gender
        [HttpGet("GetPrByMovieGender/{movieTitle}/{gender}")]
        public List<ProfileSummary> GetPrByMovieGender(string movieTitle, string gender)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetPrByMoviesGender(movieTitle, gender);
            List<ProfileSummary> profiles = new List<ProfileSummary>();
            profiles = returnProfileList(dsProfiles);


            return profiles;
        }

        //Gets profile by a poem and gender
        [HttpGet("GetPrByPoemGender/{poemTitle}/{gender}")]
        public List<ProfileSummary> GetPrByPoemGender(string poemTitle, string gender)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetPrByMoviesGender(poemTitle, gender);
            List<ProfileSummary> profiles = new List<ProfileSummary>();
            profiles = returnProfileList(dsProfiles);

            return profiles;
        }

        //Gets profile by a restaurant and gender
        [HttpGet("GetPrByRestaurantGender/{restaurant}/{gender}")]
        public List<ProfileSummary> GetPrByRestaurantGender(string restaurant, string gender)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetPrByMoviesGender(restaurant, gender);
            List<ProfileSummary> profiles = new List<ProfileSummary>();
            profiles = returnProfileList(dsProfiles);

            return profiles;
        }

        //Gets all profiles by gender
        [HttpGet("GetPrByGender/{gender}")]
        public List<ProfileSummary> GetPrByGender(string gender)
        {
            DataSet dsProfiles = new DataSet();

            StoredProcedures SR = new StoredProcedures();

            dsProfiles = SR.GetPrByGender(gender);
            List<ProfileSummary> profiles = new List<ProfileSummary>();
            profiles = returnProfileList(dsProfiles);

            return profiles;
        }





        //turns the dataset into a profilelist which can be used as a model output by api
        protected List<ProfileSummary> returnProfileList(DataSet dsProfiles)
        {
            List<ProfileSummary> profiles = new List<ProfileSummary>();
            ProfileSummary PS;

            //possible that  the dataset is null, since these are queries
            if (dsProfiles.Tables[0].Rows[0] != null)
            {

                foreach (DataRow info in dsProfiles.Tables[0].Rows)
                {
                    PS = new ProfileSummary();
                    int memberID = int.Parse(info["MemberID"].ToString());

                    PS.FirstName = info["FirstName"].ToString();
                    PS.LastName = info["LastName"].ToString();
                    PS.Description = info["Description"].ToString();
                    PS.SearchQuery = info["SearchResult"].ToString();
                    PS.Gender = info["Gender"].ToString();
                    PS.State = info["State"].ToString();
                    PS.ProfilePhoto = info["ProfilePhoto"].ToString();

                    profiles.Add(PS);

                }

            }

            return profiles;
        }

    }
}