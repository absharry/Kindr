using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kindr.Models
{
    public class TagModel
    {
        public string Subject { get; set; }

        public string Type { get; set; }

        public string Object { get; set; }

        public int Confidence { get; set; }
    }
}