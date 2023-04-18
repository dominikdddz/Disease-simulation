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
        public int N = 10;
        public int CountTurns;

        public int GreenPersons;
        public int OrangePersons;
        public int YellowPersons;
        public int RedPersons;
        public int BirthPersons;
        public int DeadPersons;


        public Simulation()
        {
            Persons = new Person[N];
            for(int i = 0; i < N; i++)
            {
                Person p = new Person();
                Persons[i] = p;
                WhichCondition(i);
            }
            CountTurns = 1;
        }
        public void TurnSession()
        {
            CountTurns++;
            for (int i = 0; i < N; i++)
            {
                DurationCondition(Persons[i]);
                movePerson(Persons[i]);
                IsMeetSomeone(Persons[i]);
                gettingOlder(i);
                clearMeeting();
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
        private void DurationCondition(Person person)
        {
            person.durationCondition++;
            string condition = person.getCondition();
            int duration = person.durationCondition;
            if(condition=="Z" && duration >= 2)
            {
                person.setCondition(1);
                person.durationCondition = 1;
                YellowPersons--;
                RedPersons++;            
            }
            else if (condition == "C" && duration >= 7)
            {
                person.setCondition(3);
                person.durationCondition = 1;
                RedPersons--;
                OrangePersons++;
            }
            else if (condition == "ZD" && duration >= 5)
            {
                person.setCondition(4);
                person.durationCondition = 1;
                OrangePersons--;
                GreenPersons++;
            }
        }

        private void clearMeeting()
        {
            foreach(Person person in Persons)
            {
                person.isMeet = false;
            }
        }

        private void checkCondition(Person personOne, Person personTwo)
        {
            personOne.isMeet = true;
            personTwo.isMeet = true;
            string conditionPersonOne = personOne.getCondition();
            string conditionPersonTwo = personTwo.getCondition();
            if(conditionPersonOne == "ZZ" &&  conditionPersonTwo == "Z"){
                personOne.setCondition(1);
                personTwo.setCondition(1);
            }
            NewDirection(personOne);
            NewDirection(personTwo);
        }

        private void resistanceCondition()
        {
            for (int i = 0; i < N; i++)
            {
                string condition = Persons[i].getCondition();
                double resistance = Persons[i].getResistance();
                if (condition == "Z")
                {
                    resistance -= 0.1;
                    if (resistance < 0)
                        deadPerson(i);
                    else
                        Persons[i].setResistance(resistance);
                }
                else if (condition == "C")
                {
                    resistance -= 0.5;
                    if (resistance < 0)
                        deadPerson(i);
                    else
                        Persons[i].setResistance(resistance);
                }
                else if (condition == "ZD")
                {
                    resistance += 0.1;
                }
                else
                {
                    resistance += 0.05;
                }
            }
        }

        private void IsMeetSomeone(Person person)
        {
            if (person.isMeet != true) {
                Person closestPerson = FindClosestPerson(person);
                if (closestPerson != null) {
                    checkCondition(person, closestPerson);
                }
            }
        }

        private Person FindClosestPerson(Person person)
        {
            int[] iXY = person.getPosition();
            double minDistance = double.MaxValue;
            double maxX, maxY;
            Person closestPerson = null;
            foreach (Person someone in Persons)
            {
                if (person != someone && someone.isMeet == false)
                {
                    int[] jXY = someone.getPosition();
                    maxX = jXY[0] - iXY[0];
                    maxY = jXY[1] - iXY[1];
                    double distance = Math.Sqrt(maxX * maxX + maxY * maxY);
                    if (distance < minDistance && distance <= 2)
                    {
                        minDistance = distance;
                        closestPerson = someone;
                    }
                }
            }
            return closestPerson;
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
                    Persons[i].setResistance(Persons[i].getAge());
                else if(age==40)
                    Persons[i].setResistance(Persons[i].getAge());
                else if(age==15)
                    Persons[i].setResistance(Persons[i].getAge());
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
        private void movePerson(Person person)
        {
            int[] XY = person.getPosition();
            int direction = person.getDirection();
            int speed = person.getSpeed();

            if (direction == 1)
            {
                if (XY[0] - speed < 0) 
                { 
                    XY[0] = 0;
                    NewDirection(person);
                }
                else if (XY[1] - speed < 0) 
                { 
                    XY[1] = 0;
                    NewDirection(person);
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
                    NewDirection(person);
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
                    NewDirection(person);
                }
                else if (XY[1] - speed < 0) 
                {
                    XY[1] = 0;
                    NewDirection(person);
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
                    NewDirection(person);
                }
                else
                {
                    XY[0] = XY[0] - speed;
                }  
            }
            else if (direction == 5)
            {
                NewDirection(person);
            }
            else if (direction == 6)
            {
                if (XY[0] + speed > 100)
                {
                    XY[0] = 100;
                    NewDirection(person);
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
                    NewDirection(person);
                }
                        
                else if (XY[1] + speed > 100)
                {
                    XY[1] = 100;
                    NewDirection(person);
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
                    NewDirection(person);
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
                    NewDirection(person);
                }
                       
                else if (XY[1] + speed > 100)
                {
                    XY[1] = 100;
                    NewDirection(person);
                }
                else
                {
                    XY[0] = XY[0] + speed;
                    XY[1] = XY[1] + speed;
                }
            }
            person.setPosition(XY[0], XY[1]);
        }
        private void NewDirection(Person person)
        {
            Random randomNumber = new Random();
            int newD = randomNumber.Next(1, 10);
            person.setDirection(newD);
        }
    }

}
