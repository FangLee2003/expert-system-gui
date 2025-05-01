using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace expert_system_gui
{
    class sukienxl
    {
        ketnoi kn = new ketnoi();
        public void them(sukien sk)
        {
            String sql = "insert into SuKien values('" + sk.MaSuKien + "',N'" + sk.MoTa + "',N'" + sk.LoaiSuKien+"')";
            kn.thuchien(sql);

        }
        public void sua(sukien sk)
        {
            String sql = "update SuKien set MoTa = N'"+sk.MoTa+"',LoaiSuKien='"+sk.LoaiSuKien+"' where MaSuKien='"+sk.MaSuKien+"' " ;
            
            kn.thuchien(sql);
        }
        public void xoa(String mask)
        {
            String sql = "delete from SuKien where MaSuKien ='" + mask + "'";
            kn.thuchien(sql);


        }
        public DataTable timkiem(String mask)
        {
            String sql = "select * from SuKien where MaSuKien ='" + mask + "'";
            return kn.getTable(sql);
        }
        public DataTable loadsukien()
        {
            String sql = "select * from SuKien";
            return kn.getTable(sql);
        }
    }
}
