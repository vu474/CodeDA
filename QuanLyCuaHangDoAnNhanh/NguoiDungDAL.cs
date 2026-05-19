using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDoAnNhanh
{
    public class NguoiDungDAL
    {
        public NguoiDung DangNhap(string user, string pass)
        {
            string sql = @"SELECT * FROM NguoiDung 
                       WHERE tenDangNhap=@u 
                       AND matKhau=@p 
                       AND trangThai=1";

            var dt = KetNoiCSDL.GetDataTable(sql,
                new SqlParameter("@u", user),
                new SqlParameter("@p", pass));

            if (dt.Rows.Count > 0)
            {
                return new NguoiDung
                {
                    TenDangNhap = dt.Rows[0]["tenDangNhap"].ToString(),
                    VaiTro = dt.Rows[0]["vaiTro"].ToString()
                };
            }
            return null;
        }
    }
}
