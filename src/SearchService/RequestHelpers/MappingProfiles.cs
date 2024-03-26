using AutoMapper;
using Contracts;

namespace SearchService;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Map the properties of the AuctionCreated and AuctionUpdated messages to the Item entity
        // Item entity: MongoDB.Entities.Item
        // Maapping consumers to MongoDB entities
        CreateMap<AuctionCreated, Item>();
        CreateMap<AuctionUpdated, Item>();
    }
}