using System;

namespace vanphong
{

    public class CANBO
    {
        string MaCanBo, HoTen, ChucVu, PhongBan;
        int SoLuong;

        public CANBO()
        {
            MaCanBo = "";
            HoTen = "";
            ChucVu = " ";
            PhongBan = " ";
            SoLuong = 0;
        }
        public CANBO(string m,string h,string c,string p,int s)
        {
            this.MaCanBo = m;
            this.HoTen = h;
            this.ChucVu = c;
            this.SoLuong = s;
        }
        public void nhap(CANBO cb)
        {
            Console.Write("nhap ma can bo:");
            cb.MaCanBo = Console.ReadLine();
            Console.Write("nhap ho ten:");
            cb.HoTen = Console.ReadLine();
            Console.Write("nhap chuc vu:");
            cb.ChucVu = Console.ReadLine();
            Console.Write("nhap ten phong ban:");
            cb.PhongBan = Console.ReadLine();
            Console.Write("nhap so luong:");
            cb.SoLuong = Convert.ToInt32(Console.ReadLine());
        }
        public void xuat(CANBO cb)
        {
            Console.WriteLine("ma can bo:" + cb.MaCanBo);
            Console.WriteLine("ho ten can bo:" + cb.HoTen);
            Console.WriteLine("chuc vu:" + cb.ChucVu);
            Console.WriteLine("phong ban:" + cb.PhongBan);
            Console.WriteLine("so luong:" + cb.SoLuong);

        }
        public void tk(CANBO cb)
        {
            if(cb.PhongBan != "hanh chinh")
            {
                cb.xuat(cb);
            }
        }
       
    }
    public class DANHSACH : CANBO
    {
        CANBO[] ds;
        int n;
        public void nhapds()
        {
            Console.Write("nhap so luong can bo:");
            n = Convert.ToInt32(Console.ReadLine());
            ds = new CANBO[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("so luong can bo thu:", i + 1);
                ds[i] = new CANBO();
                base.nhap(ds[i]);

            }
        }
        public void xuatds()
        {
            Console.WriteLine("hien thi noi dung");
            for (int i = 0; i < n; i++)
            {
                base.xuat(ds[i]);
            }

        }
        public void tkds()
        {
            Console.WriteLine("nhan vien khong o phong hanh chinh:");
            for (int i = 0; i < n; i++)
            {
                base.tk(ds[i]);
            }
        }

    
     }
    class Program
    {
        static void Main(string[] args)
        {
            DANHSACH d = new DANHSACH();
            d.nhapds();
            d.xuatds();
            d.tkds();
        }
    }
}


