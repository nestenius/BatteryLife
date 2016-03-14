using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Benchcode.BatteryLife
{
    [StructLayout(LayoutKind.Sequential)]
    public class PowerState
    {
        public ACLineStatus ACLineStatus;
        public BatteryFlag BatteryFlag;
        public Byte BatteryLifePercent;
        public Byte Reserved1;
        public Int32 BatteryLifeTime;
        public Int32 BatteryFullLifeTime;
        public Byte Reserved2;
        public Byte BackupBatteryFlag;
        public Byte BackupBatteryLifePercent;
        public Byte Reserved3;
        public Int32 BackupBatteryLifeTime;
        public Int32 BackupBatteryFullLifeTime;
        public Int32 BatteryVoltage;
        public Int32 BatteryCurrent;
        public Int32 BatteryAverageCurrent;
        public Int32 BatteryAverageInterval;
        public Int32 BatterymAHourConsumed;
        public Int32 BatteryTemperature;
        public Int32 BackupBatteryVoltage;
        public Byte BatteryChemistry;

        // direct instantation not intended, use GetPowerState.
        private PowerState() { }

        public static PowerState GetPowerState()
        {
            PowerState state = new PowerState();
            if (GetSystemPowerStatusRef(state))
                return state;

            throw new ApplicationException("Unable to get power state");
        }

        [DllImport("Kernel32", EntryPoint = "GetSystemPowerStatus")]
        private static extern bool GetSystemPowerStatusRef(PowerState sps);
    }

    // Note: Underlying type of byte to match Win32 header
    public enum ACLineStatus : byte
    {
        Offline = 0, Online = 1, Unknown = 255
    }

    public enum BatteryFlag : byte
    {
        High = 1, Low = 2, Critical = 4, Charging = 8,
        NoSystemBattery = 128, Unknown = 255
    }

    
}
