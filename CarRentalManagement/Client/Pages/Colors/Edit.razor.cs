﻿using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Contracts;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Edit
    {
        [Inject] IHttpRepository<Color> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Color color = new Color();

        protected async override Task OnParametersSetAsync()
        {
            color = await _client.Get(Endpoints.ColorsEndpoint, id);
        }

        async Task EditColor()
        {
            await _client.Update(Endpoints.ColorsEndpoint, color, id);
            _navManager.NavigateTo("/colors/");
        }

    }
}
