using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index : IDisposable
    {
        [Inject] IHttpRepository<Color> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        private IList<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Colors = await _client.GetAll(Endpoints.ColorsEndpoint);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("AddDataTable", "#colorsTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#colorsTable");

        }

        async Task Delete(int colorId)
        {
            var color = Colors.First(q => q.Id == colorId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {color.Name}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.ColorsEndpoint, colorId);
                await OnInitializedAsync();
            }

        }
    }
}
