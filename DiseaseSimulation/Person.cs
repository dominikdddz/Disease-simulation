using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseaseSimulation
{
    internal class Person
    {
        private int[] position; // położenie - [x,y] od [0-100]
        private int speed; // predkosc - [1,2,3]
        private int direction; // kierunek ruchu
        //  [7] [8] [9]
        //  [4] [5] [6]
        //  [1] [2] [3]
        private string condition; // stan - chory (C), zarazony (Z), zdrowiejacy (ZD), zdrowy (ZZ)
        public int durationCondition;
        private int age; // wiek - [0-100]
        private double resistance; // odpornosc na chorobe [0,10] -> niska: (0, 3> ; srednia: (3, 6 > ; wysoka: (6, 10 >
        public bool isMeet;


        public Person()
        {
            Random randomNumber = new Random();

            position = new int[2] { 0, 0 };
            int x = randomNumber.Next(100); // x
            int y = randomNumber.Next(100); // y
            setPosition(x, y);

            int s = randomNumber.Next(1, 3+1);
            setSpeed(s);

            int d = randomNumber.Next(1, 10);
            setDirection(d);

            int c = randomNumber.Next(1, 4+1);
            setCondition(c);

            int a = randomNumber.Next(1, 60+1);
            setAge(a);

            setNewResistance();

            isMeet = false;
        }
        public void setPosition(int x,int y)
        {
            position[0] = x;
            position[1] = y;
        }
        public int[] getPosition()
        {
            return position;
        }
        public void setSpeed(int s)
        {
            speed = s;
        }
        public int getSpeed()
        {
            return speed;
        }
        public void setDirection(int d)
        {
            direction = d;
        }
        public int getDirection()
        {
            return direction;
        }
        public void setCondition(int c)
        {
            if (c == 1) // Chory
            {
                condition = "C";
                durationCondition = 1;
            }
            else if (c == 2) // Zarazony
            {
                condition = "Z";
                durationCondition = 1;
            }
            else if (c == 3) // Zdrowiejacy
            {
                condition = "ZD";
                durationCondition = 1;
            }
            else // Zdrowy
            {
                condition = "ZZ";
                durationCondition = 1;
            }
        }
        public string getCondition()
        {
            return condition;
        }
        public void setAge(int a)
        {
            age = a;
        }
        public int getAge()
        {
            return age;
        }
        public string checkResistance()
        {
            if ((age >= 0 && age < 15) || (age >= 70 && age <= 100)) // niska odpornosc,    wiek < 0, 15) U < 70, 100 >
                return "low";
            else if (age >= 40 && age < 70) // srednia odpornosc,   wiek < 40, 70)
                return "medium";
            else                            // wysoka odpornosc,    wiek < 15, 40)
                return "high";
        }
        public void setNewResistance()
        {
            Random randomNumber = new Random();
            string resistanceType = checkResistance();
            if (resistanceType ==  "low")
                resistance = randomNumber.Next(1, 3 + 1);
            else if (resistanceType == "medium") 
                resistance = randomNumber.Next(3, 6 + 1);
            else 
                resistance = randomNumber.Next(6, 10 + 1);
        }
        public void setResistance(double resistance)
        {
            this.resistance = resistance;
        }
        public double getResistance()
        {
            return resistance;
        }
    }
}
