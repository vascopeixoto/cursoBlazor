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

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class Index
    {
        [Inject] IHttpRepository<Model> _client { get; set; }
        [Inject] IJSRuntime js { get; set; }

        private IList<Model> Models;

        protected async override Task OnInitializedAsync()
        {
            Models = await _client.GetAll(Endpoints.ModelsEndpoint);
        }

        protected async override Task OnAfterRenderAsync(bool firstRender)
        {
            await js.InvokeVoidAsync("AddDataTable", "#modelsTable");
        }

        void IDisposable.Dispose()
        {
            js.InvokeVoidAsync("DataTablesDispose", "#modelsTable");

        }


        async Task Delete(int modelId)
        {
            var model = Models.First(q => q.Id == modelId);
            var confirm = await js.InvokeAsync<bool>("confirm", $"Do you want to delete {model.Name}?");
            if (confirm)
            {
                await _client.Delete(Endpoints.ModelsEndpoint,modelId);
                await OnInitializedAsync();
            }

        }
    }
}
