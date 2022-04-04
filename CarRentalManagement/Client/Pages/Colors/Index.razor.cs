using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] IJSRuntime js { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }


        private List<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            _interceptor.MonitorEvent();
            Colors = await _client.GetFromJsonAsync<List<Color>>($"{Endpoints.ColorsEndpoint}");
        }

        async Task Delete(int colorId)
        {
            var color = Colors.First(q => q.Id == colorId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {color.Name}?");
            if (confirm)
            {
                await _client.DeleteAsync($"{Endpoints.ColorsEndpoint}{colorId}");
                await OnInitializedAsync();
            }

        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
