using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PastaBar.Models;

namespace PastaBar.Services
{
    public class BestellingService
    {
        private Dictionary<int, Pasta> bestellingen = new Dictionary<int, Pasta>();

        public BestellingService()
        {

        }
        public List<Pasta> FindAll()
        {
            return bestellingen.Values.ToList();
        }
        public Pasta Read(int id)
        {
            return bestellingen[id];
        }
        public void Delete(int id)
        {
            bestellingen.Remove(id);
        }

        /*internal void Add(Pasta p)
        {
            if (bestellingen.Keys.Count != 0)
                p.Id = bestellingen.Keys.Max() + 1;
            else
                p.Id = 1;
            bestellingen.Add(p.Id, p);
        }*/

        internal void Add(Pasta p)
        {
            if (bestellingen.Keys.Count != 0)
                p.Id = bestellingen.Keys.Max() + 1;
            else
                p.Id = 1;
            bestellingen.Add(p.Id, p);
        }
    }
}
