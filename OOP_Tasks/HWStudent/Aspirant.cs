using System;
using System.Collections.Generic;
using System.Text;

namespace HWStudent
{
    class Aspirant : Student
    {
        public Aspirant(string _firstName, string _lastName, string _group, double _averageMark) : base(_firstName, _lastName, _group, _averageMark) {}
     
        public override int GetScholarship()
        {
            if (AverageMark == 5)
            {
                int Sum = 200;
                return Sum;
            }
            else
            {
                int Sum = 180;
                return Sum;
            }
        }
    }
}
