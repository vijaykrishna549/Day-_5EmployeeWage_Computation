﻿using System;

namespace MonthlyWageCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constants
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
           // int NUMBER_OF_WORKING_DAYS = 20;
           // int MAX_WORKING_HOURS = 100;

            //variables
            int empHrs = 0;
            int empWage = 0;
          //  int totalworkinghours = 0;
           // int totalworkingdays = 0;

            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == IS_PART_TIME)
                empHrs = 4;
            else if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            //else
            //empHrs = 0;
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
             Console.ReadKey();           
        }
          
    }

}