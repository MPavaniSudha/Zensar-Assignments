
//1.Write a program to find the Sum and the Average points scored by the teams in the IPL. Create a Class called Cricket that
//has a function called Pointscalculation(int no_of_matches) that takes no.of matches as input and accepts that many scores
//from the user. The function should then display the Average and Sum of the scores


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Cricket
    {
        int sum=0, Avg;
        public void PointsCalculation(int no_of_matches)
        {
            int[] score = new int[20];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine("Enter  Match {0} Score", i + 1);
                score[i] = Convert.ToInt32(Console.ReadLine());
                sum+= score[i];
            }
            Avg = sum / no_of_matches;
            Console.WriteLine("Sum of the Scores:{0}\nAverage of the Scores:{1}", sum, Avg);
        }
    }
    class CricketScore
    {
        static void Main(string[] args)
        {
            int n;
            Cricket cr = new Cricket();
            Console.WriteLine("Enter No Of Matches");
            n = Convert.ToInt32(Console.ReadLine());
            cr.PointsCalculation(n);

        }
    }
}

/*OUTPUT:
---------------------------------------------------------------------
Enter No Of Matches
5
Enter  Match 1 Score
160
Enter  Match 2 Score
180
Enter  Match 3 Score
150
Enter  Match 4 Score
138
Enter  Match 5 Score
140
Sum of the Scores:768
Average of the Scores:153
Press any key to continue . . .*/
