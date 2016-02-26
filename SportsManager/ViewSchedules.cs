﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsManager
{
    public class ViewSchedules
    {
        FileReader fr = new FileReader();
        UserControls usercontrols = new UserControls();

        public void ScheduleSelect()
        {
            Console.WriteLine(" Choose 1 to view Practice Schedule\n Choose 2 to view Weight Training Schedule\n Choose 3 to view One on One Schedule\n Choose 4 to view Game Schedule\n Choose 5 to end program\n Choose 6 to go to Menu\n");

            do
            {
                switch (Console.ReadKey().KeyChar.ToString())
                {

                    case "1":
                        Console.WriteLine(" Practice:");
                        ViewPractice();
                        continue;

                    case "2":
                        Console.WriteLine(" Weight Training:");
                        ViewTraining();
                        continue;

                    case "3":
                        Console.WriteLine(" One on One:");
                        ViewOneonOne();
                        continue;

                    case "4":
                        Console.WriteLine(" Game:");
                        ViewGame();
                        continue;

                    case "5":
                        break;

                    case "6":
                        Console.WriteLine(" Menu:   \n");
                        usercontrols.GetUserControl();
                        return;

                    default:
                        Console.WriteLine(" Not Valid User Input");
                        continue;
                }

                break;

            } while (true);

            Console.WriteLine("Exited");
        }


        public void ViewPractice()
        {
            fr.ReadFromFile("../../PracticeSchedule.txt");
        }
        public void ViewTraining()
        {
            fr.ReadFromFile("../../TrainingSchedule.txt");
        }
        public void ViewOneonOne()
        {
            fr.ReadFromFile("../../OneonOneSchedule.txt");
        }
        public void ViewGame()
        {
            fr.ReadFromFile("../../GameSchedule.txt");
        }


    }
}
