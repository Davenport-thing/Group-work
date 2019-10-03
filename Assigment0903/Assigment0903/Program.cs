/*************************************************************************/
/* Program Name:     Ch3Exe3.24.cs                                           */
/* Date:             01/18/2017                                          */
/* Programmer:       Your Name                                           */
/* Class:            CSCI 231                                            */
/*                                                                       */
/* Program Description:  Determines wether or no the number inputed is   */
/*                       a even or odd number.                           */
/*                                                                       */
/*                                                                       */
/*                                                                       */
/* Input:	List the Input  a                                            */
/*                                                                       */
/* Output:	The total miles per gallon is ______ with _____ fill ups     */
/*                                                                       */
/* Givens:	List the Givens User will not enter strings                  */
/*                                                                       */
/*                                                                       */
/* Testing Data: List the Testing Input Data  (User input, files, etc.   */
/*                                             necessary to ensure the   */
/*                                             program works correctly)  */
/*************************************************************************/




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment0903
{
    class Program
    {
        static void Main(string[] args)
        {
            int vm = 0;
            int vg = 0;
            int tm = 0;
            int tg = 0;
            int mpg = 0;
            int tt = 0;


            begining:
            Console.WriteLine("how many gallons of gas did you use?");
           string input  = Console.ReadLine();
            vg = Convert.ToInt32(input);

            Console.WriteLine("how many miles did you drive?");
                input = Console.ReadLine();
             vm = Convert.ToInt32(input);

            if (vm >= 0)
            {
                tm = vm + tm;
                tg = vg + tg;

                mpg = tm / tg;

                tt = tt + 1;
            }

            else
            {
                Console.WriteLine("you can't drive 0 miles");
                goto begining;
            }


            Console.WriteLine("you traveled {0} per gallon",mpg);
            Console.ReadLine();

      










        }
    }
}
