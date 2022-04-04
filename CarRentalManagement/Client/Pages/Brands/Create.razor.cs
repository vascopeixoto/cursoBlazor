using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class Create
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Brand brand = new Brand();

        private async Task CreateBrand()
        {
            await _client.PostAsJsonAsync(Endpoints.BrandsEndpoint, brand);
            _navManager.NavigateTo("/brands/");
        }
    }
}
