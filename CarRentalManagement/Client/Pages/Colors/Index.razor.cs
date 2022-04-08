using CarRentalManagement.Client.Contracts;
using CarRentalManagement.Client.Services;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CarRentalManagement.Client.Pages.Colors
{
    public partial class Index
    {
        [Inject] IHttpRepository<Color> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Colors = await _client.GetAll(Endpoints.ColorsEndpoint);
        }

        async Task Delete(int colourId)
        {
            var colour = Colors.First(q => q.Id == colourId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {colour.Name}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.ColorsEndpoint, colourId);
                await OnInitializedAsync();
            }

        }

    }
}
