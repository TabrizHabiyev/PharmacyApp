using PharmacyApp.Controllers;
using Business.Services;
using Entities.Models;
using System;
using Utilies.Helpers;

namespace AcademyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DrugCategoryController drugCategoryController = new DrugCategoryController();
            DrugController drugController = new DrugController();

            Console.WriteLine("Hello");

            while (true)
            {
                ShowMenu();
                string selectedMenu = Console.ReadLine();
                int menu;
                bool isTrue = int.TryParse(selectedMenu, out menu);
                if (isTrue && menu >= 1 && menu <= 9)
                {
                    switch (menu)
                    {           //Switch for Drug Category
                        case (int)Helper.Menu.AddNewDrugCategory:
                            drugCategoryController.Create();
                            break;
                        case (int)Helper.Menu.ShowDrugCategory:
                            drugCategoryController.GetAll();
                            break;
                        case (int)Helper.Menu.DeleteDrugCategory:
                            drugCategoryController.Delete();
                            break;
                        case (int)Helper.Menu.UpdateDrugCategory:
                            drugCategoryController.Update();
                            break;
                        //Switch for Drug
                        case (int)Helper.Menu.AddNewDrug:
                            drugController.Create();
                            break;
                        case (int)Helper.Menu.ShowAllDrug:
                            drugController.ShowAllDrug();
                            break;
                        case (int)Helper.Menu.DeleteDrug:
                            drugController.Delete();
                            break;
                        case (int)Helper.Menu.UpdateDrug:
                            drugController.Update();
                            break;
                    }
                }
            }
        }
        static void ShowMenu()
        {
            Helper.InfoText("1- Add new Drug Category:        5- Add new Drug: ");
            Helper.InfoText("2- Show All Drug Category:       6- Show all Drug: ");
            Helper.InfoText("3- Delete Drug Category:         7- Delete  Drug: ");
            Helper.InfoText("4- Update Drug Category:         8- Update  Drug: ");
        }
    }
}

