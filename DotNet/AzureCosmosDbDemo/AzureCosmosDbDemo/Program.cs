using Microsoft.Azure.Cosmos;

// connection properties
string url = "https://fullstackbootcamp.documents.azure.com/";
string primaryKey = "ggin9VzmcjzctgLyh9NGAUKHuG4EGbZnSroyUeptddNkDygZKSGOMJ2FJJ2nRR0B4vyFC5tSoY7vACDbTIeIZg==";
string databaseName = "Jani_Testing";

// create the client
using CosmosClient client = new(url, primaryKey);

// create or open the database
var response = await client.CreateDatabaseIfNotExistsAsync(databaseName);
Console.WriteLine("Database created or opened.");
