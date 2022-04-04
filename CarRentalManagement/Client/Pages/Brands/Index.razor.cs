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

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class Index
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private List<Brand> Brands;

        protected async override Task OnInitializedAsync()
        {
            Brands = await _client.GetFromJsonAsync<List<Brand>>($"{Endpoints.BrandsEndpoint}");
        }

        async Task Delete(int brandId)
        {
            var brand = Brands.First(q => q.Id == brandId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {brand.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.BrandsEndpoint}{brandId}");
                await OnInitializedAsync();
            }

        }
    }
}