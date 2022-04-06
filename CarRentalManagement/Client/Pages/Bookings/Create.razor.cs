﻿using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Bookings
{
    public partial class Create
    {
        [Inject] IHttpRepository<Booking> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Booking booking = new Booking
        {
            DateOut = DateTime.Now.Date
        };

        private async Task CreateBooking()
        {
            await _client.Create(Endpoints.BookingsEndpoint, booking);
            _navManager.NavigateTo("/bookings/");
        }
    }
}
