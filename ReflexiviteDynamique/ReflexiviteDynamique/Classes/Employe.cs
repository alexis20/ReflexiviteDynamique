using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflexiviteDynamique.Classes
{
    class Employe
    {
        DateTime dateEntrer;
        bool Permanent;
        string Nom;
        int Age;
        double Salaire;

        Employe()
        {
            SetNom("swag");
            SetAge(25);
            SetSalaire(25000);
            SetPermanent(false);
            SetDate(DateTime.Now);
        }
        Employe(string nom,int age)
        {
            SetNom(nom);
            SetAge(age);
            SetSalaire(25000);
            SetPermanent(false);
            SetDate(DateTime.Now);
        }
        Employe(string nom,int age, double salaire)
        {
            SetNom(nom);
            SetAge(age);
            SetSalaire(salaire);
            SetPermanent(false);
            SetDate(DateTime.Now);
        }
        Employe(string nom, int age, double salaire,bool permanent)
        {
            SetNom(nom);
            SetAge(age);
            SetSalaire(salaire);
            SetPermanent(permanent);
            SetDate(DateTime.Now);
        }
        Employe(string nom, int age, double salaire, bool permanent, DateTime date)
        {
            SetNom(nom);
            SetAge(age);
            SetSalaire(salaire);
            SetPermanent(permanent);
            SetDate(date);
        }

        public DateTime GetDate()
        {
            return dateEntrer;
        }

        public bool GetPermanent()
        {
            return Permanent;
        }

        public string GetNom()
        {
            return Nom;
        }

        public int GetAge()
        {
            return Age;
        }

        public double GetSalaire()
        {
            return Salaire;
        }

        public void SetDate(DateTime date)
        {
            dateEntrer = date;
        }

        public void SetPermanent(bool permanent)
        {
            Permanent = permanent;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public void SetSalaire(Double salaire)
        {
            Salaire = salaire;
        }

        public void SetNom(string nom)
        {
            Nom = nom;
        }
    }
}
