using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Services
{
    public interface IQueueBridalServices
    {
        public List<QueueBridal> GetQueue()
;
        public QueueBridal GetQueueById(int id)
;
        public QueueBridal AddQueue(QueueBridal value)
;
        public QueueBridal UpdetQueue(int id, DateTime value)
;
        public QueueBridal UpdetQueue(int id, BridalClass value)
;

        public void DeleteQueue(int id)
;
    }
}
