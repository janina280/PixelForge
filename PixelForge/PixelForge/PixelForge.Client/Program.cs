using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzczODI1N0AzMjM4MmUzMDJlMzBaVnRVVWwzaGFlQ2RGaEM3dFFZUnk0VXRoRVVNNXZBdVNCV2ZQTlBlTE8wPQ==");

builder.Services.AddSyncfusionBlazor();
await builder.Build().RunAsync();