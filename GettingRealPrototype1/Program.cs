namespace GettingRealPrototype1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Machine machine = new Machine("4U", DateTime.Parse("28-10-2002"), "functionLocation1", "machine1", "291K", "LubricationPoint1", "Hard Lubricant", "3g", 1);

            Machine machine2 = new Machine("8U", DateTime.Parse("12-02-2002"), "functionLocation2", "machine2", "437F", "LubricationPoint2", "Greasy grease", "3l", 2);

            Machine machine3 = new Machine("5U", DateTime.Parse("07-03-2002"), "functionLocation3", "machine3", "294G", "LubricationPoint3", "Soft Lubricant", "77g", 3);

            MachineRepository machineRepository = new MachineRepository();

            machineRepository.AddMachine(machine);
            machineRepository.AddMachine(machine2);
            machineRepository.AddMachine(machine3);

            List<Machine> sortedMachines = machineRepository.Sort();


            //Console.WriteLine(machine.ToString());

            //Console.WriteLine(machine2.ToString());

            foreach (var m in sortedMachines) 
            {
                Console.WriteLine(m.ToString());
            }

            Console.WriteLine(DateTime.Now - machine.WeekMonthYear);

            
        }
    }
}