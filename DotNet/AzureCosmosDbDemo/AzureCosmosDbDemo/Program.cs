using AzureCosmosDbDemo;
using Microsoft.Azure.Cosmos;

// connection properties
string url = "https://fullstackbootcamp.documents.azure.com/";
string primaryKey = "ggin9VzmcjzctgLyh9NGAUKHuG4EGbZnSroyUeptddNkDygZKSGOMJ2FJJ2nRR0B4vyFC5tSoY7vACDbTIeIZg==";
string databaseName = "Jani_Testing";
string containerName = "customers";
string partitionKey = "/id";

// create the client
using CosmosClient client = new(url, primaryKey);

// create or open the database
var response = await client.CreateDatabaseIfNotExistsAsync(databaseName);
Console.WriteLine("Database created or opened.");
Database database = client.GetDatabase(databaseName);
Console.WriteLine($"Database name: {database.Id}");

// work with the container
Container container = await database.CreateContainerIfNotExistsAsync(containerName, partitionKey);
Console.WriteLine($"Opened container: {container.Id}");

// create data to store
CustomerData customer = new()
{
    id = "my-first-customer",
    CustomerName = "My First Customer Inc.",
    EmailAddress = "info@fistcustomer.com",
    PhoneNumber = "123 456 789"
};

// store the object in the Cosmos DB container
CustomerData createdItem = await container.CreateItemAsync(customer);
Console.WriteLine($"Created item: {createdItem.id}");
