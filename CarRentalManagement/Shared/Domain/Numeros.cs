using System;
namespace CarRentalManagement.Shared.Domain
{
    public class Numeros : IComparable<Numeros>
    {
        public int n1 { get; set; }

        public Numeros(int num)
        {
            n1 = num;
        }

        public int CompareTo(Numeros other)
        {
            return n1.CompareTo(other.n1);
        }
    }
}
