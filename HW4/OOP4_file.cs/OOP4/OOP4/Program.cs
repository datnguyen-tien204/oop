class TaiKhoan
{
    public string SoTaiKhoan { get; set; }
    public string TenKhachHang { get; set; }
    public string SoCMND { get; set; }
    public decimal SoDu { get; set; }
    public decimal LaiSuat { get; set; }
    public List<GiaoDich> GiaoDich { get; set; }

    public TaiKhoan(string soTaiKhoan, string tenKhachHang, string soCMND, decimal soDu, decimal laiSuat)
    {
        this.SoTaiKhoan = soTaiKhoan;
        this.TenKhachHang = tenKhachHang;
        this.SoCMND = soCMND;
        this.SoDu = soDu;
        this.LaiSuat = laiSuat;
        this.GiaoDich = new List<GiaoDich>();
    }

    public decimal TinhLaiSuat()
    {
        return this.SoDu * this.LaiSuat / 100;
    }
}

class KhachHang
{
    public string SoCMND { get; set; }
    public string Ten { get; set; }

    public KhachHang(string soCMND, string ten)
    {
        this.SoCMND = soCMND;
        this.Ten = ten;
    }
}

class GiaoDich
{
    public DateTime Ngay { get; set; }
    public string Loai { get; set; }
    public decimal SoTien { get; set; }

    public GiaoDich(DateTime ngay, string loai, decimal soTien)
    {
        this.Ngay = ngay;
        this.Loai = loai;
        this.SoTien = soTien;
    }
}

class NganHang
{
    private List<TaiKhoan> TaiKhoan;
    private List<KhachHang> KhachHang;

    public NganHang()
    {
        this.TaiKhoan = new List<TaiKhoan>();
        this.KhachHang = new List<KhachHang>();
    }

    public void ThemTaiKhoan(TaiKhoan taiKhoan)
    {
        this.TaiKhoan.Add(taiKhoan);
    }

    public void ThemKhachHang(KhachHang khachHang)
    {
        this.KhachHang.Add(khachHang);
    }

    public TaiKhoan TimTaiKhoan(string soTaiKhoan)
    {
        foreach (TaiKhoan taiKhoan in this.TaiKhoan)
        {
            if (taiKhoan.SoTaiKhoan == soTaiKhoan)
            {
                return taiKhoan;
            }
        }

        return null;
    }

    public KhachHang TimKhachHang(string soCMND)
    {
        foreach (KhachHang khachHang in this.KhachHang)
        {
            if (khachHang.SoCMND == soCMND)
            {
                return khachHang;
            }
        }

        return null;
    }

    public void MoTaiKhoan(string soTaiKhoan, string tenKhachHang, string soCMND, decimal soDu, decimal laiSuat)
    {
        TaiKhoan taiKhoan = new TaiKhoan(soTaiKhoan, tenKhachHang, soCMND, soDu, laiSuat);
        this.ThemTaiKhoan(taiKhoan);
    }

    public void GuiTien(string soTaiKhoan, decimal soTien)
    {
        TaiKhoan taiKhoan = this.TimTaiKhoan(soTaiKhoan);
        if (taiKhoan != null)
        {
            taiKhoan.SoDu += soTien;
            Console.WriteLine($"Gui {soTien:C} vao tai khoan {soTaiKhoan}. So du moi: {taiKhoan.SoDu:C}");
        }
        else
        {
            Console.WriteLine($"Khong tim thay tai khoan {soTaiKhoan}.");
        }
    }

    public void RutTien(string soTaiKhoan, decimal soTien)
    {
        TaiKhoan taiKhoan = this.TimTaiKhoan(soTaiKhoan);
        if (taiKhoan != null)
        {
            if (taiKhoan.SoDu >= soTien)
            {
                taiKhoan.SoDu -= soTien;
                Console.WriteLine($"Rut {soTien:C} tu tai khoan {soTaiKhoan}. So du moi: {taiKhoan.SoDu:C}");
            }
            else
            {
                Console.WriteLine($"So du khong du trong tai khoan {soTaiKhoan}.");
            }
        }
        else
        {
            Console.WriteLine($"Khong tim thay tai khoan {soTaiKhoan}.");
        }
    }

    public void TinhLaiSuat()
    {
        foreach (TaiKhoan taiKhoan in this.TaiKhoan)
        {
            taiKhoan.SoDu += taiKhoan.TinhLaiSuat();
        }
    }

    public void TaoBaoCao()
    {
        foreach (TaiKhoan taiKhoan in this.TaiKhoan)
        {
            System.Console.WriteLine("So tai khoan: {taiKhoan.SoTaiKhoan}");
            System.Console.WriteLine("Ten khach hang: {taiKhoan.TenKhachHang}");
            System.Console.WriteLine($"So du: {taiKhoan.SoDu:C}");
            foreach (GiaoDich giaoDich in taiKhoan.GiaoDich)
            {
                System.Console.WriteLine($"Ngay: {giaoDich.Ngay}");
                System.Console.WriteLine("Loai: {giaoDich.Loai}");
                System.Console.WriteLine($"So tien: {giaoDich.SoTien:C}");
            }
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Mo tai khoan cho Alice
        NganHang nganHang = new NganHang();
        nganHang.MoTaiKhoan("001", "Alice", "901", 100, 5);

        // Mo tk cho bob
        nganHang.MoTaiKhoan("002", "Bob", "902", 50, 5);

        // Mo tk cho eve
        nganHang.MoTaiKhoan("003", "Eve", "903", 200, 10);

        // Thực hiện giao dịch
        nganHang.GuiTien("004", 250);
        nganHang.RutTien("004", 40);
        nganHang.GuiTien("001", 100);
        nganHang.GuiTien("001", 100);
        nganHang.GuiTien("002", 150);
        nganHang.GuiTien("002", 150);
        nganHang.GuiTien("003", 200);
        nganHang.GuiTien("004", 250);
        nganHang.RutTien("001", 10);
        nganHang.RutTien("002", 20);
        nganHang.RutTien("003", 30);
        nganHang.RutTien("004", 40);

        // Tinh lai suat
        nganHang.TinhLaiSuat();

        // Tao bao cao
        nganHang.TaoBaoCao();
    }
}
