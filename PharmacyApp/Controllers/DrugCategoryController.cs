using Business.Services;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace PharmacyApp.Controllers
{
    public class DrugCategoryController
    {
        public DrugCategoryService drugCategoryService { get; }
           
        public DrugCategoryController()
        {
            drugCategoryService = new DrugCategoryService();
        }


        //Drug Category created controller
        public void Create()
        {
        EnterName: Helper.SelectText("Enter Drug Category");
            string name = Console.ReadLine();
            
            if (name == null || name == " ")
            {
                Helper.DangerText("Please Enter correct category name");
                goto EnterName;
            }
            else
            {
                DrugCategory category = new DrugCategory();
                category.Name = name;

                if (drugCategoryService.Create(category) != null)
                {
                    Helper.SuggestText($"{category.Name} crated");
                    return;
                }
                else
                {
                    Helper.DangerText("Something is wrong!!!");
                    return;
                }
            }

        }

        //Show All Drug Category
        public void GetAll()
        {
            Helper.InfoText("All groups:");
            foreach (DrugCategory group in drugCategoryService.GetAll())
            {
                Helper.InfoText($"{group.Id} - {group.Name}");
            }
        }
    }
}
