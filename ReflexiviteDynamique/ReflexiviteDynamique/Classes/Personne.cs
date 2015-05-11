namespace ReflexiviteDynamique.Classes
{
    class Personne
    {
        private int Age;
        private string Nom;

        public Personne()
        {
            SetAge(1);
            SetNom("Bob");
        }

        public Personne(int age)
        {
            SetAge(age);
            SetNom("George");
        }

        public Personne(string nom)
        {
            SetAge(1);
            SetNom(nom);
        }

        public Personne(int age, string nom)
        {
            SetAge(age);
            SetNom(nom);
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetNom()
        {
            return Nom;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetNom(string nom)
        {
            Nom = nom;
        }

        public void AjouterAnnee()
        {
            ++Age;
        }

        public string Saluer()
        {
            return "Bonjour " + Nom;
        }
    }
}
