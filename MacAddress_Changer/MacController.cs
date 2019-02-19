using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace MacAddress_Changer
{
    class MacController
    {
        public class Mac
        {
            public string NetworkAddress { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string MacAddress { get; set; }
            public string Ip { get; set; }
            public string Netmask { get; set; }
        }
        public List<Mac> GetMACAddress()
        {
            List<Mac> MacList = new List<Mac>();
            //得到註冊表的MAC位置
            RegistryKey macRegistry = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control")
                .OpenSubKey("Class").OpenSubKey("{4D36E972-E325-11CE-BFC1-08002bE10318}");
            IList<string> list = macRegistry.GetSubKeyNames().ToList();

            //IPGlobalProperties computerProperties = IPGlobalProperties.GetIPGlobalProperties();
            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in nics)
            {
                if (adapter.NetworkInterfaceType.ToString().Equals("Ethernet") || adapter.NetworkInterfaceType.ToString().Equals("Wireless80211"))//有線乙太跟WIFI
                {
                    //取得IPInterfaceProperties(可提供網路介面相關資訊)
                    IPInterfaceProperties ipProperties = adapter.GetIPProperties();
                    string Temp = null;
                    if (ipProperties.UnicastAddresses.Count > 0)
                    {

                        MacList.Add(new Mac
                        {
                            NetworkAddress = list.Count.ToString().PadLeft(4, '0'),
                            Name = adapter.Name,
                            Description = adapter.Description
                            ,
                            MacAddress = adapter.GetPhysicalAddress().ToString(),
                            Ip = ipProperties.UnicastAddresses[0].Address.ToString()
                            ,
                            Netmask = ipProperties.UnicastAddresses[0].IPv4Mask.ToString()
                        }
                        );
                        PhysicalAddress MacAdd = adapter.GetPhysicalAddress();                     //取得Mac Address
                        string Name = adapter.Name;                                             //網路介面名稱
                        string Description = adapter.Description;                               //網路介面描述
                        string Ip = ipProperties.UnicastAddresses[0].Address.ToString();        //取得IP
                        string Netmask = ipProperties.UnicastAddresses[0].IPv4Mask.ToString();  //取得遮罩

                        Console.WriteLine("{0,13:S}{1,18:S}{2,18:S}", MacAdd, Ip, Netmask);
                        Temp += Name + Description + MacAdd + Ip + Netmask;
                    }

                }

            }
            return MacList;
        }
        public void SetMac(string mac)
        {
            RegistryKey HKLM = Registry.LocalMachine;
            RegistryKey Reg = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control")
                .OpenSubKey("Class").OpenSubKey("{4D36E972-E325-11CE-BFC1-08002bE10318}");
        }
    }
}
