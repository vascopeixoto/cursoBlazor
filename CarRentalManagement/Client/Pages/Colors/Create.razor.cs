using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create 
    {
        [Inject] IHttpRepository<Color> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Color color = new Color();

        private async Task CreateColor()
        {
            await _client.Create(Endpoints.ColorsEndpoint, color);
            _navManager.NavigateTo("/colors/");
        }
    }
}
