using Microsoft.Azure.Cosmos;
using ShopWithMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopWithMe.Services
{
    public interface ICosmosDb_shoppingOL_Service
    {
        Task<IEnumerable<shoppingOL>> Get_shoppingOLes_Async(string query);
        Task<shoppingOL> Get_shoppingOL_Async(string id);
        Task Add_shoppingOL_Async(shoppingOL shoppingOL);
        Task Update_shoppingOL_Async(string id, shoppingOL shoppingOL);
        Task Delete_shoppingOL_Async(string id);

    }

    public class CosmosDB_shoppingOL : ICosmosDb_shoppingOL_Service
    {
        private Container _container;

        public CosmosDB_shoppingOL(CosmosClient dbClient, string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task Add_shoppingOL_Async(shoppingOL shoppingOL)
        {
            await this._container.CreateItemAsync<shoppingOL>(shoppingOL);
        }

        public async Task Delete_shoppingOL_Async(string id)
        {
            await this._container.DeleteItemAsync<shoppingOL>(id, new PartitionKey(id));
        }

        public async Task<shoppingOL> Get_shoppingOL_Async(string id)
        {
            try
            {
                ItemResponse<shoppingOL> response = await this._container.ReadItemAsync<shoppingOL>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<shoppingOL>> Get_shoppingOLes_Async(string queryString)
        {
            var query = this._container.GetItemQueryIterator<shoppingOL>(new QueryDefinition(queryString));
            List<shoppingOL> results = new List<shoppingOL>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task Update_shoppingOL_Async(string id, shoppingOL shoppingOL)
        {
            await this._container.UpsertItemAsync<shoppingOL>(shoppingOL, new PartitionKey(id));
        }
    }


}

