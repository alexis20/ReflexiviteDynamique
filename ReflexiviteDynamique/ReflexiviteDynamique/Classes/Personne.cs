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

        public Personne(int a)
        {
            SetAge(a);
            SetNom("George");
        }

        public Personne(string n)
        {
            SetAge(1);
            SetNom(n);
        }

        public Personne(int a, string n)
        {
            SetAge(a);
            SetNom(n);
        }

        public int GetAge()
        {
            return Age;
        }

        public string GetNom()
        {
            return Nom;
        }

        public void SetAge(int a)
        {
            Age = a;
        }

        public void SetNom(string n)
        {
            Nom = n;
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
