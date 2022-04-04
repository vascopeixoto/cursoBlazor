﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Index
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Vehicle> Vehicles;

        protected async override Task OnInitializedAsync()
        {
            Vehicles = await _client.GetFromJsonAsync<List<Vehicle>>($"{Endpoints.VehiclesEndpoint}");
        }

        async Task Delete(int vehicleId)
        {
            var vehicle = Vehicles.First(q => q.Id == vehicleId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {vehicle.Brand.Name} {vehicle.Model.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.VehiclesEndpoint}{vehicleId}");
                await OnInitializedAsync();
            }

        }
    }
}
