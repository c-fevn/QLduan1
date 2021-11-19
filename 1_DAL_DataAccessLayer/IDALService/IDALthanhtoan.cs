using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALthanhtoan
    {
        public List<Thanhtoan> Getlistthanhtoan();
        public string Addthanhtoan(Thanhtoan da);
        public string Updatethanhtoan(Thanhtoan da);
        public string Deletethanhtoan(Thanhtoan id);
        public string Save();
    }
}
