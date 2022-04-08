using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Static
{
    public static class Endpoints
    {

        public static string Prefix = "api";

        public static string BrandsEndpoint = $"{Prefix}/brands";
        public static string VehiclesEndpoint = $"{Prefix}/vehicles";
        public static string ModelsEndpoint = $"{Prefix}/models";
        public static string BookingsEndpoint = $"{Prefix}/bookings";
        public static string CustomersEndpoint = $"{Prefix}/customers";
        public static string ColorsEndpoint = $"{Prefix}/colors";

    }
}
