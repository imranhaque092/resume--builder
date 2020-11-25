using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebApi.Models
{
    public class TrainingInfornation
    {
        public int TrainingInfornationID { get; set; }

        public string TrainingTitle { get; set; }
        public string TopicsCoverd { get; set; }
        public string Institute { get; set; }
        public string Location { get; set; }
        public string Country { get; set; }
        public string TrainingYear { get; set; }
        public string Duration { get; set; }
    }
}
