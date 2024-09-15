using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinhTHPT
{
    public static class Utils
    {
        public static string MaHoa(string chuoi)
        {
            string kq = "";
            MD5 md5 = MD5.Create();
            byte[] bytechuoi = Encoding.UTF8.GetBytes(chuoi);
            byte[] bamchuoi = md5.ComputeHash(bytechuoi);
            foreach (byte b in bamchuoi)
            {
                kq += b.ToString("x2");
            }
            return kq;
        }
    }
}
