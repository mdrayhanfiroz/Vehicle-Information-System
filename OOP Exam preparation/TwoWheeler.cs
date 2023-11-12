using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam_preparation
{
    public abstract class TwoWheeler : Vehicle, IExteriorDesign
    {
        List<string> Specification = new List<string>();
        public void AddSpecification(string specification)
        { 
            Specification.Add(specification);
        }

        public string ShowSpecification()
        {
            return string.Join(",", Specification);
        }
    }
}
