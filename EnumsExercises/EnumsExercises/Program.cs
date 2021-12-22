using System;

namespace EnumsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day1 = DayOfWeek.Sunday;
            // package.HasFlag(option)
            if (DayOfWeek.Weekend.HasFlag(day1))
            {
                Console.WriteLine($"{day1} is part of {DayOfWeek.Weekend}");
            }
            else
            {
                Console.WriteLine($"{day1} is NOT part of {DayOfWeek.Weekend}");
            }
        }

        static void FlagEnum_ManualTest()
        {
            DayOfWeek weekend = DayOfWeek.Saturday |
                                DayOfWeek.Sunday;

            DayOfWeek day1 = DayOfWeek.Monday;
            if ((day1 & weekend) == day1)
            {
                Console.WriteLine($"{day1} is part of {weekend}");
            }
            else
            {
                Console.WriteLine($"{day1} is NOT part of {weekend}");
            }
        }

        static void Enum_Parse()
        {
            string dayOfWeek = "None";
            // bool isConvertible = Enum.TryParse(typeof(DayOfWeek), dayOfWeek, out object parseResult);
            bool isConvertible = Enum.TryParse(dayOfWeek, out DayOfWeek parsedResult);
            if (isConvertible)
            {
                DayOfWeek value = parsedResult;
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine(parsedResult);
                Console.WriteLine($"'{dayOfWeek}' cannot be converted to DayOfWeek");
            }
        }

        static void Enum_VerifyIfValueIsDefined()
        {
            int value = 8;

            if (Enum.IsDefined(typeof(DayOfWeek), value))
            {
                DayOfWeek day = (DayOfWeek)value;
                Console.WriteLine(day);
            }
            else
            {
                Console.WriteLine($"{value} doesn't represent a valid value");
            }
        }
    }
}
