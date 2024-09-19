using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FarmDAL
    {
        private List<GiaSuc> danhSachGiaSuc = new List<GiaSuc>();

        public void ThemGiaSuc(GiaSuc giaSuc)
        {
            danhSachGiaSuc.Add(giaSuc);
        }

        public List<GiaSuc> LayDanhSachGiaSuc()
        {
            return danhSachGiaSuc;
        }
    }
}
