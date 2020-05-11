using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Lesson_6.OSType;
using static Lesson_6.ProcessorType;
using static Lesson_6.ComputerManufacturer;

namespace Lesson_6
{
    class Computer : IComputer, IOverlock
    {
        #region fields and properties
        private static List<string> userNames = new List<string>()
        {
            "user",
            "admin",
            "username1337",
            "normalUserName",
            "master"
        };
        private static List<string> programList = new List<string>()
        {
            "Office 365",
            "Microsoft Edge",
            "Skype",
            "Discord",
            "Opera",
            "Steam",
            "Ccleaner",
            "Google Chrome",
            "uTorrent",
            "GitHub"
        };
        private bool _overclocked = false;

        static private Random random = new Random();
        public ProcessorType ProcessorType { get; set; }
        public ComputerManufacturer ComputerManufacturer { get; set; }
        public OSType OperationSystemType { get; set; }
        public int ProcessorCoreClock { get; set; }
        public int RAMVolume { get; set; }
        public List<string> InstalledPrograms { get; set; }
        public List<string> UserList { get; set; }
        #endregion

        #region consructors
        public Computer()
        {
            ProcessorType = Intel;
            ComputerManufacturer = HP;
            OperationSystemType = windows;
            ProcessorCoreClock = 2000;
            RAMVolume = 2048;
            InstalledPrograms = new List<string>()
            {
                "Office 365",
                "Microsft Edge",
                "Skype"
            };
            UserList = new List<string>() { "admin" };
        }
        public Computer(ProcessorType processor, ComputerManufacturer manufacturer,OSType operationSystem, int coreClock, int RAM)
        {
            ProcessorType = processor;
            ComputerManufacturer = manufacturer;
            OperationSystemType = operationSystem;
            ProcessorCoreClock = coreClock;
            RAMVolume = RAM;
            InstalledPrograms = new List<string>()
            {
                "Office 365",
                "Microsft Edge",
                "Skype"
            };
            UserList = new List<string>() { "admin" };
        }
        public Computer(ProcessorType processor, ComputerManufacturer manufacturer, OSType operationSystem, int coreClock, int RAM, List<string> programs, List<string> users)
        {
            ProcessorType = processor;
            ComputerManufacturer = manufacturer;
            OperationSystemType = operationSystem;
            ProcessorCoreClock = coreClock;
            RAMVolume = RAM;
            InstalledPrograms = programs;
            UserList = users;
        }
        #endregion

        #region methods
        public static Computer Generate()
        {
            ComputerManufacturer manufacturer = (ComputerManufacturer) random.Next(7);
            ProcessorType processor = (ProcessorType)random.Next(2);
            OSType operationSystem = (OSType)random.Next(3);
            int coreClock = (int)(1000.0 * (random.Next(1, 5) + random.NextDouble()));
            int RAM = 1024 * random.Next(1, 65);

            List<string> users = new List<string>();
            for (int i = random.Next(0, userNames.Count); i < random.Next(1, userNames.Count); i++)
                users.Add(userNames[i]);
            List<string> programs = new List<string>();
            for (int i = random.Next(0, programList.Count); i < random.Next(1, programList.Count); i++)
                programs.Add(programList[i]);

            return new Computer(processor, manufacturer, operationSystem, coreClock, RAM, programs, users);
        }
        public static List<Computer> Generate100()
        {
            List<Computer> computers = new List<Computer>();
            for (int i = 0; i < 101; i++)
                computers.Add(Generate());
            return computers;
        }
        public void OverclockTheComputer()
        {
            if (!_overclocked)
            {
                switch (ProcessorType)
                {
                    case AMD:
                        {
                            int multiplier = ProcessorCoreClock / 1000;
                            multiplier += 3;
                            ProcessorCoreClock = multiplier * 1000;
                        }
                        break;
                    case Intel:
                        {
                            int bandClock = 200;
                            bandClock += 50;
                            ProcessorCoreClock += bandClock * 2;
                        }
                        break;
                }
                _overclocked = true;
                Console.WriteLine($"Процессор успешно разогнан. Текущая тактовая частота: {ProcessorCoreClock}");
            }
            else
            {
                Console.WriteLine("Не удалось разогнать процессор. Процессор уже был разогнан.");
            }
        }
        #endregion
    }
}
