using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class DrugCagoryRepository : IRepository<DrugCategory>
    {
        public DrugCategory Get(Predicate<DrugCategory> filter = null)
        {
            try
            {
                return filter == null ? DbContext.Categories[0]
                    : DbContext.Categories.Find(filter);
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Drug Catecory Add
        public bool Create(DrugCategory entity)
        {
            try
            {
                DbContext.Categories.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public bool Delete(DrugCategory entity)
        {
            throw new NotImplementedException();
        }



        public List<DrugCategory> GetAll(Predicate<DrugCategory> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(DrugCategory entity)
        {
            throw new NotImplementedException();
        }
    }
}
