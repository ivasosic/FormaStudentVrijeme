using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaStudent
{
    public class Student
    {
        private string ime;
        private string prezime;
        private string brojIndeksa;
        private string smjer;
        private DateTime datumRodenja;
        private string tipStudija;

        public Student(string ime, string prezime, string brojIndeksa, string smjer, DateTime datumRodenja, string tipStudija)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.brojIndeksa = brojIndeksa;
            this.smjer = smjer;
            this.datumRodenja = datumRodenja;
            this.tipStudija = tipStudija;
        }

        public override string ToString()
        {
            return $"{tipStudija} | {ime} {prezime} | {smjer} | {brojIndeksa} | {datumRodenja.ToShortDateString()}";
        }
    }
}
