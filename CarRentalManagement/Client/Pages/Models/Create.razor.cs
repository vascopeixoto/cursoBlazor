using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Create
    {
        [Inject] HttpClient _client { get; set; }
        [Inject] NavigationManager _navManager { get; set; }

        Model model = new Model();

        private async Task CreateModel()
        {
            await _client.PostAsJsonAsync(Endpoints.ModelsEndpoint, model);
            _navManager.NavigateTo("/models/");
        }
    }
}
