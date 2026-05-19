using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangDoAnNhanh
{
    public class NguoiDungBUS
    {
        private NguoiDungDAL dal = new NguoiDungDAL();

        public NguoiDung DangNhap(string user, string pass)
        {
            return dal.DangNhap(user, pass);
        }
    }
}
