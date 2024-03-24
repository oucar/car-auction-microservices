using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        // Mapping from Auction to AuctionDto
        CreateMap<Auction, AuctionDto>()
            .IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();

        // Mapping from CreateAuctionDto to Auction and Item
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(d => d.Item, o => o.MapFrom(s => s));
        CreateMap<CreateAuctionDto, Item>();
    }
}
