using HaberSistemi.Core.Infrastucture;
using HaberSistemi.Data.DataContext;
using HaberSistemi.Data.Infrastucture;
using HaberSistemi.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberSistemi.Core.Repository
{
    public class KullanıcıRepository : IKullanıcıRepository
    {

        private readonly HaberContext _context = new HaberContext();

        public IEnumerable<HaberSistemi.Data.Model.Kullanıcı> GetAll()
        {
            return _context.Kullanıcı.Select(x => x);
        }

        public Kullanıcı GetById(int id)
        {
            return _context.Kullanıcı.FirstOrDefault(x => x.ID == id);
        }
        public Data.Model.Kullanıcı Get(System.Linq.Expressions.Expression<Func<Kullanıcı, bool>> expression)
        {
            return _context.Kullanıcı.FirstOrDefault(expression);
        }
        public IQueryable<Kullanıcı> GetMany(Expression<Func<Kullanıcı, bool>> expression)
        {
            return _context.Kullanıcı.Where(expression);
        }

        public void Insert(Kullanıcı obj)
        {
            _context.Kullanıcı.Add(obj);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Kullanıcı obj)
        {
            _context.Kullanıcı.AddOrUpdate(obj);
        }
        public int Count()
        {
            return _context.Kullanıcı.Count();
        }
        public void Delete(int id)
        {
            var Kullanıcı = GetById(id);
            if (Kullanıcı != null)
            {
                _context.Kullanıcı.Remove(Kullanıcı);
            }
        }


    }
}
