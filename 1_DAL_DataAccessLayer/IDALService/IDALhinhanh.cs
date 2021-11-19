using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using _1_DAL_DataAccessLayer.Models;
namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALhinhanh
    {
        public List<Hinhanh> Getlisthinhanh();
        public string Addhinhanh(Hinhanh da);
        public string Updatehinhanh(Hinhanh da);
        public string Deletehinhanh(Hinhanh id);
        public string Save();
    }
}
