using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Edit
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Customer customer = new Customer();

        protected async override Task OnParametersSetAsync()
        {
            customer = await _client.GetFromJsonAsync<Customer>($"{Endpoints.CustomersEndpoint}{id}");
        }

        async Task EditCustomer()
        {
            await _client.PutAsJsonAsync($"{Endpoints.CustomersEndpoint}{id}", customer);
            _navManager.NavigateTo("/customers/");

        }
    }
}
