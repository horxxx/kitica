using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
        {
            List<User> _userList = new List<User>();
            private string _ime, _prezime;
        private float tezina;
        private float visina;

        public string Ime { get => _ime; set => _ime = value; }
        public string Prezime { get => _prezime; set => _prezime = value; }
        public float Visina { get => visina; set => visina = value; }
        public float Tezina { get => tezina; set => tezina = value; }

        public User( string ime, string prezime, float visina, float tezina)
            {
                Ime = ime;
                Prezime = prezime;
                Visina = visina;
                Tezina = tezina;
            }

            public string GetIme()
            {
                return Ime;
            }

            public void SetIme(string ime)
            {
                Ime = ime;
            }

            public string GetPrezime()
            {
                return Prezime;
            }

            public void SetPrezime(string prezime)
            {
                Prezime = prezime;
            }

            public float GetVisina()
            {
                return Visina;
            }

            public void SetVisina(float visina)
            {
                Visina = visina;
            }

            public float GetTezina()
            {
                return Tezina;
            }

            public void SetTezina(float tezina)
            {
                Tezina = tezina;
            }

        }
    }
