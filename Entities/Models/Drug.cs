using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Models
{
  public  class Drug:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Showcase { get; set; }
        public string Company { get; set; }
        public string ProducerCountry { get; set; }
        public DrugCategory Category { get; set; }
    }
}
