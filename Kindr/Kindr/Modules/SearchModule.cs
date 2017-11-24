using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kindr.Modules
{
    /// <summary>
    /// this is where you get the information displayed on the search from :D
    /// </summary>
    public class SearchModule: NancyModule
    {
        public SearchModule()// base("/")
        {
            Get["/Search"] = x => GetSearch();
        }
        public dynamic GetSearch()
        {
            return this.View["Search"];
        }
    }
}