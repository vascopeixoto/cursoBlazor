using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace CarRentalManagement.Client.Pages.Vehicles
{
    public partial class FormComponent
    {
        [Inject] HttpClient _client { get; set; }

        private IList<Brand> Brands;
        private IList<Model> Models;
        private IList<Color> Colors;
        string UploadFileWarning;

        protected async override Task OnInitializedAsync()
        {
            Brands = await _client.GetFromJsonAsync<List<Brand>>($"{Endpoints.BrandsEndpoint}");
            Models = await _client.GetFromJsonAsync<List<Model>>($"{Endpoints.ModelsEndpoint}");
            Colors = await _client.GetFromJsonAsync<List<Color>>($"{Endpoints.ColorsEndpoint}");
        }

        private async void HandleFileSelection(InputFileChangeEventArgs e)
        {
            var file = e.File;
            if(file != null)
            {
                var ext = System.IO.Path.GetExtension(file.Name);
                if (ext.ToLower().Contains("jpg") || ext.ToLower().Contains("png") || ext.ToLower().Contains("jpeg"))
                {
                    var picID = Guid.NewGuid().ToString().Replace("-", "");
                    vehicle.ImageName = $"{picID}{ext}";
                    vehicle.Image = new byte[file.Size];
                    await file.OpenReadStream().ReadAsync(vehicle.Image);
                    UploadFileWarning = string.Empty;
                }
                else
                {
                    UploadFileWarning = "Please select a valid image";
                }
            }
        }
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Vehicle vehicle { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}
