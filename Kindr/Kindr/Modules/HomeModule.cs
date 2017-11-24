using Kindr.Models;
using Nancy;
using System.Collections.Generic;
using System.Web;

namespace Kindr.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule() : base("/")
        {
            Get["/"] = x => GetHome();
            Get["/business_login"] = x => GetBusinessLogin();
            Get["/charity_details"] = x => GetCharityDetails();
        }

        public dynamic GetHome()
        {
            return this.View["Home"];
        }

        public dynamic GetBusinessLogin()
        {
            return this.View["BusinessLogin"];
        }

        public dynamic GetCharityDetails()
        {
            return this.View["CharityDetails"] ;
        }

        private List<CharityModel> GetResultsData()
        {
            return (List<CharityModel>)HttpContext.Current.Application["CharityModels"];
        }
    }
}