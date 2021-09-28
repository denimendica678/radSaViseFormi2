using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radSaViseFormi
{
    public class Student
    {
        public Student()
        {

        }

        private string ime, prezime, smjer, brojIndeksa;
        private DateTime datumRodjenja;

        public Student(string ime, string prezime, string smjer, string brojIndeksa, DateTime datumRodjenja)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Smjer = smjer;
            this.BrojIndeksa = brojIndeksa;
            this.DatumRodjenja = datumRodjenja;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Smjer { get => smjer; set => smjer = value; }
        public string BrojIndeksa { get => brojIndeksa; set => brojIndeksa = value; }
        public DateTime DatumRodjenja { get => datumRodjenja; set => datumRodjenja = value; }

        public override string ToString()
        {
            string ispis = "Ime: " + this.ime + " Prezime: " + this.Prezime + " Smjer: " + this.smjer + " Indeks: " + this.brojIndeksa + " Datum rođenja: " + this.datumRodjenja.ToShortDateString();
            return ispis;
        }
    }
}
