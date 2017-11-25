using Kindr.Models;
using Nancy;
using System.Collections.Generic;
using System.Web;
using System.Linq;

namespace Kindr.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule() : base("/")
        {
            Get["/"] = x => GetHome();
            Get["/business_login"] = x => GetBusinessLogin();
            Get["/charity_details/{id}"] = x => GetCharityDetails(x.id);
            Get["/dashboard"] = x => GetDashboard();
        }

        public dynamic GetHome()
        {
            ViewBag.Title = "Home";
            return this.View["Home"];
        }

        public dynamic GetBusinessLogin()
        {
            return this.View["BusinessLogin"];
        }

        public dynamic GetCharityDetails(int id)
        {
            ViewBag.Title = "Charity Details";
            var model = GetResultsData(id);
            return this.View["CharityDetails"].WithModel(model);
        }

        public dynamic GetDashboard()
        {
            var model = GetResultsData();

            var newModel = new DashboardModel()
            {
                ActiveCharities = model.Take(2).ToList(),
                SuggestedCharities = model.Skip(2).ToList()
            };

            return this.View["Dashboard"].WithModel(newModel);
        }

        private List<CharityModel> GetResultsData()
        {
            return (List<CharityModel>)HttpContext.Current.Application["CharityModels"];
        }

        private CharityModel GetResultsData(int id)
        {
            var charities = (IList<CharityModel>)HttpContext.Current.Application["CharityModels"];
            var charity = charities.FirstOrDefault(e => e.Id == id);
            return charity;
        }
    }
}