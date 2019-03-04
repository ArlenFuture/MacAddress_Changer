using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;

namespace MacAddress_Changer
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme
            (
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
            MacController mac = new MacController();
            RegistryKey macRegistry = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control")
                .OpenSubKey("Class").OpenSubKey("{4D36E972-E325-11CE-BFC1-08002bE10318}");
            IList<string> list = macRegistry.GetSubKeyNames().ToList();
            for (int i = 0; i < mac.GetMACAddress().Count; i++)
            {
                for (int J = 0; J < list.Count - 1; J++)
                {
                    RegistryKey MyRegistry = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control")
        .OpenSubKey("Class").OpenSubKey("{4D36E972-E325-11CE-BFC1-08002bE10318}").OpenSubKey(list[J], true);
                    if (MyRegistry.GetValue("DriverDesc") != null)
                    {
                        if (MyRegistry.GetValue("DriverDesc").ToString() == mac.GetMACAddress()[i].Description)
                        {
                            ChooseNetworkInterfaceCard.Items.Add(mac.GetMACAddress()[i].Name);
                            string[] data = { list[J], mac.GetMACAddress()[i].Name, mac.GetMACAddress()[i].Description, mac.GetMACAddress()[i].MacAddress, mac.GetMACAddress()[i].Ip, mac.GetMACAddress()[i].Netmask };
                            var item = new ListViewItem(data);
                            InterInfoListView.Items.Add(item);
                            MyRegistry.Close();
                            //MyRegistry.SetValue("NetworkAddress", "002408B2A2D2", RegistryValueKind.String);
                            //MyRegistry.CreateSubKey("NetworkAddress");
                            break;
                        }
                    }

                }
            }

        }

        private void MacAddressChange_Btn_Click(object sender, EventArgs e)
        {
            if (ChooseNetworkInterfaceCard.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇要更改的網卡");
            }
            else
            {
                RegistryKey MyRegistry = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control")
        .OpenSubKey("Class").OpenSubKey("{4D36E972-E325-11CE-BFC1-08002bE10318}").OpenSubKey(InterInfoListView.Items[ChooseNetworkInterfaceCard.SelectedIndex].SubItems[0].Text, true);
                MyRegistry.SetValue("NetworkAddress", "002408B2A2D2", RegistryValueKind.String);
                MyRegistry.Close();
                //MessageBox.Show(InterInfoListView.Items[ChooseNetworkInterfaceCard.SelectedIndex].SubItems[0].Text);
            }
            //InterInfoListView.SelectedItems[];
        }

        private void MacAddressClear_Btn_Click(object sender, EventArgs e)
        {
            if (ChooseNetworkInterfaceCard.SelectedIndex == -1)
            {
                MessageBox.Show("請選擇要還原的網卡");
            }
            else
            {
                RegistryKey MyRegistry = Registry.LocalMachine.OpenSubKey("SYSTEM").OpenSubKey("CurrentControlSet").OpenSubKey("Control")
        .OpenSubKey("Class").OpenSubKey("{4D36E972-E325-11CE-BFC1-08002bE10318}").OpenSubKey(InterInfoListView.Items[ChooseNetworkInterfaceCard.SelectedIndex].SubItems[0].Text, true);
                MyRegistry.DeleteValue("NetworkAddress");
                MyRegistry.Close();
                //MessageBox.Show(InterInfoListView.Items[ChooseNetworkInterfaceCard.SelectedIndex].SubItems[0].Text);
            }
        }
    }
}
