using System;
using System.Collections.Generic;

namespace expert_system_gui
{
    class luat_suy_dien
    {
        // Danh sách các sự kiện ở vế trái của luật (điều kiện)
        public List<string> ve_trai = new List<string>();

        // Danh sách các sự kiện ở vế phải của luật (kết luận)
        public List<string> ve_phai = new List<string>();

        public int do_uu_tien { get; set; } = 0; // dùng trong xử lý xung đột
    }
}
