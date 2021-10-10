namespace App_ShopWithMe.Services
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using App_ShopWithMe.Models;
    public interface ICosmosDbService
    {
        Task<IEnumerable<Item>> GetItemsAsync(string query);
        Task<Item> GetItemAsync(string id , string name);
        Task AddItemAsync(Item item);
        Task UpdateItemAsync(string id,string name, Item item);
        Task DeleteItemAsync(string id , string name);
        
    }
}