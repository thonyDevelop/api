using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace api.Model
{
    public class Damage
    {
        public int user_id { get; set; }
        public string? observation { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Images[]? images { get; set; }
    }

    public class Images
    {
        public string? image { get; set; }
    }

    public class ResponseDamage
    {
        public string? message { get; set; }
        public int status { get; set; }
    }
}
