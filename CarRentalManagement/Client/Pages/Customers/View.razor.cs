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
    public partial class View
    {
        [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            customer = await _client.Get(Endpoints.CustomersEndpoint, id);
        }
    }
}
