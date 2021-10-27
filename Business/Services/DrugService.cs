using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using Utilies.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Services
{
  public  class DrugService:IDrug
    {
        private DrugRepository drugRepository { get; }
        private DrugCategoryService drugCategoryService { get; }
        private static int count;
        public DrugService()
        {
            drugRepository = new DrugRepository();
            drugCategoryService = new DrugCategoryService();
        }

        //Drug create service
        public Drug Create(Drug drug, string CategoryName)
        {
            try
            {
                DrugCategory dbGroup = drugCategoryService.Get(CategoryName);
                if (dbGroup != null)
                {
                    drug.Category = dbGroup;
                    drug.Id = count;
                    drugRepository.Create(drug);
                    count++;
                    return drug;
                }
                else
                {
                    return null;
                }
            }
            catch (ExceptionMessage)
            {

                Console.WriteLine(ExceptionMessage.DrugAddMessage);
                return null;
            }

        }
        //Drug delete service
        public Drug Delete(int Id)
        {
            try
            {
                Drug dbDrug = drugRepository.Get(g => g.Id == Id);
                if (dbDrug != null)
                {
                    drugRepository.Delete(dbDrug);
                    return dbDrug;
                }
                else
                {
                    return null;
                }
            }
            catch (ExceptionMessage)
            {
                Console.WriteLine(ExceptionMessage.DrugDeleteMessage);
                return null;
            }

        }

        //Drug Update Service
        public Drug Update(int Id,Drug updateDrug)
        {
            try
            {
                Drug dbDrug = drugRepository.Get(g => g.Id == Id);
                if (dbDrug != null)
                {
                    drugRepository.Update(dbDrug, updateDrug);
                    return dbDrug;
                }
                else
                {
                    return null;
                }
            }
            catch (ExceptionMessage)
            {
                Console.WriteLine(ExceptionMessage.DrugUpdateMessage);
                return null;
            }
    
        }

        public List<Drug> GetAll()
        {
          
            return drugRepository.GetAll();
        }
    }
}
