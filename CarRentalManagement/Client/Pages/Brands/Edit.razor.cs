using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using CarRentalManagement.Client.Contracts;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class Edit 
    {
       [Inject] IHttpRepository<Brand> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }

        [Parameter] public int id { get; set; }
        Brand brand = new Brand();

        protected async override Task OnParametersSetAsync()
        {
            brand = await _client.Get(Endpoints.BrandsEndpoint,id);
        }

        async Task EditBrand()
        {
            await _client.Update(Endpoints.BrandsEndpoint,brand,id);
            _navManager.NavigateTo("/makes/");
        }
        
    }
}
