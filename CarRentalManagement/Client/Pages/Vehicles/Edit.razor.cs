using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class Edit
    {
        [Inject] IHttpRepository<Vehicle> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Vehicle vehicle = new Vehicle();

        protected async override Task OnParametersSetAsync()
        {
            vehicle = await _client.Get(Endpoints.VehiclesEndpoint, id);
        }

        async Task EditVehicle()
        {
            await _client.Update(Endpoints.VehiclesEndpoint, vehicle, id);
            _navManager.NavigateTo("/vehicles/");

        }
    }
}
