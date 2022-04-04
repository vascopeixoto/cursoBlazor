using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class FormComponent
    {
        [Inject] HttpClient _client { get; set; }

        private IList<Vehicle> Vehicles;
        private IList<Customer> Customers;

        protected async override Task OnInitializedAsync()
        {
            Vehicles = await _client.GetFromJsonAsync<List<Vehicle>>($"{Endpoints.VehiclesEndpoint}");
            Customers = await _client.GetFromJsonAsync<List<Customer>>($"{Endpoints.CustomersEndpoint}");
        }

        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Booking booking { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
