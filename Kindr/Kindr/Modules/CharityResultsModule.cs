using Kindr.Models;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kindr.Modules
{
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

        private CharityResultsViewModel GetResultsData()
        {
            var results = new CharityResultsViewModel();
            results.Charities.Add(new CharityModel { Name = "Dogs Trust"});
            results.Charities.Add(new CharityModel { Name = "Cat 4 Life" });

            return results;
        }
    }
}