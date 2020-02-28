using System;
using System.Collections.Generic;

namespace ListIntro {
    class Program {
        static void Main (string[] args) {
            List<string> nssCohorts = new List<string> {
                "Cohort 36",
                "Cohort 37",
                "Cohort 38"
            };

            nssCohorts.Add ("Cohort 39");

            List<int> birthYears = new List<int> {
                1996,
                1992,
                1997,
                2001
            };

            birthYears.Add (1988);
            birthYears.Add (1999);
            birthYears.Add (1865);
            birthYears.Add (1987);

            foreach (string cohort in nssCohorts) {
                Console.WriteLine (cohort);
            }

            birthYears.Remove (1996);

            foreach (int year in birthYears) {
                Console.WriteLine (year);

                if (year == 1996) {
                    Console.WriteLine ("Go bulls");
                }
            }

            Dictionary<string, string> student = new Dictionary<string, string> ();

            student.Add ("First Name", "Maggie");
            student.Add ("Last Name", "Greene");
            student.Add ("Cohort", "C37");

            Dictionary<string, string> anotherStudent = new Dictionary<string, string> () { { "First Name", "Adam" }, { "Last Name", "Something" }, { "Cohort", "C37 Instructor" }
            };

            foreach (KeyValuePair<string, string> pair in student) {
                Console.WriteLine ($"The student's {pair.Key} is {pair.Value}.");
            }

        }
    }
}