namespace DiseaseSimulation
{
    internal class Simulation
    {
        public Person[] Persons;
        public int N = 100; // Ilosc osobnikow na start symulacji
        public int turnCount;
        public int greenPersonsCount = 0;   // ilosc zdrowych osobników (ZZ)
        public int orangePersonsCount = 0;  // ilosc zarazonych osobników (Z)
        public int yellowPersonsCount = 0;  // ilosc zdrowiejacych osobników (ZD)
        public int redPersonsCount = 0;     // ilosc chorych osobników (C)
        public int birthPersonsCount = 0;   // ilosc narodzonych osobników
        public int deadPersonsCount = 0;    // ilosc zmarlych osobników
        public int deadCountByAge = 0;      // ilosc zmarlych osobników przez wiek
        public int deadCountByDisease = 0;  // ilosc zmarlych osobników przez chorobe
        public Simulation() // Konstruktor
        {
            Persons = new Person[N];
            for(int i = 0; i < N; i++)
            {
                Person p = new Person();
                Persons[i] = p;
                ConditionCount(i);
            }
            turnCount = 1;
        }
        public void TurnSession()   // Głowna petla - Przebieg tury symulacji
        {
            MoveAllPerson();                    // Porusza wszystkimi osobnikami
            for (int i = 0; i < N; i++)
            {
                IsMeetSomeone(Persons[i]);      // Sprawdza czy osobnik sie z kims spotkal
                ChangeAgePerTurn(Persons[i]);       // starzeje osobnika
                CheckDurationConditionPerTurn(Persons[i]);  // Sprawdza stan oraz odpornosc osobnika

                IsDead(i);                      // sprawdza czy osobnik umarl
            }
            ClearMeeting();       // resetuje wszystkie spotkania
            turnCount++;
        }
        private void ConditionCount(int i)  // Zlicza ilosc stanow wsrod osobnikow podczas inicjalizacji symulacji
        {
            string c = Persons[i].GetDiseaseCondition();
            if (c == "C")
                redPersonsCount++;
            else if (c == "Z")
                yellowPersonsCount++;
            else if (c == "ZD")
                orangePersonsCount++;
            else
                greenPersonsCount++;
        }
        private void CheckDurationConditionPerTurn(Person person) // Sprawdza stan oraz odpornosc osobnika co ture
        {
            string condition = person.GetDiseaseCondition();
            int durationCondition = person.GetConditionDuration();
            if(condition=="Z" && durationCondition > 2)
            {
                person.SetDiseaseCondition(1);
                person.ResetConditionDuration();
                yellowPersonsCount--;
                redPersonsCount++;            
            }
            else if (condition == "C" && durationCondition > 7)
            {
                person.SetDiseaseCondition(3);
                person.ResetConditionDuration();
                redPersonsCount--;
                orangePersonsCount++;
            }
            else if (condition == "ZD" && durationCondition > 5)
            {
                person.SetDiseaseCondition(4);
                person.ResetConditionDuration();
                orangePersonsCount--;
                greenPersonsCount++;
            }
            ChangeResistancePerTurn(person);
            person.IncreaseConditionDuration();
        }
        private void ChangeDiseaseCondition(Person person,string newCondition)
        {
            string oldCondition = person.GetDiseaseCondition();
            if (oldCondition == "C")
                redPersonsCount--;
            else if (oldCondition == "Z")
                yellowPersonsCount--;
            else if (oldCondition == "ZD")
                orangePersonsCount--;
            else
                greenPersonsCount--;

            if (newCondition == "C")   // Chory (C)
            {
                person.SetDiseaseCondition(1);
                redPersonsCount++;
            }
            else if (newCondition == "Z")  // Zarazony (Z)
            {
                person.SetDiseaseCondition(2);
                yellowPersonsCount++;
            }
            else if(newCondition == "ZD")  // Zdrowiejacy (ZD)
            {
                person.SetDiseaseCondition(3);
                orangePersonsCount++;
            }
            else    // Zdrowy (ZZ)
            {
                person.SetDiseaseCondition(4);
                greenPersonsCount++;
            }
        }
        private void ChangeResistancePerTurn(Person person) // zmienia odpornosc osobnika
        {
            string condition = person.GetDiseaseCondition();
            double resistance = person.GetCurrentResistance();
            if (condition == "Z")
            {
                resistance -= 0.1;
                person.SetResistance(resistance);
            }
            else if (condition == "C")
            {
                resistance -= 0.5;
                person.SetResistance(resistance);
            }
            else if (condition == "ZD")
            {
                resistance += 0.1;
                person.SetResistance(resistance);
            }
            else
            {
                resistance += 0.05;
                person.SetResistance(resistance);
            }
        }
        private void ChangeAgePerTurn(Person person) // starzeje osobnika o 1 co turę
        {
            int age = person.GetAge();
            age++;
            person.SetAge(age);

            if (age == 0 || age == 70)
                person.SetResistanceForNewAgeRange();
            else if (age == 40)
                person.SetResistanceForNewAgeRange();
            else if (age == 15)
                person.SetResistanceForNewAgeRange();
        }
        private void IsDead(int i) // sprawdza czy osobnik powinien nie zyc ze wzgledu na wiek > 100 lub odpornosc < 0
        {
            if (Persons[i].GetAge() > 100 || Persons[i].GetCurrentResistance() <= 0)
            {
                if(Persons[i].GetAge() > 100)
                    deadCountByAge++;
                else
                    deadCountByDisease++;

                string condition = Persons[i].GetDiseaseCondition();
                if (condition == "C")
                    redPersonsCount--;
                else if (condition == "Z")
                    yellowPersonsCount--;
                else if (condition == "ZD")
                    orangePersonsCount--;
                else
                    greenPersonsCount--;

                for (int a = i; a < Persons.Length - 1; a++)
                {
                    Persons[a] = Persons[a + 1];
                }
                N--;

                deadPersonsCount = deadCountByAge + deadCountByDisease;
                Array.Resize(ref Persons, Persons.Length - 1);
            }
        }
        private Person BirthPerson(Person firstPerson, Person secondPerson) // Narodziny nowego osobnika, szansa na to wynosi  0.2
        {
            if (firstPerson.GetAge() > 20 && firstPerson.GetAge() < 40 && secondPerson.GetAge() > 20 && secondPerson.GetAge() < 40)
            {
                Person child = new Person(firstPerson.GetCurrentPosition());
            }
            return firstPerson;
        }
        private Person FindClosestPerson(Person person) // Szuka najblizszej osoby; Spotkanie odbywa sie jesli ktos jest w odleglosc 2 kratek
        {
            int[] iXY = person.GetCurrentPosition();
            double minDistance = double.MaxValue;
            double maxX, maxY;
            Person closestPerson = null;
            foreach (Person someone in Persons)
            {
                if (person != someone && someone.hasMetPerson == false)
                {
                    int[] jXY = someone.GetCurrentPosition();
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
        private void IsMeetSomeone(Person person) // Sprawdza czy osobnik sie z kims spotkal
        {
            if (person.hasMetPerson != true)
            {
                Person closestPerson = FindClosestPerson(person);
                if (closestPerson != null)
                {
                    CheckConditionDuringMeeting(person, closestPerson);
                }
            }
        }
        private void CheckConditionDuringMeeting(Person firstPerson, Person secondPerson) // sprawdza stany osobnikow podczas spotkania
        {
            firstPerson.hasMetPerson = true;
            secondPerson.hasMetPerson = true;
            string firstPersonCondition = firstPerson.GetDiseaseCondition();
            string secondPersonCondition = secondPerson.GetDiseaseCondition();

            if (firstPersonCondition == "ZZ" && secondPersonCondition == "Z" || firstPersonCondition == "Z" && secondPersonCondition == "ZZ")
            {    // ZZ z Z || Z z ZZ
                if (firstPersonCondition == "ZZ")
                {
                    if (firstPerson.GetResistanceRangeName() == "low")
                        ChangeDiseaseCondition(firstPerson, "Z");
                }
                else
                {
                    if (secondPerson.GetResistanceRangeName() == "low")
                        ChangeDiseaseCondition(secondPerson, "Z");
                }
            }
            else if (firstPersonCondition == "ZZ" && secondPersonCondition == "C" || firstPersonCondition == "C" && secondPersonCondition == "ZZ")
            {   // ZZ z C || C z ZZ
                if (firstPersonCondition == "ZZ")
                {
                    if (firstPerson.GetResistanceRangeName() == "low" || firstPerson.GetResistanceRangeName() == "medium")
                        ChangeDiseaseCondition(firstPerson, "Z");
                    else
                    {
                        double newResistance = firstPerson.GetCurrentResistance() - 3;
                        firstPerson.SetResistance(newResistance);
                    }
                }
                else
                {
                    if (secondPerson.GetResistanceRangeName() == "low" || secondPerson.GetResistanceRangeName() == "medium")
                        ChangeDiseaseCondition(secondPerson, "Z");
                    else
                    {
                        double newResistance = secondPerson.GetCurrentResistance() - 3;
                        secondPerson.SetResistance(newResistance);
                    }
                }
            }
            else if (firstPersonCondition == "ZZ" && secondPersonCondition == "ZD" || firstPersonCondition == "ZD" && secondPersonCondition == "ZZ")
            {   // ZZ z ZD || ZD z ZZ
                if (firstPersonCondition == "ZZ")
                {
                    double newResistance = secondPerson.GetCurrentResistance() + 1;
                    secondPerson.SetResistance(newResistance);
                }
                else
                {
                    double newResistance = firstPerson.GetCurrentResistance() + 1;
                    firstPerson.SetResistance(newResistance);
                }

            }
            else if (firstPersonCondition == "ZZ" && secondPersonCondition == "ZZ")
            {     // ZZ z ZZ
                double resistancePersonOne = firstPerson.GetMaxResistanceByAge();
                secondPerson.SetResistance(resistancePersonOne);
                double resistancePersonTwo = secondPerson.GetMaxResistanceByAge();
                secondPerson.SetResistance(resistancePersonTwo);
            }
            else if (firstPersonCondition == "C" && secondPersonCondition == "Z" || firstPersonCondition == "Z" && secondPersonCondition == "C")
            {     // C z Z || Z z C
                if (firstPersonCondition == "C")
                {
                    if (secondPerson.GetResistanceRangeName() == "low" || secondPerson.GetResistanceRangeName() == "medium")
                        ChangeDiseaseCondition(secondPerson, "C");
                    firstPerson.ResetConditionDuration();
                }
                else
                {
                    if (firstPerson.GetResistanceRangeName() == "low" || firstPerson.GetResistanceRangeName() == "medium")
                        ChangeDiseaseCondition(firstPerson, "C");
                    secondPerson.ResetConditionDuration();
                }
            }
            else if (firstPersonCondition == "C" && secondPersonCondition == "ZD" || firstPersonCondition == "ZD" && secondPersonCondition == "C")
            {   // C z ZD || ZD z C
                if (firstPersonCondition == "C")
                {
                    if (secondPerson.GetResistanceRangeName() == "low" || secondPerson.GetResistanceRangeName() == "medium")
                        ChangeDiseaseCondition(secondPerson, "Z");
                }
                else
                {
                    if (firstPerson.GetResistanceRangeName() == "low" || firstPerson.GetResistanceRangeName() == "medium")
                        ChangeDiseaseCondition(firstPerson, "Z");
                }
            }
            else if (firstPersonCondition == "C" && secondPersonCondition == "C")
            {   // C z C
                if (firstPerson.GetCurrentResistance() < secondPerson.GetCurrentResistance())
                {
                    firstPerson.SetResistance(firstPerson.GetCurrentResistance());
                    secondPerson.SetResistance(firstPerson.GetCurrentResistance());
                }
                else
                {
                    secondPerson.SetResistance(secondPerson.GetCurrentResistance());
                    firstPerson.SetResistance(secondPerson.GetCurrentResistance());
                }
                firstPerson.IncreaseConditionDuration();
                secondPerson.IncreaseConditionDuration();
            }
            else if (firstPersonCondition == "Z" && secondPersonCondition == "ZD" || firstPersonCondition == "ZD" && secondPersonCondition == "C")
            {   // Z z ZD || ZD z Z
                if (secondPersonCondition == "ZD")
                {
                    double resistancePerson = secondPerson.GetCurrentResistance();
                    resistancePerson -= 1;
                    secondPerson.SetResistance(resistancePerson);
                }
                else
                {
                    double resistancePerson = firstPerson.GetCurrentResistance();
                    resistancePerson -= 1;
                    firstPerson.SetResistance(resistancePerson);
                }
            }
            else if (firstPersonCondition == "Z" && secondPersonCondition == "Z")
            {   // Z z Z
                double resistancePersonOne = firstPerson.GetCurrentResistance() - 1;
                firstPerson.SetResistance(resistancePersonOne);
                double resistancePersonTwo = secondPerson.GetCurrentResistance() - 1;
                secondPerson.SetResistance(resistancePersonTwo);
            }

            ChangeMovementDirection(firstPerson);
            ChangeMovementDirection(secondPerson);
        }
        private void MoveAllPerson() // porusza wszystkimi osobnikami
        {
            for (int i = 0; i < N; i++)
            {
                int[] XY = Persons[i].GetCurrentPosition();
                int direction = Persons[i].GetMovementDirection();
                int speed = Persons[i].GetSpeed();

                if (direction == 1)
                {
                    if (XY[0] - speed < 0)
                    {
                        XY[0] = 0;
                        ChangeMovementDirection(Persons[i]);
                    }
                    else if (XY[1] - speed < 0)
                    {
                        XY[1] = 0;
                        ChangeMovementDirection(Persons[i]);
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
                        ChangeMovementDirection(Persons[i]);
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
                        ChangeMovementDirection(Persons[i]);
                    }
                    else if (XY[1] - speed < 0)
                    {
                        XY[1] = 0;
                        ChangeMovementDirection(Persons[i]);
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
                        ChangeMovementDirection(Persons[i]);
                    }
                    else
                    {
                        XY[0] = XY[0] - speed;
                    }
                }
                else if (direction == 5)
                {
                    ChangeMovementDirection(Persons[i]);
                }
                else if (direction == 6)
                {
                    if (XY[0] + speed > 100)
                    {
                        XY[0] = 100;
                        ChangeMovementDirection(Persons[i]);
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
                        ChangeMovementDirection(Persons[i]);
                    }

                    else if (XY[1] + speed > 100)
                    {
                        XY[1] = 100;
                        ChangeMovementDirection(Persons[i]);
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
                        ChangeMovementDirection(Persons[i]);
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
                        ChangeMovementDirection(Persons[i]);
                    }

                    else if (XY[1] + speed > 100)
                    {
                        XY[1] = 100;
                        ChangeMovementDirection(Persons[i]);
                    }
                    else
                    {
                        XY[0] = XY[0] + speed;
                        XY[1] = XY[1] + speed;
                    }
                }
                Persons[i].SetCurentPosition(XY[0], XY[1]);
            }
        }
        private void ChangeMovementDirection(Person person) // ustawia nowy losowy kierunek ruchu dla osobnika
        {
            Random randomNumber = new Random();
            int newD = randomNumber.Next(1, 10);
            person.SetMovementDirection(newD);
        }
        private void ClearMeeting() // resetuje mozliwosc spotkania wszystkich osobnikow
        {
            for (int i = 0; i < N; i++)
                Persons[i].hasMetPerson = false;
        }
    }

}
