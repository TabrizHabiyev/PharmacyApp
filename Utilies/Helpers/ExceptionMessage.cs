using System;
using System.Collections.Generic;
using System.Text;
namespace Utilies.Helpers
{
   public class ExceptionMessage:Exception
    {
        public static string DrugAddMessage = "Drug cannot created";
        public static string DrugDeleteMessage = "Drug cannot delete";
        public static string DrugUpdateMessage = "Drug cannot update";

        public static string CategoryAddMessage = "Category cannot created";
        public static string CategoryDeleteMessage = "Category cannot delete";
        public static string CategoryUpdateMessage = "Category cannot update";
        public ExceptionMessage(string ex):base(ex)
        {

        }
        public ExceptionMessage()
        {

        }
    }
}
