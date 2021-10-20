using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopWithMe.Models;
using Microsoft.Azure.Cosmos;

namespace ShopWithMe.Services
{

    public interface ICosmosDb_Invoice_Service
    {
        Task<IEnumerable<Cart>> Get_Invoices_Async(string query);
        Task<Cart> Get_Invoice_Async(string id);
        Task Add_Invoice_Async(Cart newlist);
        Task Update_Invoice_Async(string id, Cart newlist);
        Task Delete_Invoice_Async(string id);

    }

    public class CosmosDB_Invoice : ICosmosDb_Invoice_Service
    {
        private Container _container;

        public CosmosDB_Invoice(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task Add_Invoice_Async(Cart cart)
        {
            await this._container.CreateItemAsync<Cart>(cart);
        }

        public async Task Delete_Invoice_Async(string id)
        {
            await this._container.DeleteItemAsync<Cart>(id, new PartitionKey(id));
        }

        public async Task<Cart> Get_Invoice_Async(string id)
        {
            try
            {
                ItemResponse<Cart> response = await this._container.ReadItemAsync<Cart>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<Cart>> Get_Invoices_Async(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Cart>(new QueryDefinition(queryString));
            List<Cart> results = new List<Cart>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task Update_Invoice_Async(string id, Cart cart)
        {
            await this._container.UpsertItemAsync<Cart>(cart, new PartitionKey(id));
        }
    }
}
