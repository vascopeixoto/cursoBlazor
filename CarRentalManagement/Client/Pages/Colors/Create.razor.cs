using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Create : IDisposable
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }
        [Inject] HttpInterceptorService _interceptor { get; set; }


        Color color = new Color();

        private async Task CreateColor()
        {
            _interceptor.MonitorEvent();
            await _client.PostAsJsonAsync(Endpoints.ColorsEndpoint, color);
            _navManager.NavigateTo("/colors/");
        }

        public void Dispose()
        {
            _interceptor.DisposeEvent();
        }
    }
}
