using Bridal.Core.Entities;
using Bridal.Core.Repositories;
using Bridal.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Service
{
    public class QueueBridalServices:IQueueBridalServices
    {
        private readonly IQueueBridalRepository _queueBridalRepository;
        public QueueBridalServices(IQueueBridalRepository queueBridalRepository)
        {
            _queueBridalRepository = queueBridalRepository;
        }

        public List<QueueBridal> GetQueue()
        {
            return _queueBridalRepository.GetQueue();
        }
        public QueueBridal GetQueueById(int id)
        {
            return _queueBridalRepository.GetQueueById(id);
        }
        public QueueBridal AddQueue(QueueBridal value)
        {
            return _queueBridalRepository.AddQueue(value);
        }
        public QueueBridal UpdetQueue(int id, DateTime value)
        {
            return _queueBridalRepository.UpdetQueue(id,value);
        }
        public QueueBridal UpdetQueue(int id, BridalClass value)
        {
          return _queueBridalRepository.UpdetQueue(id,value);  
        }

        public void DeleteQueue(int id)
        {
            _queueBridalRepository.DeleteQueue(id);
        }
    }
}
