using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace ConsoleApp1
{
    class Bluetooth
    {

        public string blueName { get; set; }                  //l藍芽名字
        public BluetoothAddress blueAddress { get; set; }        //藍芽的唯一識別符號
        public ClassOfDevice blueClassOfDevice { get; set; }      //藍芽是何種型別
        public bool IsBlueAuth { get; set; }                  //指定裝置通過驗證
        public bool IsBlueRemembered { get; set; }            //記住裝置
        public DateTime blueLastSeen { get; set; }
        public DateTime blueLastUsed { get; set; }
    }

}
