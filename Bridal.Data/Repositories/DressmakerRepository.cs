using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data.Repositories
{
    public class DressmakerRepository: IDressmakerRepository
    {
        private readonly DataContextBase _context;

        public DressmakerRepository(DataContextBase context)
        {
            _context = context;
        }
        public List<Dressmaker> GetDressmaker()
        {
            return _context.Dressmaker.ToList();
        }
     
        public Dressmaker GetDressmakerById(int id)
        {
            return _context.Dressmaker.ToList().Find(d => d.Id == id);
        }
        public Dressmaker AddDressmaker(Dressmaker dressmaker)
        {
            _context.Dressmaker.Add(dressmaker);
            _context.SaveChanges();
            return dressmaker;
        }
        public Dressmaker UpdateDressmaker(int id,Dressmaker value)
        {
            Dressmaker dressmaker =_context.Dressmaker.ToList().Find(d => d.Id == id);
            if (dressmaker != null)
            { dressmaker.Name = value.Name; 
                dressmaker.Status = value.Status;
                dressmaker.experience = value.experience;
                _context.SaveChanges();
                return dressmaker;
            }
            return null;
        }
        public Dressmaker UpdateDressmaker(int id,Experience value)
        {
            Dressmaker dressmaker = _context.Dressmaker.ToList().Find(d => d.Id == id);
            if (dressmaker != null)
            { dressmaker.experience = value;
                _context.SaveChanges();
                return dressmaker;
            }
            return null;
        }

        public Dressmaker UpdateDressmaker(int id,  int value)
        {
            Dressmaker dressmaker = _context.Dressmaker.ToList().Find(d => d.Id == id);
            if (dressmaker != null) 
            {  
                dressmaker.Status = value;
                _context.SaveChanges();
                return dressmaker;
            }
            return null;
        }
        public void DeleteDressmaker(int id)
        {
            _context.Dressmaker.Remove(_context.Dressmaker.ToList().Find(b => b.Id == id));
            _context.SaveChanges();
        }
    }
}
