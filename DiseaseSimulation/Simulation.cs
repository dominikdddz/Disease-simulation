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
        public int N = 100;
        public int CountTurns;

        public int GreenPersons;
        public int OrangePersons;
        public int YellowPersons;
        public int RedPersons;
        public int BirthPersons;
        public int DeadPersons;


        public Simulation()
        {
            CountTurns = 1;
            Persons = new Person[N];
            for(int i = 0; i < N; i++)
            {
                Person p = new Person();
                Persons[i] = p;
                WhichCondition(i);
            }
        }
        public void TurnSession()
        {
            CountTurns++;
            for (int i = 0; i < N; i++)
            {
                movePerson(i);
                DurationCondition(i);
                gettingOlder(i);
            }
        }
        private void WhichCondition(int i)
        {
            string c = Persons[i].getCondition();
            if (c == "C")
                RedPersons++;
            else if (c == "Z")
                YellowPersons++;
            else if (c == "ZD")
                OrangePersons++;
            else
                GreenPersons++;
        }
        private void DurationCondition(int i)
        {
            Persons[i].durationCondition++;
            string condition = Persons[i].getCondition();
            int duration = Persons[i].durationCondition;
            if(condition=="Z" && duration >= 2)
            {
                Persons[i].setCondition(1);
                Persons[i].durationCondition = 1;
                YellowPersons--;
                RedPersons++;            
            }
            else if (condition == "C" && duration >= 7)
            {
                Persons[i].setCondition(3);
                Persons[i].durationCondition = 1;
                RedPersons--;
                OrangePersons++;
            }
            else if (condition == "ZD" && duration >= 5)
            {
                Persons[i].setCondition(4);
                Persons[i].durationCondition = 1;
                OrangePersons--;
                GreenPersons++;
            }
        }
        private void IsMeetSomeone(int i)
        {
            int[] iXY = Persons[i].getPosition();
            int max, maxj, maxX, maxY;
            for(int j = 0; j < N; j++)
            {
                if (Persons[i] != Persons[j] && Persons[i].isMeet==false && Persons[j].isMeet==false)
                {
                    int[] jXY = Persons[j].getPosition();
                    maxX = Math.Abs(iXY[0] - jXY[0]);
                    maxY = Math.Abs(iXY[1] - jXY[1]);
                    if(maxX < 2 && maxY < 2)
                    {

                    }
                }
            }
        }
        private void gettingOlder(int i)
        {
            int age = Persons[i].getAge();
            age++;
            Persons[i].setAge(age);
            if (age > 100)
            {
                deadPerson(i);
            }
            else
            {
                if(age==0 || age == 70)
                    Persons[i].setCondition(Persons[i].getAge());
                else if(age==40)
                    Persons[i].setCondition(Persons[i].getAge());
                else if(age==15)
                    Persons[i].setCondition(Persons[i].getAge());
            }

        }
        private void deadPerson(int i)
        {
            string c = Persons[i].getCondition();
            if (c == "C")
                RedPersons--;
            else if (c == "Z")
                YellowPersons--;
            else if (c == "ZD")
                OrangePersons--;
            else
                GreenPersons--;
            for (int a = i; a < Persons.Length - 1; a++)
            {
                Persons[a] = Persons[a + 1];
            }
            N--;
            DeadPersons++;
            Array.Resize(ref Persons, Persons.Length - 1);
        }
        private void movePerson(int i)
        {
            int[] XY = Persons[i].getPosition();
            int direction = Persons[i].getDirection();
            int speed = Persons[i].getSpeed();

            if (direction == 1)
            {
                if (XY[0] - speed < 0) 
                { 
                    XY[0] = 0;
                    NewDirection(i, direction);
                }
                else if (XY[1] - speed < 0) 
                { 
                    XY[1] = 0;
                    NewDirection(i, direction);
                }
                else
                { 
                    XY[0] = XY[0] - speed;
                    XY[1] = XY[1] - speed;
                }
            }
            else if(direction == 2)
            { 
                if (XY[1] - speed < 0)
                {
                    XY[1] = 0;
                    NewDirection(i, direction);
                }
                else
                {
                    XY[1] = XY[1] - speed;
                } 
            }
            else if(direction == 3)
            {
                if (XY[0] + speed > 100) 
                {
                    XY[0] = 100;
                    NewDirection(i, direction);
                }
                else if (XY[1] - speed < 0) 
                {
                    XY[1] = 0;
                    NewDirection(i, direction);
                }
                else
                {
                    XY[0] = XY[0] + speed;
                    XY[1] = XY[1] - speed;
                }
            }
            else if(direction == 4)
            {  
                if (XY[0] - speed < 0)
                {
                    XY[0] = 0;
                    NewDirection(i, direction);
                }
                else
                {
                    XY[0] = XY[0] - speed;
                }  
            }
            else if (direction == 5)
            {
                NewDirection(i, direction);
            }
            else if (direction == 6)
            {
                if (XY[0] + speed > 100)
                {
                    XY[0] = 100;
                    NewDirection(i, direction);
                }
                else
                {
                    XY[0] = XY[0] + speed;
                }    
            }
            else if (direction == 7)
            {

                if (XY[0] - speed < 0)
                {
                    XY[0] = 0;
                    NewDirection(i, direction);
                }
                        
                else if (XY[1] + speed > 100)
                {
                    XY[1] = 100;
                    NewDirection(i, direction);
                }
                else
                {
                    XY[0] = XY[0] - speed;
                    XY[1] = XY[1] + speed;
                }
                        
            }
            else if (direction == 8)
            {
                if (XY[1] + speed > 100)
                {
                    XY[1] = 100;
                    NewDirection(i, direction);
                }
                else
                {
                    XY[1] = XY[1] + speed;
                }
            }
            else if (direction == 9)
            {

                if (XY[0] + speed > 100)
                {
                    XY[0] = 100;
                    NewDirection(i, direction);
                }
                       
                else if (XY[1] + speed > 100)
                {
                    XY[1] = 100;
                    NewDirection(i, direction);
                }
                else
                {
                    XY[0] = XY[0] + speed;
                    XY[1] = XY[1] + speed;
                }
            }
            Persons[i].setPosition(XY[0], XY[1]);
        }
        private void NewDirection(int i, int d)
        {
            Random randomNumber = new Random();
            int newD = newD = randomNumber.Next(1, 10);
            Persons[i].setDirection(newD);
        }
    }

}
