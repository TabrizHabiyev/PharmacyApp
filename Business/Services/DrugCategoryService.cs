using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Utilies.Helpers;

namespace Business.Services
{
    public class DrugCategoryService :IDrugCategory
    {
        public DrugCagoryRepository drugCagoryRepository { get; set; }

        private static int count { get; set; }

        public DrugCategoryService()
        {
            drugCagoryRepository = new DrugCagoryRepository();
        }


        //Drug Catecory create
        public DrugCategory Create(DrugCategory catecory)
        {
            try
            {
                catecory.Id = count;
                DrugCategory isExist =
                    drugCagoryRepository.Get(g => g.Name.ToLower() == catecory.Name.ToLower());
                if (isExist != null)
                    return null;
                drugCagoryRepository.Create(catecory);
                count++;
                return catecory;
            }
            catch (ExceptionMessage)
            {
                Console.WriteLine(ExceptionMessage.CategoryAddMessage);
                return null;
            }
        }

        public DrugCategory Get(string Name)
        {
            return drugCagoryRepository.Get(g => g.Name.ToLower() == Name.ToLower());
        }


        public List<DrugCategory> GetAll()
        {
            return drugCagoryRepository.GetAll();
        }

        //Delete Drug Category 
        public DrugCategory Delete(int Id)
        {
            try
            {
                DrugCategory dbGroup = drugCagoryRepository.Get(g => g.Id == Id);
                if (dbGroup != null)
                {
                    drugCagoryRepository.Delete(dbGroup);
                    return dbGroup;
                }
                else
                {
                    return null;
                }
            }
            catch (ExceptionMessage)
            {

                Console.WriteLine(ExceptionMessage.CategoryDeleteMessage);
                return null;
            }
    
        }

        //Update Drug Category
        public DrugCategory Update(int Id ,string NewName)
        {
            try
            {
                DrugCategory dbGroup = drugCagoryRepository.Get(g => g.Id == Id);
                if (dbGroup != null)
                {
                    drugCagoryRepository.Update(dbGroup, NewName);
                    return dbGroup;
                }
                else
                {
                    return null;
                }
            }
            catch (ExceptionMessage)
            {
                Console.WriteLine(ExceptionMessage.CategoryUpdateMessage);
                return null;
            }

        }

    }
}

