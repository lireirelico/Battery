using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using System.Management;

namespace IiPUlab3._2_battery_
{   
    class Battery
    {
        PowerStatus pw;
        int defaultBlackoutTime;
        public Battery()
        {
            defaultBlackoutTime = GetScreenTime();
        }
        public String GetPowerStatus()
        {
            pw = SystemInformation.PowerStatus;
            return  pw.ToString();
        }
        public string GetPowerLineStatus()
        {
            return pw.PowerLineStatus.ToString();
        }
        public float GetBatteryLifePercent()
        {
            return pw.BatteryLifePercent;
        }
        public int GetBatteryLifeReamaining()
        {
            return pw.BatteryLifeRemaining;
        }
        public int GetDefaultScreenTime()
        {
            return defaultBlackoutTime;
        }
        public int GetScreenTime()
        {
            // Запуск консоли.
            var processCmd = new Process();
            processCmd.StartInfo.UseShellExecute = false;                         //Не нужно использовать оболочку системы для запуска процесса
            processCmd.StartInfo.RedirectStandardOutput = true;                   //Нужно записывать данные приложения в поток
            processCmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;         //Стиль окна
            processCmd.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);    //Русский
            processCmd.StartInfo.FileName = "powercfg";
            processCmd.StartInfo.Arguments = "/q";
            processCmd.Start();
            var powerConfig = processCmd.StandardOutput.ReadToEnd();             //Считываем все символы с текущей позиции до конца.
            var i1 = powerConfig.IndexOf("3c0bc021-c8a8-4e07-a973-6b14cbcb2b7e");//Находим GUID Выключения экрана
            var i2 = powerConfig.IndexOf("Текущий индекс настройки питания от батарей: ", i1);
            var i3 = powerConfig.IndexOf("0x", i2);
            var currentBlackoutTime = powerConfig.Substring(i3, 10);
            return Convert.ToInt32(currentBlackoutTime, 16) / 60;
        }

        public void SetDisplayBlackout(int value)
        {
            var p = new Process();
            p.StartInfo.FileName = "powercfg";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.StartInfo.Arguments = "/SETDCVALUEINDEX SCHEME_CURRENT 7516b95f-f776-4464-8c53-06167f40cc99 3c0bc021-c8a8-4e07-a973-6b14cbcb2b7e " + value * 60;
            p.Start();
        }
    }
}
