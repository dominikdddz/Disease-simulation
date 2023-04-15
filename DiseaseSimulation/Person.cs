using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiseaseSimulation
{
    internal class Person
    {
        private int[] position; // położenie - [x,y] od [0-100
        private int speed; // predkosc - [1,2,3]
        private int direction; // kierunek ruchu
        //  [7] [8] [9]
        //  [4] [5] [6]
        //  [1] [2] [3]
        private string condition; // stan - chory (C), zarazony (Z), zdrowiejacy (ZD), zdrowy (ZZ)
        public int durationCondition;
        private int age; // wiek - [0-100]
        private int resistance; // odpornosc na chorobe - [0,10] niska: (0, 3> , srednia: (3, 6 > , wysoka(6, 10 >
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
            durationCondition = 1;

            int a = randomNumber.Next(1, 60+1);
            setAge(a);

            setResistance(a);

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
            if (c == 1)
            {
                condition = "C";
            }
            else if (c == 2)
            {
                condition = "Z";
            }
            else if (c == 3)
            {
                condition = "ZD";
            }
            else
            {
                condition = "ZZ";
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
        public void setResistance(int a)
        {
            Random randomNumber = new Random();
            if ((a >= 0 && a < 15) || (a >= 70 && a <= 100)) // niska odpornosc,    wiek < 0, 15) U < 70, 100 >
            {  
                int r = randomNumber.Next(1, 3+1);
                resistance = r;
            }
            else if (a >= 40 && a < 70) // srednia odpornosc,   wiek < 40, 70)
            {
                int r = randomNumber.Next(3, 6+1);
                resistance = r;
            }
            else if (a <= 15 && a < 40) // wysoka odpornosc,    wiek < 15, 40)
            {
                int r = randomNumber.Next(6, 10+1);
                resistance = r;
            }
        }
        public int getResistance()
        {
            return resistance;
        }
    }
}
