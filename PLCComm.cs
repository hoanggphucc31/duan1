using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Đèn_giao_thông
{
    class PLCComm
    {
        public bool tag_redled { get; set; } // doc trang thai tu PLC
        public bool tag_yellowled { get; set; } // doc trang thai tu PLC
        public bool tag_greenled { get; set; } // doc trang thai tu PLC
        public byte Bodem { get; set; } // Đọc trạng thái bộ đếm
    }
}
