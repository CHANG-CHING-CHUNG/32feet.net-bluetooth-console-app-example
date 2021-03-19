using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BluetoothServicecs bluetooth = new BluetoothServicecs();
            Thread t = new Thread(bluetooth.DiscoverDevices);
            t.Start();

            bluetooth.lanYaList.ForEach(device =>
            {
                bluetooth.ConnectToRemoteDevice(device.blueAddress, device.blueName);
            });


        }
    }

    
}
