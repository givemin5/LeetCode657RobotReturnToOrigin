using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode657RobotReturnToOrigin
{
    public class Solution
    {
        public bool JudgeCircle(string moves)
        {
            int x=0, y = 0;
            var steps = moves.ToCharArray();
            foreach (var step in steps)
            {
                switch (step)
                {
                    case 'U':
                        y = y + 1;
                        break;
                    case 'D':
                        y = y - 1;
                        break;
                    case 'L':
                        x = x - 1;
                        break;
                    case 'R':
                        x = x + 1;
                        break;
                }
            }

            return y == 0 && x == 0;
        }
    }
}
