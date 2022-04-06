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

namespace CarRentalManagement.Client.Pages.Brands
{
    public partial class Index
    {
        [Inject] IHttpRepository<Brand> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Brand> Brands;

        protected async override Task OnInitializedAsync()
        {
            Brands = await _client.GetAll(Endpoints.BrandsEndpoint);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("AddDataTable", "#brandsTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#brandsTable");

        }

        async Task Delete(int brandId)
        {
            var brand = Brands.First(q => q.Id == brandId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {brand.Name}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.BrandsEndpoint,brandId);
                await OnInitializedAsync();
            }

        }
    }
}
