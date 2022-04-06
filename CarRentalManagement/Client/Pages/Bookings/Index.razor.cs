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

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Index
    {
        [Inject] IHttpRepository<Booking> _client { get; set; }

        [Inject] IJSRuntime js { get; set; }

        private IList<Booking> Bookings;

        protected async override Task OnInitializedAsync()
        {
            Bookings = await _client.GetAll(Endpoints.BookingsEndpoint);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("AddDataTable","#bookingsTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#bookingsTable");

        }

        async Task Delete(int bookingId)
        {
            var booking = Bookings.First(q => q.Id == bookingId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {booking.Customer.EmailAddress} Booking?");
            if (confirm)
            {
                await _client.Delete(Endpoints.BookingsEndpoint,bookingId);
                await OnInitializedAsync();
            }

        }
    }
}
