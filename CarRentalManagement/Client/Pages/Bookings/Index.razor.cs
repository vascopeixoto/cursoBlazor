using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            Bookings = await _client.GetFromJsonAsync<List<Booking>>($"{Endpoints.BookingsEndpoint}");
        }

        async Task Delete(int bookingId)
        {
            var booking = Bookings.First(q => q.Id == bookingId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {booking.Customer.EmailAddress} Booking?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.BookingsEndpoint}{bookingId}");
                await OnInitializedAsync();
            }

        }
    }
}
