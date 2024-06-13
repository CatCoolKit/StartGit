using Quanlysinhvien_01.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data.SqlClient;

namespace Quanlysinhvien_01.DAL
{
    public class DAL_TaiKhoan
    {
        private static DAL_TaiKhoan instance; // ctr + r + e

        public static DAL_TaiKhoan Instance
        {
            get { if (instance == null) instance = new DAL_TaiKhoan(); return instance; }
            private set => instance = value;
        }

        private DAL_TaiKhoan() { }


        public bool Them(string ten, string matkhau, string loai)
        {
            string sql = "insert into TaiKhoan(TenDangNhap, MatKhau, LoaiTaiKhoan) values( @TenDangNhap , @MatKhau , @LoaiTaiKhoan )";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ten, matkhau, loai });
        }


        public bool Sua_Het(string ten, string matkhau, string loai, int id) {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , MatKhau = @MatKhau , LoaiTaiKhoan = @LoaiTaiKhoan where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] {ten, matkhau, loai, id });
        }

        public bool KhongSuaMatKhau(string ten, string loai, int id)
        {
            string sql = "update TaiKhoan set TenDangNhap = @TenDangNhap , LoaiTaiKhoan = @LoaiTaiKhoan where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { ten, loai, id });
        }

        public bool Xoa(int id) {
            string sql = "delete from TaiKhoan where id = @id";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { id });
        }

        public DataTable DanhSach()
        {
            return KetNoi.Instance.ExecuteQuery("select * from TaiKhoan");
        }
        public DataTable DangNhap(string ten, string matkhau) {
            string sql = "select * from TaiKhoan where TenDangNhap = @TenDangNhap and MatKhau = @MatKhau";
            return KetNoi.Instance.ExecuteQuery(sql, new object[] { ten, matkhau});
        }
        public bool DoiMatKhau(string ten, string matkhaumoi, string matkhaucu) {
            string sql = "update TaiKhoan set MatKhau = @MatKhauMoi where TenDangNhap = @TenDangNhap and MatKhau = @MatKhauCu";
            return KetNoi.Instance.ExecuteNonQuery(sql, new object[] { matkhaumoi, ten, matkhaucu});
        }

    }
}
