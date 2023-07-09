using FılmDukkanı.BLL.Abstract;
using FilmDukkanı.DAL.Context;
using FılmDukkanı.Entity.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FılmDukkanı.BLL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly FılmDukkanıContext _context;
        private readonly DbSet<T> _entities;

        public BaseRepository(FılmDukkanıContext context)
        {
            _context = context;
        }
        public string Create(T entity)
        {
            try
            {
                //hata almamak için try catch acıldı    
                _entities.Add(entity);
                _context.SaveChanges();

                return "kayıt olundu";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }

        public string Delete(T entity)
        {
            var deleted = GetById(entity.Id);
            _entities.Remove(deleted);
            _context.SaveChanges();
            return "veri silindi!"; 
        }

        public IEnumerable<T> GetAll()
        {
            return
        }

        public T GetById(int id)
        {
            
        }

        public string update(T entity)
        {
            
        }
    }
}
