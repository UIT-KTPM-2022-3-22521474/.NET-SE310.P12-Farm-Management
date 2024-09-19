using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FarmBLL
    {
        private FarmDAL farmDAL = new FarmDAL();

        public void ThemGiaSuc(GiaSuc giaSuc)
        {
            farmDAL.ThemGiaSuc(giaSuc);
        }

        public int TongSoGiaSuc()
        {
            return farmDAL.LayDanhSachGiaSuc().Count;
        }

        public int TongSoLitSua()
        {
            int TongLitSua = 0;
            foreach (var giasuc in farmDAL.LayDanhSachGiaSuc())
            {
                TongLitSua += giasuc.SoLitSua();
            }
            return TongLitSua;
        }

        public string TiengKeu()
        {
            StringBuilder tiengkeu = new StringBuilder();
            foreach (var giasuc in farmDAL.LayDanhSachGiaSuc())
            {
                tiengkeu.AppendLine(giasuc.TiengKeu());
            }
            return tiengkeu.ToString();
        }

        public void SinhCon()
        {
            List<GiaSuc> danhSachGiaSucHienTai = farmDAL.LayDanhSachGiaSuc();
            List<GiaSuc> giaSucMoi = new List<GiaSuc>();

            foreach (var giasuc in danhSachGiaSucHienTai)
            {
                int soCon = giasuc.SinhCon();
                for (int i = 0; i < soCon; i++)
                {
                    // Tạo con mới dựa trên loại gia súc hiện tại
                    if (giasuc is Bo)
                    {
                        giaSucMoi.Add(new Bo());
                    }
                    else if (giasuc is Cuu)
                    {
                        giaSucMoi.Add(new Cuu());
                    }
                    else if (giasuc is De)
                    {
                        giaSucMoi.Add(new De());
                    }
                }
            }

            // Thêm gia súc mới vào danh sách
            foreach (var con in giaSucMoi)
            {
                farmDAL.ThemGiaSuc(con);
            }
        }
    }
}
