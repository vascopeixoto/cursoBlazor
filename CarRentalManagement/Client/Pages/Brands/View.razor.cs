using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class View
    {
        [Inject] IHttpRepository<Brand> _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        [Parameter] public int id { get; set; }
        Brand brand = new Brand();

        protected async override Task OnParametersSetAsync()
        {
            brand = await _client.Get(Endpoints.BrandsEndpoint,id);
        }
    }
}
