using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopWithMe.Models;
using Microsoft.Azure.Cosmos;

namespace ShopWithMe.Services
{
    public interface ICosmosDb_NewList_Service
    {
        Task<IEnumerable<NewList>> Get_NewLists_Async(string query);
        Task<NewList> Get_Newlist_Async(string id);
        Task Add_NewList_Async(NewList newlist);
        Task Update_NewList_Async(string id, NewList newlist);
        Task Delete_NewList_Async(string id);

    }

    public class CosmosDB_newlist : ICosmosDb_NewList_Service
    {

        private Container _container;

        public CosmosDB_newlist(CosmosClient dbClient,    string databaseName, string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task Add_NewList_Async(NewList newlist)
        {
            await this._container.CreateItemAsync<NewList>(newlist/*, new PartitionKey(newlist.Id)*/);
        }

        public async Task Delete_NewList_Async(string id)
        {
            await this._container.DeleteItemAsync<NewList>(id, new PartitionKey(id));
        }

        public async Task<NewList> Get_Newlist_Async(string id)
        {
            try
            {
                ItemResponse<NewList> response = await this._container.ReadItemAsync<NewList>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<NewList>> Get_NewLists_Async(string queryString)
        {
            var query = this._container.GetItemQueryIterator<NewList>(new QueryDefinition(queryString));
            List<NewList> results = new List<NewList>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }
            return results;
        }

        public async Task Update_NewList_Async(string id, NewList newlist)
        {
            await this._container.UpsertItemAsync<NewList>(newlist, new PartitionKey(id));
        }
    }
}
