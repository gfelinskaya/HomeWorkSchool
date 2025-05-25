using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Office
    {
        private int count = 0; 
        private Emploee[] emploees;

        public Office()
        {
            emploees = new Emploee[200];
        }

        public void HireEmploee(Emploee emploee)
        {
            if (count < emploees.Length - 1)
            {
                emploees[count++] = emploee;
            }
            else
            {
                Console.WriteLine("No more space for new emploee.");
            }
        }

        public void FireEmploee(Emploee emploee)
        {
            for (int i = 0; i < emploees.Length; i++)
            {
                if (emploees[i] == emploee)
                {
                    emploees[i] = null;
                    break;
                }
            }
        }

        public void PayRise(int index, double rise)
        {
            if (index > 0 && index < count)
            {
                emploees[index].Salary += rise;
            }
            else
            {
                Console.WriteLine("Index out of range.");
            }
        }

        public Emploee this[int index]
        {
            get
            {
                if (index > 0 && index < count)
                {
                    return emploees[index];
                }
                else
                {                  
                    return null;
                }
            }          
        }

        public Emploee this[string id]
        {
            get
            {
                for (int i = 0; i < count; i++)
                {
                    if (emploees[i].Id == id)
                    {
                        return emploees[i];
                    }
                }

                return null;
            }
        }
    }
}
