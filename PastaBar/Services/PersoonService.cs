using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PastaBar.Models;

namespace PastaBar.Services
{
    public class PersoonService
    {
        private Dictionary<int, Persoon> Personnen = new Dictionary<int, Persoon>();

        public PersoonService()
        {

        }
        public List<Persoon> FindAll()
        {
            return Personnen.Values.ToList();
        }
        public Persoon Read(int id)
        {
            return Personnen[id];
        }
        public void Delete(int id)
        {
            Personnen.Remove(id);
        }

        internal void Add(Persoon p)
        {
            if (Personnen.Keys.Count != 0)
                p.Id = Personnen.Keys.Max() + 1;
            else
                p.Id = 1;
            Personnen.Add(p.Id, p);
        }
    }
}
