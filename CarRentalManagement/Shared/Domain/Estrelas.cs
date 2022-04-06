using System;
namespace CarRentalManagement.Shared.Domain
{
    public class Estrelas : IComparable<Estrelas>
    {
        public int n1 { get; set; }

        public Estrelas(int num)
        {
            n1 = num;
        }

        public int CompareTo(Estrelas other)
        {
            return n1.CompareTo(other.n1);
        }
    }
}
