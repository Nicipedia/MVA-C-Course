﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash_Tables
{
    public class HashtableDemo
    {
        private static Hashtable employees = new Hashtable();
        public static void Main()
        {
            // Add some values to the Hashtable, indexed by a string key
            employees.Add("111-22-3333", "Scott");
            employees.Add("222-33-4444", "Sam");
            employees.Add("333-44-55555", "Jisun");

            // Access a particular key
            if (employees.ContainsKey("111-22-3333"))
            {
                string empName = (string)employees["111-22-3333"];
                Console.WriteLine("Employee 111-22-3333's name is: " + empName);
            }
            else
                Console.WriteLine("Employee 111-22-3333 is not in the hash table...");
            // Step through all items in the Hashtable
            foreach (string key in employees.Keys)
                Console.WriteLine("Value at employees[" + key + "] = " + employees[key].ToString());
        }
    }
}