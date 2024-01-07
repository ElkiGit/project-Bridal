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
    public class DressmakerServices:IDressmakerServices
    {
        private readonly IDressmakerRepository _dressmakerRepository;

        public DressmakerServices(IDressmakerRepository dressmakerRepository)
        {
            _dressmakerRepository = dressmakerRepository;
        }
        public List<Dressmaker> GetDressmaker()
        {
            return _dressmakerRepository.GetDressmaker();
        }

        public Dressmaker GetDressmakerById(int id)
        {
            return _dressmakerRepository.GetDressmakerById(id);
        }
        public Dressmaker AddDressmaker(Dressmaker dressmaker)
        {
            return _dressmakerRepository.AddDressmaker(dressmaker);
        }
        public Dressmaker UpdateDressmaker(int id, Dressmaker value)
        {
          return _dressmakerRepository.UpdateDressmaker(id, value);
        }
        public Dressmaker UpdateDressmaker(int id, Experience value)
        {
            return _dressmakerRepository.UpdateDressmaker(id, value);
        }

        public Dressmaker UpdateDressmaker(int id, int value)
        {
            return _dressmakerRepository.UpdateDressmaker(id, value);
        }
        public void DeleteDressmaker(int id)
        {
             _dressmakerRepository.DeleteDressmaker(id);
        }
    }
}
