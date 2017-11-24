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
            var results = this.GetResultsData();
            return this.View["CharityResults"].WithModel(results);
        }

        private CharityResultsModel GetResultsData()
        {
            var results = new CharityResultsModel();
            results.Charities.Add(new Charity { Name = "Dogs Trust"});

            return results;
        }
    }
}