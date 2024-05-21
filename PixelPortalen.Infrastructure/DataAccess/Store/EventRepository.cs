using MongoDB.Driver;
using PixelPortalen.Domain.Entities;
using PixelPortalen.Infrastructure.DataAccess.Store.Documents;

namespace PixelPortalen.Infrastructure.DataAccess.Store;

public class EventRepository : IEventRepository
{
    private readonly IMongoCollection<EventDocument> _eventCollection;

    public EventRepository()
    {
        var hostName = "localhost";
        var port = "27017";
        var databaseName = "PixelPortalen";
        var client = new MongoClient("mongodb://cosmosdbpixelportalen:GCBndbCjN3WMkaj7bHlQ0tPvE4BF1Pq0eTJw2NV6JI4h7DhJeG0EkMOLj8NY46WPjOVqUvHhS9aJACDbAbPpnQ==@cosmosdbpixelportalen.mongo.cosmos.azure.com:10255/?ssl=true&retrywrites=false&replicaSet=globaldb&maxIdleTimeMS=120000&appName=@cosmosdbpixelportalen@");
        var database = client.GetDatabase(databaseName);
        _eventCollection = database.GetCollection<EventDocument>("EventCollection",
            new MongoCollectionSettings() { AssignIdOnInsert = true });
    }
    public async Task AddAsync(EventDocument entity)
    {
        await _eventCollection.InsertOneAsync(entity);
    }

    public async Task<IEnumerable<EventDocument>> GetAllAsync()
    {
        var events = await _eventCollection.Find(t => true).ToListAsync();
        return events;
    }
    public async Task UpdateAsync(EventDocument entity)
    {
        var filter = Builders<EventDocument>.Filter.Eq(s => s.Id, entity.Id);
        await _eventCollection.ReplaceOneAsync(filter, entity);
    }

    public async Task AddUserToEvent(EventDocument entity)
    {
        var filter = Builders<EventDocument>.Filter.Eq(s => s.Id, entity.Id);
        var update = Builders<EventDocument>.Update.Set(s => s.userIds, entity.userIds);
        await _eventCollection.UpdateOneAsync(filter, update);
    }
    public async Task<EventDocument> GetByIdAsync(string id)
    {
        var eventDocument = await _eventCollection.Find(t => t.Id == id).FirstOrDefaultAsync();
        return eventDocument;
    }

    public async Task<IEnumerable<EventDocument>> GetByUserIdAsync(string userId)
    {
        var events = await _eventCollection.Find(t => t.userIds.Contains(userId)).ToListAsync();
        return events;
    }
    public async Task DeleteAsync(string id)
    {
        var filter = Builders<EventDocument>.Filter.Eq(s => s.Id, id);
        await _eventCollection.DeleteOneAsync(filter);
    }
}