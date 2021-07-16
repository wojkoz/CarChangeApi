using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Models;
using Mapster;
using System;
using System.Linq.Expressions;

namespace CarChangeApi.Domain.Mapster.Mappers
{

    [Mapper]
    public interface ICarMapper
    {
        //for queryable
        Expression<Func<Car, CarDto>> ProjectToDto { get; }

        //map from POCO to DTO
        CarDto MapToDto(Car car);

        //map to existing object
        Car MapToExisting(CarDto dto, Car car);
    }
}
