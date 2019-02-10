using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode657RobotReturnToOrigin
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void Solution_JudgeCircle_UD_ShouldBe_True()
        {
            var input = "UD";

            Solution solution = new Solution();
            var actual = solution.JudgeCircle(input);

            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
