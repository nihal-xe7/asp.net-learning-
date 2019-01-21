using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tutorial.Models
{
    public class Movie
    {
        public int id = 0;
        public string name = null;
        public int Id {
            get { return this.id; }
            set { this.id=value; }
        }

        public string Name {
            get { return this.name; }
            set { this.name=value; }
        }
    }
}