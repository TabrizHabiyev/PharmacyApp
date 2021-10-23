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
            DrugCategoryController groupController = new DrugCategoryController();

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
                    {
                        case (int)Helper.Menu.AddNewDrugCategory:
                            groupController.Create();
                            break;
                        case (int)Helper.Menu.ShowDrugCategory:
                            groupController.GetAll();
                            break;
                        case (int)Helper.Menu.UpdateDrugCategory:
                            break;
                        case (int)Helper.Menu.DeleteDrugCategory:
                            break;
                    }
                }
            }
            static void ShowMenu()
            {
              Helper.InfoText("1- Add new Drug Category ");
              Helper.InfoText("2- Show All Drug Category ");
            }
        }
    }
}
