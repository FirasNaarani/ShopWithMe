﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_ShopWithMe.Models;
using Microsoft.Azure.Cosmos;
using Microsoft.Azure.Cosmos.Fluent;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc;

namespace App_ShopWithMe.Services
{
    public class CosmosDbService : ICosmosDbService
    {
        private Container _container;

        public CosmosDbService(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }
        public async Task AddItemAsync(Item item)
        {
            await this._container.CreateItemAsync<Item>(item/*, new PartitionKey(item.Type)*/);
        }

        public async Task DeleteItemAsync(string id,string name )
        {
            await this._container.DeleteItemAsync<Item>(id, new PartitionKey(name));
        }


        public async Task<Item> GetItemAsync(string id,string name)
        {
            try
            {
                ItemResponse<Item> response = await this._container.ReadItemAsync<Item>(id, new PartitionKey(name));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }

        }

        public async Task<IEnumerable<Item>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Item>(new QueryDefinition(queryString));
            List<Item> results = new List<Item>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }

        public async Task UpdateItemAsync(string id,string name, Item item)
        {
            await this._container.UpsertItemAsync<Item>(item, new PartitionKey(name));
        }
    }
}
