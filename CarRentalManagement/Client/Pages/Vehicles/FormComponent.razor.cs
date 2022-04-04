using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class FormComponent
    {
        [Inject] HttpClient _client { get; set; }

        private IList<Brand> Brands;
        private IList<Model> Models;
        private IList<Color> Colors;

        protected async override Task OnInitializedAsync()
        {
            Brands = await _client.GetFromJsonAsync<List<Brand>>($"{Endpoints.BrandsEndpoint}");
            Models = await _client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
            Colors = await _client.GetFromJsonAsync<List<Color>>($"{Endpoints.ColorsEndpoint}");
        }

        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Vehicle vehicle { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
