using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kindr.Models
{
    public class BusinessModel
    {
        public string Name { get; set; }

        public List<TagModel> Tags { get; set; }

        public BusinessModel()
        {
            
        }

        public BusinessModel(IList<TagModel> tags)
        {
            
        }
    }
}