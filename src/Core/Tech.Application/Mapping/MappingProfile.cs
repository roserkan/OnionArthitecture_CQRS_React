using AutoMapper;
using Tech.Application.Dtos;
using Tech.Domain.Models;

namespace Tech.Application.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile()
    {
        CreateMap<Address, AddressListDto>().ReverseMap();
        CreateMap<Address, AddressCreateDto>().ReverseMap();
        CreateMap<Address, AddressUpdateDto>().ReverseMap();


        CreateMap<Category, CategoryListDto>().ReverseMap();
        CreateMap<Category, CategoryCreateDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateDto>().ReverseMap();

        CreateMap<Comment, CommentListDto>().ReverseMap();
        CreateMap<Comment, CommentCreateDto>().ReverseMap();
        CreateMap<Comment, CommentUpdateDto>().ReverseMap();

        CreateMap<Order, OrderListDto>().ReverseMap();
        CreateMap<Order, OrderCreateDto>().ReverseMap();
        CreateMap<Order, OrderUpdateDto>().ReverseMap();

        CreateMap<Point, PointListDto>().ReverseMap();
        CreateMap<Point, PointCreateDto>().ReverseMap();
        CreateMap<Point, PointUpdateDto>().ReverseMap();

        CreateMap<Product, ProductListDto>().ReverseMap();
        CreateMap<Product, ProductCreateDto>().ReverseMap();
        CreateMap<Product, ProductUpdateDto>().ReverseMap();

        CreateMap<User, UserListDto>().ReverseMap();
        CreateMap<User, UserCreateDto>().ReverseMap();
        CreateMap<User, UserUpdateDto>().ReverseMap();
    }
}
