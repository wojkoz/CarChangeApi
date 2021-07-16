using CarChangeApi.Domain.Dtos;
using CarChangeApi.Domain.Models;
using Mapster;
using System;
using System.Linq.Expressions;

namespace CarChangeApi.Domain.Mapster.Mappers
{

    [Mapper]
    public interface IUserMapper
    {
        //for queryable
        Expression<Func<User, UserDto>> ProjectToDto { get; }

        //map from POCO to DTO
        UserDto MapToDto(User user);

        //map to existing object
        User MapToExisting(UserDto dto, User user);
    }

}
