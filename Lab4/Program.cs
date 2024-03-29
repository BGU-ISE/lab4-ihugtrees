﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;

namespace Lab4
{

    class Program
    {
        //Declare an instance for log4net
        private static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            string realID = "minion";
            string realPassword = "banana";

            //ImplementLoggingFuntion();

            int wrongPassCount = 0;
            Console.WriteLine("Enter id or 'exit'");
            string id = Console.ReadLine();
            while (!id.Equals("exit"))
            {
                if (id.Equals(realID))
                {
                    while (wrongPassCount < 3)
                    {
                        Console.WriteLine("Enter user password");
                        string password = Console.ReadLine();
                        if (realPassword.Equals(password))
                        {
                            Console.WriteLine("Congratz u logged in.. take a banana");
                            break;
                        }
                        else
                        {
                            wrongPassCount++;
                            Console.WriteLine("Wrong password.. Try again " + (3 - wrongPassCount));
                        }
                    }
                }
                else
                    Console.WriteLine("no such id");

                Console.WriteLine("Enter id or 'exit'");
                id = Console.ReadLine();
            }
        }

        private static void ImplementLoggingFuntion()
        {
            /* We have 5 levels of log message. Let's test all.
             *  FATAL
                ERROR
                WARN
                INFO
                DEBUG
             */
            var secs = 3;
            Log.Fatal("Start log FATAL...");
            Console.WriteLine("Start log FATAL...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Error("Start log ERROR...");
            Console.WriteLine("Start log ERROR...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Warn("Start log WARN...");
            Console.WriteLine("Start log WARN...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Info("Start log INFO...");
            Console.WriteLine("Start log INFO...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Log.Debug("Start log DEBUG...");
            Console.WriteLine("Start log DEBUG...");
            Thread.Sleep(TimeSpan.FromSeconds(secs)); // Sleep some secs

            Console.WriteLine("Press any key to close the application");
            Console.ReadKey();
        }
    }
}
