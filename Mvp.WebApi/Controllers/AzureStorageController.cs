using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

[ApiController]
[Route("[controller]")]
public class AzureStorageController : ControllerBase
{
    private readonly ILogger<AzureStorageController> _logger;

    public AzureStorageController(ILogger<AzureStorageController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get()
    {
        //WIP test to container
        BlobContainerClient blob = new BlobContainerClient("UseDevelopmentStorage=true", "sample-container");
        blob.CreateIfNotExists();

        var test = blob.GetBlobs(Azure.Storage.Blobs.Models.BlobTraits.All);

        return "test";
    }
}