using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Kindr.Enums;

namespace Kindr.Models
{
    public class CharityModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public CharityType CharityType { get; set; }

        public string ImageUrl { get; set; }

        public int Age { get; set; }

        public decimal Turnover { get; set; }

        public string OperatingArea { get; set; }

        public short NumberOfEvents { get; set; }

        public decimal FundsRaised { get; set; }

        public List<TagModel> Tags { get; set; }


        public CharityModel()
        {
            
        }

        public CharityModel(IList<TagModel> tags)
        {
            
        }
    }
}