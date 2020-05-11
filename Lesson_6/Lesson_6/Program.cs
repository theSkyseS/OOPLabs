using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Lesson_6.ProcessorType;
using static Lesson_6.ComputerManufacturer;
using static Lesson_6.OSType;

namespace Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 2
            List<Computer> computers = Computer.Generate100();
            var computerQuery1 =
                from computer in computers
                where computer.ProcessorType != AMD
                select computer;

            var computerQuery2 =
                from computer in computers
                where computer.ProcessorType != Intel
                where computer.ComputerManufacturer != Dell
                select computer;

            var computerQuery3 =
                from computer in computers
                where computer.UserList.Contains("admin")
                where computer.RAMVolume > 2047
                select computer;
            #endregion

            #region Task 3
            var computerSort1 =
                from computer in computers
                orderby computer.ProcessorType
                select computer;

            var computerSort2 =
                from computer in computers
                orderby computer.ProcessorType
                orderby computer.ComputerManufacturer
                select computer;
            #endregion

            #region Task 4
            var computerClocks1 =
                from computer in computers
                select new { computer.ProcessorCoreClock, computer.RAMVolume, computer.InstalledPrograms };
            #endregion

            #region Task 5
            List<Manufacturer> manufacturers = Manufacturer.Generate100();
            var computerManufacturerJoin1 =
                from computer in computers
                join manufacturer in manufacturers on computer.ComputerManufacturer equals manufacturer.Name
                select new
                {
                    computer.ProcessorType,
                    computer.ProcessorCoreClock,
                    computer.RAMVolume, computer.OperationSystemType, manufacturer.Name, 
                    manufacturer.Country 
                };
            #endregion

            #region Task 7.2
            var computerQuery4 = computers.Where(x => x.ProcessorType != AMD);
                /*from computer in computers
                where computer.ProcessorType != AMD
                select computer;*/

            var computerQuery5 = computers.Where(x => x.ProcessorType != Intel && x.ComputerManufacturer != Dell);
                /*from computer in computers
                where computer.ProcessorType != Intel
                where computer.ComputerManufacturer != Dell
                select computer;*/

            var computerQuery6 = computers.Where(x => x.UserList.Contains("admin") && x.RAMVolume >= 2048);
                /*from computer in computers
                where computer.UserList.Contains("admin")
                where computer.RAMVolume > 2047
                select computer;*/
            #endregion

            #region Task 7.3
            var computerSort3 = computers.OrderBy(x => x.ProcessorType);
                /*from computer in computers
                orderby computer.ProcessorType
                select computer;*/

            var computerSort4 = computers.OrderBy(x => x.ProcessorType).ThenBy(x => x.ComputerManufacturer);
            /*from computer in computers
            orderby computer.ProcessorType
            orderby computer.ComputerManufacturer
            select computer;*/
            #endregion

            #region Task 7.4
            var computerClocks2 = computers.Select(x => new { x.ProcessorCoreClock, x.RAMVolume, x.InstalledPrograms });
            /*from computer in computers
            select new { computer.ProcessorCoreClock, computer.RAMVolume, computer.InstalledPrograms };*/
            #endregion

            #region Task 7.5
            var computerManufacturerJoin2 = computers.Join(manufacturers,
                computer => computer.ComputerManufacturer,
                manufacturer => manufacturer.Name,
                (c, m) => new
                {
                    c.ProcessorType,
                    c.ProcessorCoreClock,
                    c.RAMVolume,
                    c.OperationSystemType,
                    m.Name,
                    m.Country
                });
            /*from computer in computers
            join manufacturer in manufacturers on computer.ComputerManufacturer equals manufacturer.Name
            select new
            {
                computer.ProcessorType,
                computer.ProcessorCoreClock,
                computer.RAMVolume,
                computer.OperationSystemType,
                manufacturer.Name,
                manufacturer.Country
            };*/
            #endregion
        }
    }
}
