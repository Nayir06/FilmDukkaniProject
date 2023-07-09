using FılmDukkanı.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.Abstract
{
    public interface IRepository<T> where T : BaseEntity
    {
        //listeleme 
        IEnumerable<T> GetAll();


        //oluşturma(create)
        string Create(T entity);

        //silme(delete)
        string Delete(T entity);

        //Güncelleme (Update)
        string update(T entity);

        //bulma (find)
        T GetById(int id);




    }
}
