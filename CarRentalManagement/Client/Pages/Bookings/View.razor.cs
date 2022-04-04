using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class View
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Booking booking = new Booking();

        protected async override Task OnParametersSetAsync()
        {
            booking = await _client.GetFromJsonAsync<Booking>($"{Endpoints.BookingsEndpoint}{id}");
        }
    }
}
