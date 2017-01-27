using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores
{
    class Program
    {
        static void Main(string[] args)
        {
            colecctions week = new colecctions();
            System.Console.WriteLine(week["Sun"]);
            Console.ReadKey();

        }
    }

    internal class colecctions
    {
        private string[] dias = {"Sun", "Mon", "Tues"};
        private int _type;

        private int GetDay(string testDay)
        {
            for (int i = 0; i < dias.Length; i++)
            {
                if (dias[i] == testDay)
                {
                    return i;
                } 
            }
            throw new System.ArgumentOutOfRangeException(testDay, "el dia debe estar de lunes a domingos");
        }
        public int this[string dia]
        {
           get
            {
                return (GetDay(dia));
            }
        }

    }
}
