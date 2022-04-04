using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        }

        async Task Delete(int customerId)
        {
            var customer = Customers.First(q => q.Id == customerId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.EmailAddress}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.CustomersEndpoint}{customerId}");
                await OnInitializedAsync();
            }

        }
    }
}
