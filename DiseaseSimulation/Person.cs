namespace DiseaseSimulation
{
    internal class Person
    {
        private int[] _position;    // położenie - [x,y] od [0-100]
        private int _speed;     // predkosc - [1,2,3]
        private int _direction;     // kierunek ruchu
        //  [7] [8] [9]
        //  [4] [5] [6]
        //  [1] [2] [3]
        private string _diseaseCondition;  // stan - chory (C), zarazony (Z), zdrowiejacy (ZD), zdrowy (ZZ)
        private int _age;   // wiek - [0-100]
        private double _resistance; // odpornosc na chorobe [0,10] -> niska: (0, 3> ; srednia: (3, 6 > ; wysoka: (6, 10 >

        private int _durationCondition;
        public bool hasMetPerson;


        public Person() // domyslny kontruktor, wykorzystywany do tworzenia osobnikow podczas inicjalizacji symulacji
        {
            Random randomNumber = new Random();

            _position = new int[2] { 0, 0 };
            int x = randomNumber.Next(100); // x
            int y = randomNumber.Next(100); // y
            SetCurentPosition(x, y);

            int speed = randomNumber.Next(1, 3+1);
            SetSpeed(speed);

            int direction = randomNumber.Next(1, 10);
            SetMovementDirection(direction);

            int condition = randomNumber.Next(1, 4+1);
            SetDiseaseCondition(condition);

            int age = randomNumber.Next(1, 60+1);
            SetAge(age);

            SetResistanceForNewAgeRange();

            hasMetPerson = false;
        }
        public Person(int[] position) // kontruktor, wykorzystywany do tworzenia nowego osobnika podczas spotkania dwoch osobnikow
        {
            Random randomNumber = new Random();

            SetCurentPosition(position[0], position[1]);

            int speed = randomNumber.Next(1, 3 + 1);
            SetSpeed(speed);

            int direction = randomNumber.Next(1, 10);
            SetMovementDirection(direction);

            SetDiseaseCondition(4);

            SetAge(0);

            double resistance = GetMaxResistanceByAge();
            SetResistance(resistance);

            ResetConditionDuration();

            hasMetPerson = true;
        }
        public void SetCurentPosition(int x,int y)
        {
            _position[0] = x;
            _position[1] = y;
        }
        public int[] GetCurrentPosition()
        {
            return _position;
        }
        public void SetSpeed(int speed)
        {
            _speed = speed;
        }
        public int GetSpeed()
        {
            return _speed;
        }
        public void SetMovementDirection(int direction)
        {
            _direction = direction;
        }
        public int GetMovementDirection()
        {
            return _direction;
        }
        public void SetDiseaseCondition(int condition)
        {
            if (condition == 1) // Chory (C)
            {
                _diseaseCondition = "C";
                ResetConditionDuration();
            }
            else if (condition == 2) // Zarazony (Z)
            {
                _diseaseCondition = "Z";
                ResetConditionDuration();
            }
            else if (condition == 3) // Zdrowiejacy (ZD)
            {
                _diseaseCondition = "ZD";
                ResetConditionDuration();
            }
            else // Zdrowy (ZZ)
            {
                _diseaseCondition = "ZZ";
                ResetConditionDuration();
            }
        }
        public string GetDiseaseCondition()
        {
            return _diseaseCondition;
        }
        public void IncreaseConditionDuration()
        {
            _durationCondition++;
        }
        public int GetConditionDuration()
        {
            return _durationCondition;
        }
        public void ResetConditionDuration()
        {
            _durationCondition = 0;
        }
        public void SetAge(int age)
        {
            _age = age;
        }
        public int GetAge()
        {
            return _age;
        }
        public void SetResistanceForNewAgeRange()
        {
            Random randomNumber = new Random();
            string resistanceRangeName = GetResistanceRangeName();
            if (resistanceRangeName == "low")
                _resistance = randomNumber.Next(1, 3 + 1);
            else if (resistanceRangeName == "medium")
                _resistance = randomNumber.Next(3, 6 + 1);
            else
                _resistance = randomNumber.Next(6, 10 + 1);
        }
        public string GetResistanceRangeName()
        {
            if ((_age >= 0 && _age < 15) || (_age >= 70 && _age <= 100))    // niska odpornosc,    wiek < 0, 15) U < 70, 100 >
                return "low";
            else if (_age >= 40 && _age < 70)   // srednia odpornosc,   wiek < 40, 70)
                return "medium";
            else    // wysoka odpornosc,    wiek < 15, 40)
                return "high";
        }
        public void SetResistance(double resistance)
        {
            _resistance = resistance;
        }
        public double GetCurrentResistance()
        {
            return _resistance;
        }
        public double GetMaxResistanceByAge()
        {
            if ((_age >= 0 && _age < 15) || (_age >= 70 && _age <= 100))    // niska odpornosc,    wiek < 0, 15) U < 70, 100 >,     odpornosc (0,3>
                return 3;
            else if (_age >= 40 && _age < 70)   // srednia odpornosc,   wiek < 40, 70)
                return 6;
            else    // wysoka odpornosc,    wiek < 15, 40)
                return 10;
        }
    }
}
