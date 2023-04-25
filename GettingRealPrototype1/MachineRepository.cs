using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealPrototype1
{
    public class MachineRepository
    {
        private List<Machine> machines;

        public MachineRepository()
        {
            machines = new List<Machine>();
        }

        public void AddMachine(Machine machine)
        {
            machines.Add(machine);
        }

        public Machine GetMachine(int machineID) 
        {
            foreach (var machine in machines)
            {
                if (machine.MachineID == machineID)
                {
                    return machine;
                }
            }
            return null;
        }

        public void DeleteMachine(Machine machine)
        {
            machines.Remove(machine);
        }

        public List<Machine> Sort()
        {
            return machines.OrderBy(x => DateTime.Now - x.WeekMonthYear).ToList();
        }
    }
}
