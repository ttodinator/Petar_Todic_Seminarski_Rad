using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperation.ZaposleniSO
{
    public class LoginSO:SystemOperationBase
    {
        public Zaposleni Result { get; private set; }
        public List<Zaposleni> Zaposlenis { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Zaposlenis = repository.GetAll(new Zaposleni()).Cast<Zaposleni>().ToList();
            //Users = repository.GetAll(new User()).Cast<User>().ToList();

            //  To-Do:
            // ? Result = repository.Search(entity);

            //dummy implementacija
            //ne sme ovako u projektnom radu!

            Zaposleni z = (Zaposleni)entity;
            if (Zaposlenis.Any(zaposleni => zaposleni.KorisnickoIme == z.KorisnickoIme && zaposleni.Lozinka == z.Lozinka))
            {
                Result = Zaposlenis.First(zaposleni => zaposleni.KorisnickoIme == z.KorisnickoIme && zaposleni.Lozinka == z.Lozinka);

            }
            /*if(u.Username =="pera" && u.Password == "pera")
            {
                u.Id = 1;
                u.FirstName = "Pera";
                u.LastName = "Peric";
                Result = u;
            }*/
            else
            {
                throw new Exception("Pogresna sifra");
            }
        }
    }
}
