using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Threading;
using System.Text.RegularExpressions;

namespace IiPUlab3._2_battery_
{
    public partial class BatteryInfo : Form
    {
        Thread myThread;
        Battery battery; 
        public BatteryInfo()
        {
            InitializeComponent();
            battery = new Battery();
            myThread = new Thread(getBatteryStatus);
            myThread.Start();
        }
        public void getBatteryStatus()
        {
            var prePowerLineStatus = battery.GetPowerStatus();
            while (true)
            {
                PowerLineStatus.Invoke(new Action(() =>
                {
                    PowerLineStatus.Text = battery.GetPowerLineStatus(); 
                    if ((battery.GetPowerStatus() == "Online") && (prePowerLineStatus == "Offline"))
                    {
                        prePowerLineStatus = "Online";
                        battery.SetDisplayBlackout(battery.GetDefaultScreenTime());
                    }
                }
                    ));
                BatteryLifePercent.Invoke(new Action(() => BatteryLifePercent.Text = (battery.GetBatteryLifePercent() * 100).ToString() + '%'));
                BatteryLifeRemaining.Invoke(new Action(() =>
                {
                    if (battery.GetBatteryLifeReamaining() != -1) BatteryLifeRemaining.Text = (battery.GetBatteryLifeReamaining() / 60).ToString() + " min.";
                    else BatteryLifeRemaining.Text = "∞";
                }
                ));
            }
        }

        private void BlackoutTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            battery.SetDisplayBlackout(Int32.Parse(BlackoutTimeComboBox.SelectedItem.ToString()));
        }

        private void Battery_FormClosing(object sender, FormClosingEventArgs e)
        {
            myThread.Abort();
            battery.SetDisplayBlackout(battery.GetDefaultScreenTime());
        }

        private void BatteryInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
