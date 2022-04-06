using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Create
    {
        [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Customer customer = new Customer();

        private async Task CreateCustomer()
        {
            await _client.Create(Endpoints.CustomersEndpoint, customer);
            _navManager.NavigateTo("/customers/");
        }
    }
}
