namespace MainLab
{
   
    // Клас "Материк"
    class Сontinent
    {
        public string NameContinent { get; set; }
        public static int count { get; set; }
        public Сontinent(string nameContinent)
        {
            NameContinent = nameContinent;
            count ++;
        } 
    }

    // Клас "Океан"
    class Ocean
    {
        public string NameOcean { get; set; }
        public static int count { get; set; }
        public Ocean(string nameOcean)
        {
            NameOcean = nameOcean;
            count ++;
        }


    }

    // Клас "Острів"
    class Island
    {
        public string NameIsland { get; set; }
        public static int count { get; set; }
        public Island(string nameIsland)
        {
            NameIsland = nameIsland;
            count ++;
        }

    }

    // Клас "Планета"
    class Planet
    {
        public string NamePlanet { get; set; }
        public List<Сontinent> Continents { get; set; }
        public List<Ocean> Oceans { get; set; }
        public List<Island> Islands { get; set; }

        public Planet(string namePlanet)
        {
            NamePlanet = namePlanet;
            Continents = new List<Сontinent>();
            Oceans = new List<Ocean>();
            Islands = new List<Island>();
        }

        // Додати obj до планети

        public void AddSomeObject<T>(T obj, List<T> ts)
        {
            if (obj is T item)
                ts.Add(item);
        }


        // Отримати кількість континентів на планеті
        public int CountContinent()
          => Continents.Count;

        // Отримати кількість океанів на планеті
        public int CountOcean()
          => Oceans.Count;

        // Отримати кількість островів на планеті    
        public int CountIsland()
          => Islands.Count;
        public override string ToString()
        {
            return $"Планета: {NamePlanet}, Кількість материків: {CountContinent()}, Кількість океанів: {CountOcean()}, Кількість островів: {CountIsland()}";
        }

        public override bool Equals(object? obj)
        {
            // якщо параметр методу представляє тип Planet
            // повертаємо true, якщо імена совпадають
            if (obj is Planet planet) return NamePlanet == planet.NamePlanet;
            return false;
        }
        public override int GetHashCode() => NamePlanet.GetHashCode();
    }
}