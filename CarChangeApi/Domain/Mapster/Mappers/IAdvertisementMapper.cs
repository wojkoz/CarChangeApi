using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Models;
using Mapster;
using System;
using System.Linq.Expressions;

namespace CarChangeApi.Domain.Mapster.Mappers
{
    [Mapper]
    public interface IAdvertisementMapper
    {
        //for queryable
        Expression<Func<Advertisement, AdvertisementDto>> ProjectToDto { get; }

        //map from POCO to DTO
        AdvertisementDto MapToDto(Advertisement advertisement);

        //map to existing object
        Advertisement MapToExisting(AdvertisementDto dto, Advertisement advertisement);
    }
}
