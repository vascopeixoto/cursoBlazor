﻿using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using CarRentalManagement.Client.Static;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Components;

namespace CarRentalManagement.Client.Pages.Models
{
    public partial class FormComponent
    {
        [Parameter] public bool Disabled { get; set; } = false;
        [Parameter] public Model model { get; set; }
        [Parameter] public string ButtonText { get; set; } = "Save";
        [Parameter] public EventCallback OnValidSubmit { get; set; }
    }
}