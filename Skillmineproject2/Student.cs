using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillmineproject2
{
    public class Student
    {
        private int physics;
        private int chem;
        private int maths;
        private int total;

        public Student(int physics, int chem, int maths,int total)
        {
            this.physics = physics;
            this.chem = chem;
            this.maths = maths;
            this.total= total;


        }
        public void CalculateTotal()
        {
           int total = physics + chem + maths;     
        }
        public void CalculatePercentage()
        {
            double per = (total / 300) * 100;
        }
       
        
        
        
        
           
        
    }
}
