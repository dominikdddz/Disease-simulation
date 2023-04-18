using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiseaseSimulation
{
    internal class Simulation
    {
        public Person[] Persons;
        public int N = 100; // Ilosc osobnikow na start symulacji
        public int CountTurns;
        public int GreenPersons;    // ilosc zdrowych osobników (ZZ)
        public int OrangePersons;   // ilosc zarazonych osobników (Z)
        public int YellowPersons;   // ilosc zdrowiejacych osobników (ZD)
        public int RedPersons;      // ilosc chorych osobników (C)
        public int BirthPersons;    // ilosc narodzonych osobników
        public int DeadPersons;     // ilosc zmarlych osobników
        public Simulation() // Konstruktor
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
        public void TurnSession()   // Głowna petla - Przebieg tury symulacji
        {
            moveAllPerson();                    // Porusza wszystkimi osobnikami
            for (int i = 0; i < N; i++)
            {
                IsMeetSomeone(Persons[i]);      // Sprawdza czy osobnik sie z kims spotkal
                gettingOlder(Persons[i]);       // starzeje osobnika
                DurationCondition(Persons[i]);  // Sprawdza stan oraz odpornosc osobnika

                isDead(i);                      // sprawdza czy osobnik umarl
            }
            clearMeeting();       // resetuje wszystkie spotkania
            CountTurns++;
        }
        private void WhichCondition(int i)  // Zlicza ilosc stanow wsrod osobnikow
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
        private void DurationCondition(Person person) // Sprawdza stan oraz odpornosc osobnika
        {
            string condition = person.getCondition();
            int duration = person.durationCondition;
            if(condition=="Z" && duration > 2)
            {
                person.setCondition(1);
                person.durationCondition = 1;
                YellowPersons--;
                RedPersons++;            
            }
            else if (condition == "C" && duration > 7)
            {
                person.setCondition(3);
                person.durationCondition = 1;
                RedPersons--;
                OrangePersons++;
            }
            else if (condition == "ZD" && duration > 5)
            {
                person.setCondition(4);
                person.durationCondition = 1;
                OrangePersons--;
                GreenPersons++;
            }
            resistanceCondition(person);
            person.durationCondition++;
        }

        private void clearMeeting() // resetuje mozliwosc spotkania wszystkich osobnikow
        {
            for (int i = 0; i < N; i++)
                Persons[i].isMeet = false;
        }

        private void checkConditionDuringMeeting(Person personOne, Person personTwo) // sprawdza stany osobnikow podczas spotkania
        {
            personOne.isMeet = true;
            personTwo.isMeet = true;
            string conditionPersonOne = personOne.getCondition();
            string conditionPersonTwo = personTwo.getCondition();

            if (conditionPersonOne == "ZZ" && conditionPersonTwo == "Z" || conditionPersonOne == "Z" && conditionPersonTwo == "ZZ"){    // ZZ z Z || Z z ZZ
                if (conditionPersonOne == "ZZ"){
                    if (personOne.checkResistance() == "low")
                        personOne.setCondition(2);
                }
                else{
                    if (personTwo.checkResistance() == "low")
                        personTwo.setCondition(2);
                }
            }
            else if (conditionPersonOne == "ZZ" && conditionPersonTwo == "C" || conditionPersonOne == "ZZ" && conditionPersonTwo == "C"){   // ZZ z C || C z ZZ
                if (conditionPersonOne == "ZZ"){
                    if (personOne.checkResistance() == "low" || personOne.checkResistance() == "medium")
                        personOne.setCondition(2);
                    else{
                        double resistancePerson = personOne.getResistance();
                        resistancePerson -= 3;
                        personOne.setResistance(resistancePerson);
                    }
                }
                else{
                    if (personOne.checkResistance() == "low" || personOne.checkResistance() == "medium")
                        personOne.setCondition(2);
                    else{
                        double resistancePerson = personTwo.getResistance();
                        resistancePerson -= 3;
                        personTwo.setResistance(resistancePerson);
                    }
                }
            }
            else if (conditionPersonOne == "ZZ" && conditionPersonTwo == "ZD" || conditionPersonOne == "ZD" && conditionPersonTwo == "ZZ"){   // ZZ z ZD || ZD z ZZ
                if (conditionPersonOne == "ZZ"){
                    double resistancePerson = personOne.getResistance();
                    resistancePerson += 1;
                    personOne.setResistance(resistancePerson);
                }
                else{
                    double resistancePerson = personTwo.getResistance();
                    resistancePerson += 1;
                    personTwo.setResistance(resistancePerson);
                }

            }
            else if (conditionPersonOne == "ZZ" && conditionPersonTwo == "ZZ") // ZZ z ZZ
            {
                double resistancePerson = personTwo.getResistance();
                resistancePerson += 1;
                personTwo.setResistance(resistancePerson);
            }
            else if (conditionPersonOne == "C" && conditionPersonTwo == "Z" || conditionPersonOne == "Z" && conditionPersonTwo == "C"){     // C z Z || Z z C
                if (conditionPersonOne == "C"){
                    if (personOne.checkResistance() == "low" || personOne.checkResistance() == "medium")
                        personOne.setCondition(1);
                    else{
                        double resistancePerson = personTwo.getResistance();
                        resistancePerson -= 3;
                        personTwo.setResistance(resistancePerson);
                    }
                }
                else{
                    if (personTwo.checkResistance() == "low" || personTwo.checkResistance() == "medium")
                        personTwo.setCondition(1);
                    else{
                        double resistancePerson = personOne.getResistance();
                        resistancePerson -= 3;
                        personOne.setResistance(resistancePerson);
                    }
                }
            }
            else if (conditionPersonOne == "C" && conditionPersonTwo == "ZD" || conditionPersonOne == "ZD" && conditionPersonTwo == "C"){ // C z ZD || ZD z C
                if (conditionPersonOne == "C"){
                    if (personTwo.checkResistance() == "low" || personTwo.checkResistance() == "medium")
                        personTwo.setCondition(2);
                }
                else{
                    if (personOne.checkResistance() == "low" || personOne.checkResistance() == "medium")
                        personOne.setCondition(2);
                }
            }

            NewDirection(personOne);
            NewDirection(personTwo);
        }

        private void resistanceCondition(Person person) // zmienia odpornosc osobnika
        {
            string condition = person.getCondition();
            double resistance = person.getResistance();
            if (condition == "Z")
            {
                resistance -= 0.1;
                person.setResistance(resistance);
            }
            else if (condition == "C")
            {
                resistance -= 0.5;
                person.setResistance(resistance);
            }
            else if (condition == "ZD")
            {
                resistance += 0.1;
                person.setResistance(resistance);
            }
            else
            {
                resistance += 0.05;
                person.setResistance(resistance);
            }
        }

        private void IsMeetSomeone(Person person) // Sprawdza czy osobnik sie z kims spotkal
        {
            if (person.isMeet != true) {
                Person closestPerson = FindClosestPerson(person);
                if (closestPerson != null) {
                    checkConditionDuringMeeting(person, closestPerson);
                }
            }
        }

        private Person FindClosestPerson(Person person) // Szuka najblizszej osoby; Spotkanie odbywa sie jesli ktos jest w odleglosc 2 kratek
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
        private void gettingOlder(Person person) // starzeje osobnika
        {
            int age = person.getAge();
            age++;
            person.setAge(age);

            if (age == 0 || age == 70)
                person.setNewResistance();
            else if (age == 40)
                person.setNewResistance();
            else if (age == 15)
                person.setNewResistance();
        }
        private void isDead(int i) // sprawdza czy osobnik powinien nie zyc
        {
            if (Persons[i].getAge() > 100 || Persons[i].getResistance() <= 0)
            {
                string condition = Persons[i].getCondition();
                if (condition == "C")
                    RedPersons--;
                else if (condition == "Z")
                    YellowPersons--;
                else if (condition == "ZD")
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
        }
        private void moveAllPerson() // porusza wszystkimi osobnikami
        {
            for (int i = 0; i < N; i++)
            {
                int[] XY = Persons[i].getPosition();
                int direction = Persons[i].getDirection();
                int speed = Persons[i].getSpeed();

                if (direction == 1)
                {
                    if (XY[0] - speed < 0)
                    {
                        XY[0] = 0;
                        NewDirection(Persons[i]);
                    }
                    else if (XY[1] - speed < 0)
                    {
                        XY[1] = 0;
                        NewDirection(Persons[i]);
                    }
                    else
                    {
                        XY[0] = XY[0] - speed;
                        XY[1] = XY[1] - speed;
                    }
                }
                else if (direction == 2)
                {
                    if (XY[1] - speed < 0)
                    {
                        XY[1] = 0;
                        NewDirection(Persons[i]);
                    }
                    else
                    {
                        XY[1] = XY[1] - speed;
                    }
                }
                else if (direction == 3)
                {
                    if (XY[0] + speed > 100)
                    {
                        XY[0] = 100;
                        NewDirection(Persons[i]);
                    }
                    else if (XY[1] - speed < 0)
                    {
                        XY[1] = 0;
                        NewDirection(Persons[i]);
                    }
                    else
                    {
                        XY[0] = XY[0] + speed;
                        XY[1] = XY[1] - speed;
                    }
                }
                else if (direction == 4)
                {
                    if (XY[0] - speed < 0)
                    {
                        XY[0] = 0;
                        NewDirection(Persons[i]);
                    }
                    else
                    {
                        XY[0] = XY[0] - speed;
                    }
                }
                else if (direction == 5)
                {
                    NewDirection(Persons[i]);
                }
                else if (direction == 6)
                {
                    if (XY[0] + speed > 100)
                    {
                        XY[0] = 100;
                        NewDirection(Persons[i]);
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
                        NewDirection(Persons[i]);
                    }

                    else if (XY[1] + speed > 100)
                    {
                        XY[1] = 100;
                        NewDirection(Persons[i]);
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
                        NewDirection(Persons[i]);
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
                        NewDirection(Persons[i]);
                    }

                    else if (XY[1] + speed > 100)
                    {
                        XY[1] = 100;
                        NewDirection(Persons[i]);
                    }
                    else
                    {
                        XY[0] = XY[0] + speed;
                        XY[1] = XY[1] + speed;
                    }
                }
                Persons[i].setPosition(XY[0], XY[1]);
            }
        }
        private void NewDirection(Person person) // ustawia nowy losowy kierunek ruchu dla osobnika
        {
            Random randomNumber = new Random();
            int newD = randomNumber.Next(1, 10);
            person.setDirection(newD);
        }
    }

}
