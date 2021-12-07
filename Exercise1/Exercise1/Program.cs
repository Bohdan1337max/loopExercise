using System;
using System.Linq;
using System.Text;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Tasks tasks = new Tasks();
            Algorithms algorithms = new Algorithms();*/
            SpecialTask specialTask = new SpecialTask();
            specialTask.FindSign(specialTask.GetMathExample());
            
        }
    }
}