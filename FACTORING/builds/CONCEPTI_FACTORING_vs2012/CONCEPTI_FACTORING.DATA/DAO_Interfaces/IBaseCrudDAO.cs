using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace Concepti.Factoring.Data.DAO_Interfaces
{
    public interface IBaseCrudDAO<T>
    {
        void Add(T pEntity);    //Persiste uma entidade
        void Delete(T pEntity); //Deleta uma entidade
        void Atach(T pEntity);
        void Detach(T pEntity);
        void Update(T pEntity); //Atualiza uma entidade
        List<T> Find(Expression<Func<T, bool>> where); //Busca uma entidade passando uma expressão lambda
        IQueryable<T> GetAll(); //Retorna todas as ocorrências de uma entidade
        void SaveChanges(); //Salva alterações, já que o Entity Framework não é AutoCommited

    }
}
