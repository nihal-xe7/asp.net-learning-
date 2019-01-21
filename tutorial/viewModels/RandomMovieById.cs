using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using tutorial.Models;
namespace tutorial.viewModels
{
    public class RandomMovieById
    {
        public Movie Movies { set; get; }
        public List<Customer> Customers { set; get; }  
    }
}