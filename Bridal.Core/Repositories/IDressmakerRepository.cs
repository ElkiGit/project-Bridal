using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Repositories
{
    public interface IDressmakerRepository
    {
        public List<Dressmaker> GetDressmaker();
        public Dressmaker GetDressmakerById(int id);
        public Dressmaker AddDressmaker(Dressmaker dressmaker);
        public Dressmaker UpdateDressmaker(int id, Dressmaker value);
        public Dressmaker UpdateDressmaker(int id, Experience value);

        public Dressmaker UpdateDressmaker(int id, int value);
        public void DeleteDressmaker(int id);
    }
}
