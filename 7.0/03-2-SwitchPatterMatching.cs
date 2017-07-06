using System;
using System.Collections.Generic;
using System.Text;

namespace csharp.features._7._0
{
    public class SwitchPatterMatching2 : IRunnable
    {
        public void Run()
        {
            var result1 = OperateWithNumbers(5, -3);
            var result2 = OperateWithNumbers(-5, 20);
        }


        private int OperateWithNumbers(object number1, object number2)
        {            

            switch(number1) {
                case int n1 when (n1 > 0 && number2 is int n2):
                    return n1 + n2;

                case int n1 when (n1 < 0 && number2 is int n2 && n2 > 0):

                    return n1 * n2;

                default:
                    throw new Exception("Not matched");
            }
        }
    }
}
