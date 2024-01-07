using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data.Repositories
{
    public class BridalRepository:IBridalRepository
    {
        private readonly DataContextBase _context;

        public BridalRepository(DataContextBase context)
        {
            _context = context;
        }

        public BridalClass AddBridal(BridalClass bridal)
        {
            _context.Bridal.Add(bridal);
            _context.SaveChanges();
            return bridal;
        }

        public void DeleteBridal(int id)
        {
            _context.Bridal.Remove(_context.Bridal.ToList().Find(b => b.Id == id));
            _context.SaveChanges();
        }

        public BridalClass GetById(int id)
        {
            return _context.Bridal.ToList().Find(b => b.Id == id);
        }

        public List<BridalClass> GetBridals()
        {
            return _context.Bridal.ToList();
        }

        public BridalClass UpdateBridal(int id, BridalClass bridal)
        {
            var updateBridal = _context.Bridal.ToList().Find(u => u.Id == id);
            if (updateBridal != null)
            {
                updateBridal.Name = bridal.Name;
                updateBridal.dressmaker = bridal.dressmaker;
                updateBridal.DateWedding = bridal.DateWedding;
                updateBridal.Phone = bridal.Phone;
                _context.SaveChanges();
                return updateBridal;
            }
            return null;
        }
        public BridalClass UpdateBridal(int id, Dressmaker value)
        {
            var updateBridal = _context.Bridal.ToList().Find(u => u.Id == id);
            if (updateBridal != null)
            {
                updateBridal.dressmaker = value;
                _context.SaveChanges();
                return updateBridal;
            }
            return null;
        }
        public BridalClass UpdateBridal(int id,  DateTime value)
        {
            var updateBridal = _context.Bridal.ToList().Find(u => u.Id == id);
            if (updateBridal != null)
            {
                updateBridal.DateWedding=value;
                _context.SaveChanges();
                return updateBridal;
            }
            return null;
        }

    }
}
