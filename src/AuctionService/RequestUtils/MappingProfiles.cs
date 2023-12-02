using AuctionService.DTO;
using AuctionService.Models;
using AutoMapper;

namespace AuctionService.RequestUtils;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Auction, AuctionDto>().IncludeMembers(x => x.Item);
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Auction>()
            .ForMember(dest => dest.Item, src => src.MapFrom(dto => dto));
        CreateMap<CreateAuctionDto, Item>();
    }
}
