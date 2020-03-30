using System;

namespace ClockV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            Clock myClock = new Clock();
            myClock.Settime(12, 51);

            System.Console.WriteLine($"The the current time is {myClock.GetHours}:{myClock.GetMinutes}");

            // The LAST line of code should be ABOVE this line
        }
    }
}