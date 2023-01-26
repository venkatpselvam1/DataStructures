using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_TestCases
{

    public class TestCaseSimple : IGraphTestCase
    {
        public int GetAns()
        {
            return 700;
        }

        public int GetDst()
        {
            return 3;
        }

        public int[][] GetFlights()
        {
            int[][] flights =
            {
                new int[]{0,1,100},new int[]{1,2,100},new int[]{2,0,100},new int[]{1,3,600},new int[]{2,3,200}
            };
            return flights;
        }

        public int GetK()
        {
            return 1;
        }

        public int GetN()
        {
            return 4;
        }

        public int GetSrc()
        {
            return 0;
        }
    }
}
