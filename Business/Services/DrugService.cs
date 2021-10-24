using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
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
        public Drug Create(Drug drug, string CategoryName)
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
      
  
    }
}
