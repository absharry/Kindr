using Kindr.Models;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kindr.Modules
{
    /// <summary>
    /// This is where you get all the information on the 'Results' Page :D
    /// </summary>
    public class CharityResultsModule : NancyModule
    {
        public CharityResultsModule()
        {
            Get["/results"] = x => GetResults();
        }

        public dynamic GetResults()
        {
            var results = GetResultsData();

            return this.View["CharityResults"].WithModel(results);
        }

        private List<CharityModel> GetResultsData()
        {
            return (List<CharityModel>)HttpContext.Current.Application["CharityModels"];
        }
    }
}