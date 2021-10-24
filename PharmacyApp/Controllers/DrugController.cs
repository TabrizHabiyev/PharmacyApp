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

        //All drug
        public void GetAll()
        {
            Helper.InfoText("All Drugs:");
            foreach (Drug drug in drugService.GetAll())
            {
                Helper.SuggestText( $"{drug.Id} - {drug.Name}");
            }
        }
        //Drug Delete Controller
        public void Delete()
        {
            GetAll();
            Helper.SelectText("Enter drug id:");
            string input = Console.ReadLine();
            int drugId;
            bool isTrue = int.TryParse(input, out drugId);
            if (isTrue)
            {
                if (drugService.Delete(drugId) != null)
                {
                    Helper.SelectText("Drug is deleted");
                    return;
                }
                else
                {
                    Helper.SelectText($"{drugId} is not find");
                    return;
                }
            }
            else
            {
                Helper.SelectText($"Please, select correct format");
            }

        }
        public void ShowAllDrug() 
        {
            Helper.InfoText("All Drugs:");
            foreach (Drug drug in drugService.GetAll())
            {
                Helper.InfoText("Drug Category: "); Helper.SuggestText(drug.Category.Name);
                Helper.InfoText("Drug Name "); Helper.SuggestText(drug.Name);
                Helper.InfoText("Drug Price: "); Helper.SuggestText($"{drug.Price} Azn");
                Helper.InfoText("In which showcase: "); Helper.SuggestText(drug.Showcase);
                Helper.InfoText("Producer Company: "); Helper.SuggestText(drug.Company);
                Helper.InfoText("Producter Country :"); Helper.SuggestText(drug.ProducerCountry);
                Helper.InfoText("Number of drugs: "); Helper.SuggestText($"{drug.Count} \n");
            }
        }

        public void Update()
        {
            GetAll();
            Helper.SelectText("Enter group id:");
            string input = Console.ReadLine();
            Helper.SelectText("Enter new name:");
            string newName = Console.ReadLine();
            int groupId;
            bool isTrue = int.TryParse(input, out groupId);
            if (isTrue)
            {
                if (drugService.Update(groupId,newName) != null)
                {
                    Helper.SuggestText("Group is update");
                    return;
                }
                else
                {
                    Helper.DangerText($"{groupId} is not find");
                    return;
                }
            }
            else
            {
                Helper.DangerText($"Please, select correct format");
            }

        }

    }
}
