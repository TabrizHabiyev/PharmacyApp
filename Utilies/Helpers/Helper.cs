using System;
using System.Collections.Generic;
using System.Text;

namespace Utilies.Helpers
{
    public static class Helper
    {

         //Colllors method
        public static void DangerText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SuggestText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void InfoText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void SelectText(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        //Enum for menu
        public enum Menu
        {

            Exit,
            AddNewDrugCategory,
            ShowDrugCategory,
            UpdateDrugCategory,
            DeleteDrugCategory,


         /*   AddNewDrug,
            UpdateDrug,
            DeleteDrug,
            GetDrugWithId,
            GetDrugWithName,
            GetAllDrug,
            GetDrugWithSize,
            CreateDrugCategory,
            GetAllDrugWithCategory */
        }
    }
}
