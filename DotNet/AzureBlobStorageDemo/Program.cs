using Azure.Storage.Blobs;

// step 1, service client
string connection = "DefaultEndpointsProtocol=https;AccountName=fullstack2023;AccountKey=AJcvcXCxur5o8LBk5m2ZqDgnjHfP+Ggb9CEBUjNM+GMp48PciFz+I3VnMfuZz2AVbVpJIDFgwGLW+AStYoeP4g==;EndpointSuffix=core.windows.net";
BlobServiceClient client = new(connection);
Console.WriteLine("Blob service client created.");

// step 2, container
string containerName = "saranen";
BlobContainerClient container = client.GetBlobContainerClient(containerName);
Console.WriteLine("Blob container client created.");

// step 3, blob uplad
string blobName = "janis-testing";
BlobClient blobClient = container.GetBlobClient(blobName);
string blobContents = "Hello World, from a C# application.";

Console.WriteLine("About to upload demo blob...");
await blobClient.UploadAsync(BinaryData.FromString(blobContents), overwrite: true);
Console.WriteLine("Demo blob succesfully uploaded!");
