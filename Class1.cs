using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adventure2
{
    internal class RollSim
    {
        private int numRolls;
        public RollSim(int numRolls) 
        {
            this.numRolls = numRolls;
        }

        public void rollEm()
        {
            // do stuff. determine how many rolls occurred for each number.
            // divide the amount of rolls by numRolls. keep it a whole number. print

            // make variables

            Random random = new Random();

            int[] nums = new int[11];


            for (int i = 0; i < numRolls; i++)
            {
                int die1 = random.Next(1, 7);
                int die2 = random.Next(1, 7);
                int comboRoll = die2 + die1;

                nums[comboRoll - 2]++;

            }

            for (int i = 0; i < 11; i++)
            {
                string outputAst = "";
                double numAst = 100 * (double)nums[i] / numRolls;
                for (int j = 0; j < numAst; j++)
                {
                    outputAst += "*";
                }

                System.Console.WriteLine((i + 2) + ": " + outputAst);

            }
        }
    }
}
