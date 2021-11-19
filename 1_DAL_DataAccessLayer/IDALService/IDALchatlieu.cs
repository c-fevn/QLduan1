using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccessLayer.Models;

namespace _1_DAL_DataAccessLayer.IDALService
{
    public interface IDALchatlieu
    {
        public List<Chatlieu> Getlistchatlieu();
        public string Addchatlieu(Chatlieu da);
        public string Updatechatlieu(Chatlieu da);
        public string Deletechatlieu(Chatlieu id);
        public string Save();
    }
}
