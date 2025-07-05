using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assighnment_01
{
    enum WeekDays
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday,
    }
    enum Seas
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    [Flags] // Makes our values power 2 
    enum Permission : byte
    {
        Read = 1,
        write = 2,
        Delete = 4,
        Execute = 8

    }
    enum Colors
    {
        Red, 
        Green,
        Blue
    }


}
