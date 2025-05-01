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
    class luatxl
    {
        ketnoi kn = new ketnoi();
        public void them(luat l)
        {
            string sql = "INSERT INTO TapLuat (MaLuat, NoiDung, DoUuTien) VALUES('" + l.MaLuat + "',N'" + l.NoiDung + "'," + l.DoUuTien + ")";
            kn.thuchien(sql);
        }

        public void sua(luat l)
        {
            string sql = "UPDATE TapLuat SET NoiDung = N'" + l.NoiDung + "', DoUuTien = " + l.DoUuTien + " WHERE MaLuat = '" + l.MaLuat + "'";
            kn.thuchien(sql);
        }

        public void xoa(String mal)
        {
            String sql = "delete from TapLuat where MaLuat ='" + mal + "'";
            kn.thuchien(sql);


        }
        public DataTable timkiem(String mal)
        {
            String sql = "select * from TapLuat where MaLuat ='" + mal + "'";
            return kn.getTable(sql);
        }
        public DataTable loadluat()
        {
            string sql = "SELECT * FROM TapLuat ORDER BY DoUuTien DESC";
            return kn.getTable(sql);
        }

    }
}
