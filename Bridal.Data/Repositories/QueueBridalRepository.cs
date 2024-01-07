using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Data.Repositories
{
    public class QueueBridalRepository:IQueueBridalRepository
    {
      private readonly DataContextBase _context;
        public QueueBridalRepository(DataContextBase context)
        {
            _context = context;
        }

        public List<QueueBridal> GetQueue()
        {
            return _context.QueueBridal.ToList();
        }
        public QueueBridal GetQueueById(int id)
        {
            return _context.QueueBridal.ToList().Find(q => q.Id == id);
        }
        public QueueBridal AddQueue(QueueBridal value)
        {
            _context.QueueBridal.Add(value);
            _context.SaveChanges();
            return value;
        }
        public QueueBridal UpdetQueue(int id,  DateTime value)
        {
            QueueBridal q = _context.QueueBridal.ToList().Find(q => q.Id == id);
            if (q != null)
            { q.DateQueue = value;
                _context.SaveChanges();
                return q;
            }
            return null;
        }
        public QueueBridal UpdetQueue(int id,  BridalClass value)
        {
            QueueBridal q = _context.QueueBridal.ToList().Find(q => q.Id == id);
            if (q != null)
            { q.bridal = value;
                _context.SaveChanges();
                return q;
            }
            return null;
        }

        public void DeleteQueue(int id)
        {
            QueueBridal q = _context.QueueBridal.ToList().Find(q => q.Id == id);
            if (q != null)
                _context.QueueBridal.Remove(q);
            _context.SaveChanges();
        }
    }
}
