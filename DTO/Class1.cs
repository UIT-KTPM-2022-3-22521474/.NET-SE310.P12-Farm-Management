using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class GiaSuc
    {
        public int SoLuong { get; set; }
        public abstract int SinhCon();
        public abstract string TiengKeu();
        public abstract int SoLitSua();
    }

    public class Bo : GiaSuc
    {
        public override string TiengKeu()
        {
            return "Bò kêu: Um booo";
        }

        public override int SoLitSua()
        {
            Random rand = new Random();
            return rand.Next(0, 21); // Bò cho từ 0 đến 20 lít sữa
        }

        public override int SinhCon()
        {
            Random rand = new Random();
            return rand.Next(1, 4); // Bò sinh ra từ 1 đến 3 con
        }
    }

    public class Cuu : GiaSuc
    {
        public override string TiengKeu()
        {
            return "Cừu kêu: Bê Bê";
        }

        public override int SoLitSua()
        {
            Random rand = new Random();
            return rand.Next(0, 6); // Cừu cho từ 0 đến 5 lít sữa
        }

        public override int SinhCon()
        {
            Random rand = new Random();
            return rand.Next(1, 5); // Cừu sinh từ 1 đến 4 con
        }
    }

    public class De : GiaSuc
    {
        public override string TiengKeu()
        {
            return "Dê kêu: Be Be";
        }

        public override int SoLitSua()
        {
            Random rand = new Random();
            return rand.Next(0, 11); // Dê cho từ 0 đến 10 lít sữa
        }
        public override int SinhCon()
        {
            Random rand = new Random();
            return rand.Next(1, 3); // Dê sinh từ 1 đến 2 con
        }

    }
}
