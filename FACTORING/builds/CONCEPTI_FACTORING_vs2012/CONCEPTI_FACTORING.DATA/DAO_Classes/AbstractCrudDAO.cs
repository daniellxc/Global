using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Concepti.Factoring.Data.DAO_Interfaces;
using Concepti.Factoring.Data;
using System.Data;


namespace Concepti.Factoring.Data.DAO_Classes
{
    public abstract class AbstractCrudDAO<T> : IBaseCrudDAO<T> where T: class
    {

        #region IBaseCrudDAO<T> Members

        Contexto context = new Contexto();
       
        public void Add(T pEntity)
        {
            context.Set<T>().Add(pEntity);
            context.Configuration.LazyLoadingEnabled = true;
        }

        public void Delete(T pEntity)
        {
            context.Set<T>().Remove(pEntity);
        }

        public void Atach(T pEntity)
        {
           // context.AttachTo(pEntity.GetType().Name, pEntity);
        }

        public void Detach(T pEntity)
        {
          //  context.Detach(pEntity);
        }

        public void Update(T pEntity)
        {
           // context.ApplyCurrentValues<T>(pEntity.GetType().Name, pEntity);
       

        }


        public List<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Where(where).ToList<T>();
        }


        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void ExecuteComand(string command)
        {
            context.Database.ExecuteSqlCommand(command);
        }


     
        #endregion


        



        
    }
}
