using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class Edit
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Brand brand = new Brand();

        protected async override Task OnParametersSetAsync()
        {
            brand = await _client.GetFromJsonAsync<Brand>($"{Endpoints.BrandsEndpoint}{id}");
        }

        async Task EditBrand()
        {
            await _client.PutAsJsonAsync($"{Endpoints.BrandsEndpoint}{id}", brand);
            _navManager.NavigateTo("/brands/");

        }
    }
}
