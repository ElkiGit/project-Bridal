using Bridal.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridal.Core.Services
{
    public interface IBridalServices
    {
        public BridalClass AddBridal(BridalClass bridal);

        public void DeleteBridal(int id);

        public BridalClass GetById(int id);

        public List<BridalClass> GetBridals();

        public BridalClass UpdateBridal(int id, BridalClass bridal);
        public BridalClass UpdateBridal(int id, Dressmaker value);
        public BridalClass UpdateBridal(int id, DateTime value);
       
    }
}
