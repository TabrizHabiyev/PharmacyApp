using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public static class DbContext
    {
        public static List<Drug> Drugs { get; }
        
        public static List<DrugCategory> Categories { get; }
        static DbContext()
        {
            Drugs = new List<Drug>();
            Categories = new List<DrugCategory>();
        }

    }
}
