using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
            catch (Exception)
            {

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




    }
}

