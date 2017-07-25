using System;
using System.Collections.Generic;
using System.Linq;

namespace Millionaires
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>() 
            {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            /* 
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                WF 2
                BOA 1
                FTB 1
                CITI 1
            */

            var millionaires = 
                customers.Where(cust => cust.Balance >= 1000000)
                .GroupBy(cust => cust.Bank);

            Console.WriteLine();
            foreach (var mill in millionaires)
            {
                Console.WriteLine($"{mill.Key} {mill.Count()}");
            }
            
            // **********************************************************************
            /*
                TASK:
                As in the previous exercise, you're going to output the millionaires,
                but you will also display the full name of the bank. You also need
                to sort the millionaires' names, ascending by their LAST name.

                Example output:
                    Tina Fey at Citibank
                    Joe Landy at Wells Fargo
                    Sarah Ng at First Tennessee
                    Les Paul at Wells Fargo
                    Peg Vale at Bank of America
            */

            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
                new Bank(){ Name="First Tennessee", Symbol="FTB"},
                new Bank(){ Name="Wells Fargo", Symbol="WF"},
                new Bank(){ Name="Bank of America", Symbol="BOA"},
                new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            var millionaires2 =
                from cust in customers
                where cust.Balance >= 1000000
                orderby cust.Name.Substring(cust.Name.IndexOf(" ") + 1)
                join bank in banks on cust.Bank equals bank.Symbol
                select new { Name = cust.Name, Bank = bank.Name };

            Console.WriteLine();
            foreach (var mill in millionaires2)
            {
                Console.WriteLine($"{mill.Name} at {mill.Bank}");
            }
            
        }
    }
}
