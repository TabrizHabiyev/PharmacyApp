using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace PharmacyApp.Controllers
{
    public class DrugController
    {
        private DrugService drugService { get; }
        public DrugController()
        {
            drugService = new DrugService();
        }

        //Create Drug Controller
        public void Create()
        {

            Helper.SelectText("Enter drug category");
            string drugCategory = Console.ReadLine();

            Helper.SelectText("Enter drug name");
            string drugName = Console.ReadLine();

            Helper.SelectText("Enter drug price");
            double drugPrice = Convert.ToDouble(Console.ReadLine());

            Helper.SelectText("Drug showcase");
            string showcase = Console.ReadLine();

            Helper.SelectText("Medicine company");
            string company = Console.ReadLine();

            Helper.SelectText("Drug country");
            string country = Console.ReadLine();

            Helper.SelectText("Drug count");
            int count = int.Parse(Console.ReadLine());


            Drug drug = new Drug {Name = drugName,Price = drugPrice , 
            Showcase =showcase,Company = company,ProducerCountry = country , Count = count };

            Drug drugnew = drugService.Create(drug,drugCategory);

            if (drugnew != null)
            {
                Helper.SuggestText($"New Drug is Created - {drug.Name}");
                return;
            }
            Helper.DangerText($"Couldn't find such as Category - {drugCategory}");
        }
    }
}
