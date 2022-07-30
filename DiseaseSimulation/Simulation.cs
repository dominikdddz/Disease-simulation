using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseaseSimulation
{
    internal class Simulation
    {
        public Person[] Persons;
        private Person[,] Grid;
        private int N = 10;
        public Simulation()
        {
            Persons = new Person[N];
            
            Grid = new Person[N, N];
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N; j++)
                    Grid[i, j] = null;
            for(int i = 0; i < N; i++)
            {
                Person p = new Person();
                Persons[i] = p;
            }
        }
        public void getPerson()
        {
            for(int i = 0; i < N; i++)
            {
                int[] pos = Persons[i].getPosition();
                System.Console.Write(pos[0] + "," + pos[1]);
                System.Console.Write(Persons[i].getSpeed());
                System.Console.Write(Persons[i].getDirection());
                System.Console.Write(Persons[i].getAge());
                System.Console.Write(Persons[i].getResistance());
            }
        }
    }
}
