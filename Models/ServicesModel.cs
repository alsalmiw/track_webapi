using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace track_webapi.Models
{
    public class ServicesModel
    {
        public int Id { get; set; }
        public string? ServiceName { get; set; }
        public string? Icon { get; set; }
        public string? Description { get; set; }

        public ServicesModel(){}

    }
}