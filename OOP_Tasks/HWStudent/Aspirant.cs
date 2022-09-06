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
                 base.Sum = 200;
            }
            else
            {
                base.Sum = 180;
            }
            return base.Sum;
        }
    }
}
