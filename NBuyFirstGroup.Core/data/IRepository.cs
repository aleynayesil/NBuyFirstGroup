using NBuyFirstGroup.Core.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBuyFirstGroup.Core.data
{
    //abstract classtan kalıtım alan bir şeye ancak repositoryi uygulanabilir
    public interface IRepository<TEntity> where TEntity:Entity
    {
        void Add(TEntity entity);
        void Remove(string Id);
        void Update(TEntity entity);

        IQueryable<TEntity> GetQuery();
        TEntity Find(string Id);
        IQueryable GetSqlRawQuery(string query);//joinlendiğinde dçönecek nesne belli olmadığı için sadece ıquerable
    }
}
