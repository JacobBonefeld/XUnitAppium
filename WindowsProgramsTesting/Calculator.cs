using System;
using System.Collections.Generic;
using System.Text;

namespace WindowsProgramsTesting
{
    public class Calculator : ProgramHandler
    {

        private const string appID = "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App";


        public Calculator() : base(appID)
        {
            // Uses constructor from parent class
        }

        public int addNumbers(params int[] numbers)
        {
            // Check input is valid
            foreach (int number in numbers){
                if(number > 9 || number < 0)
                {
                    throw new ArgumentException();
                }
            }

            // Add all numbers
            for( int i = 0; i < numbers.Length; i++)
            {
                driver.FindElementByAccessibilityId("num" + numbers[i] + "Button").Click();

                if(i < numbers.Length - 1)
                {
                    driver.FindElementByAccessibilityId("plusButton").Click();
                }
                
            }

            // Click equals
            driver.FindElementByAccessibilityId("equalButton").Click();

            // Return result from calculator screen
            return Int32.Parse(driver.FindElementByAccessibilityId("CalculatorResults").Text.Replace("Skærm er", string.Empty).Trim());

        }

    }
}
