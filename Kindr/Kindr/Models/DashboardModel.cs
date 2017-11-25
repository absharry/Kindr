using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kindr.Models
{
    public class DashboardModel
    {
        public List<CharityModel> ActiveCharities { get; set; } = new List<CharityModel>();

        public List<CharityModel> SuggestedCharities { get; set; } = new List<CharityModel>();
    }
}