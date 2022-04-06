using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CarRentalManagement.Client.Pages.Customers
{
    public partial class Index
    {
        [Inject] IHttpRepository<Customer> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            Customers = await _client.GetAll(Endpoints.CustomersEndpoint);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("AddDataTable", "#customersTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#customersTable");

        }


        async Task Delete(int customerId)
        {
            var customer = Customers.First(q => q.Id == customerId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {customer.EmailAddress}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.CustomersEndpoint, customerId);
                await OnInitializedAsync();
            }

        }
    }
}
