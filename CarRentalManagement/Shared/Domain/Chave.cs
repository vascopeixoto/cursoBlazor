using System;
using System.Collections.Generic;

namespace CarRentalManagement.Shared.Domain
{
    public class Chave
    {
        public SortedSet<Numeros> num = new SortedSet<Numeros>();
        public SortedSet<Estrelas> est = new SortedSet<Estrelas>();

        public void AddNumeros()
        {
            Random rnd = new Random();
            while (num.Count != 5)
            {
                int n = rnd.Next(1, 51);
                num.Add(new Numeros(n));
            }
        }

        public void RemoveNumeros()
        {
            num.Clear();
        }

        public void AddEstrelas()
        {
            Random rnd = new Random();
            while (est.Count != 2)
            {
                int n = rnd.Next(1, 13);
                est.Add(new Estrelas(n));
            }
        }

        public void RemoveEstrelas()
        {
            est.Clear();
        }
    }
}
