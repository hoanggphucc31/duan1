using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using SymbolFactoryDotNet;


namespace Đèn_giao_thông
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Them PLC 
        Plc _PLC = new Plc(CpuType.S71200, "192.168.1.30", 0, 0);
        PLCComm _PLCComm = new PLCComm();

        // chuong trinh hien thi trang thai den
        private void dengiaothong(StandardControl ob, bool Value)
        {
            if(Value == false)
            {
                ob.DiscreteValue1 = true;
                ob.DiscreteValue2 = false;               
            }
            
            else
            {
                ob.DiscreteValue1 = false;
                ob.DiscreteValue2 = true;
            }
        }
        private void standardControl2_Load(object sender, EventArgs e)
        {
            
        }

        private void standardControl1_Load(object sender, EventArgs e)
        {

        }

        private void standardControl3_Load(object sender, EventArgs e)
        {

        }
        // form load 
        private void Form1_Load(object sender, EventArgs e)
        {
            if (_PLC.Open() == ErrorCode.NoError)
            {
                timer1.Enabled = true; // Bật timer
                timer1.Interval = 1000; // 1 giây cập nhật 1 lần

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _PLC.ReadClass(_PLCComm, 1); // đọc dữ liệu DB1
            dengiaothong(redled, _PLCComm.tag_redled);
            dengiaothong(yellowled,_PLCComm.tag_yellowled);
            dengiaothong(greenled,_PLCComm.tag_greenled);
        }
    }
}
