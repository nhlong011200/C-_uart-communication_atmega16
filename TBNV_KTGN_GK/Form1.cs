using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace TBNV_KTGN_GK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] pause = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "14880" };
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] listnamecom = SerialPort.GetPortNames();//quét tên các cổng com add vào listnamecom
            listcom.Items.AddRange(listnamecom);//sau quét tên các cổng com thì add nó vào combobox tên listcom
            listbaudrate.Items.AddRange(pause);//add các giá trị baud vào combobox tên listbaudrate
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listcom.Text == "")//kiểm tra cổng COM xem có được kết nối chưa
            {
                MessageBox.Show("Bạn chưa chọn cổng COM","Thông Báo");//đưa ra thông báo là chưa chọn cổng

            }    
            else if (listbaudrate.Text == "")//kiểm tra công baud được chọn chưa
            {
                MessageBox.Show("Bạn chưa chọn tốc độ Baud","Thông Báo");

            }    
            if(serialPort1.IsOpen )//nếu port đã kết nối rồi
            {
                serialPort1.Close();//nếu nó đang kết nối thì đóng nó lại
                button1.Text = "Connect";//hiển thị chữ Connect khi ngắt kết nối chỉ cần nhấn vào

            }    
            else
            {
                serialPort1.PortName = listcom.Text; //chọn com bao nhieeu gán vô serial portname
                serialPort1.BaudRate = int.Parse(listbaudrate.Text);
                serialPort1.Open();
                button1.Text = "Disconnect";

            }    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        bool tb1 = true;
        private void den_Click(object sender, EventArgs e)
        {
            try 
            {
                if(tb1 == true)
                {
                    serialPort1.Write("a");
                    den.Text = "ON";
                    imgden.Image = global::TBNV_KTGN_GK.Properties.Resources.denon;
                    tb1 = false;
                }    
                else
                {
                    serialPort1.Write("b");
                    den.Text = "OFF";
                    imgden.Image = global::TBNV_KTGN_GK.Properties.Resources.den;
                    tb1 = true;

                }    
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }
        bool tb2 = true;
        private void quat_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb2 == true)
                {
                    serialPort1.Write("c");
                    quat.Text = "ON";
                    imgquat.Image = global::TBNV_KTGN_GK.Properties.Resources.quaton;
                    tb2 = false;
                }
                else
                {
                    serialPort1.Write("d");
                    quat.Text = "OFF";
                    imgquat.Image = global::TBNV_KTGN_GK.Properties.Resources.quat;
                    tb2 = true;

                }
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string temprature = serialPort1.ReadLine().ToString();
            try
            {
                BeginInvoke(new Action(() =>
                {
                    nhietdo.Text = temprature.ToString();
                }));
            }
            catch (Exception)
            {

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /* bool str = true;
private void btstart_Click(object sender, EventArgs e)
{
    try
    {
        if (str == true)
        {
            serialPort1.Write("s");//truyền tín hiệu a sẽ bật quạt
            quat.Text = "ON";
            imgquat.Image = global::TBNV_KTGN_GK.Properties.Resources.quaton;
            den.Text = "ON";
            imgden.Image = global::TBNV_KTGN_GK.Properties.Resources.denon;
            str = false;
        }
    }
    catch
    {

    }
}
bool stp = true;
private void btstop_Click(object sender, EventArgs e)
{
    if(stp == true)
    {
        serialPort1.Write("r");//truyền tín hiệu a sẽ bật quạt
        quat.Text = "OFF";
        imgquat.Image = global::TBNV_KTGN_GK.Properties.Resources.quat;
        den.Text = "OFF";
        imgden.Image = global::TBNV_KTGN_GK.Properties.Resources.den;
        str = false;

    }
}*/
    }
}
