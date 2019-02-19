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
            materialSkinManager.ColorScheme = new ColorScheme(
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
                            ChooseNetworkInterfaceCard.Items.Add(mac.GetMACAddress()[i].MacAddress);
                            //MyRegistry.SetValue("NetworkAddress", "002408B2A2D2", RegistryValueKind.String);
                            //MyRegistry.CreateSubKey("NetworkAddress");
                            break;
                        }
                    }

                }
            }
        }
    }
}
