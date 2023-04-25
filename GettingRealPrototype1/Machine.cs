using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealPrototype1
{
    public class Machine
    {
        public string Interval { get; set; }

        public DateTime WeekMonthYear { get; set; }

        public string FunctionLocation { get; set; }

        public string MachineName { get; set; }

        public string Coordinates { get; set; }

        public string LubricationPoint { get; set; }

        public string LubricationType { get; set; }

        public string Volume { get; set; }
        public int MachineID { get; set; }

        public Machine(string interval, DateTime weekMonthYear, string functionLocation, string machineName, string coordinates, string lubricationPoint, string lubricationType, string volume, int machineID)
        {
            Interval = interval;
            WeekMonthYear = weekMonthYear;
            FunctionLocation = functionLocation;
            MachineName = machineName;
            Coordinates = coordinates;
            LubricationPoint = lubricationPoint;
            LubricationType = lubricationType;
            Volume = volume;
            MachineID = machineID;
        }

        public override string ToString()
        {
            return "Interval: " + Interval + "\nWeekMonthYear " + WeekMonthYear.ToShortDateString() + "\nFunction Location: " + FunctionLocation + "\nMachine Name: " + MachineName + "\nCoordinates: " + Coordinates
                + "\nLubrication Point: " + LubricationPoint + "\nLubrication Type: " + LubricationType + "\nVolume: " + Volume + "\nMachine-ID: " + MachineID + "\n";
        }
    }
}
