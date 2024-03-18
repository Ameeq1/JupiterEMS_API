using AutoMapper;
using Jupiter.Business.Models;
using Jupiter.Data.DataAccess.Entity;
using JupiterWeb.Application.Features.Branchs.Commands.CreateBranch;
using JupiterWeb.Application.Features.Branchs.Commands.DeleteBranchById;
using JupiterWeb.Application.Features.Branchs.Commands.UpdateBranch;
using JupiterWeb.Application.Models.Authentication;
using JupiterWeb.Application.Models.Login;
using JupiterWeb.Domain.Entities;
using JupiterWeb.Domain.ViewModel;

namespace JupiterWeb.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //User Mapping
            CreateMap<User, UserDetailViewModel>();
            CreateMap<User, UserViewModel>();
            //CreateMap<User, CreateUserCommand>();
            //CreateMap<CreateUserCommand, User>();
            //CreateMap<User, UpdateUserCommand>();
            //CreateMap<UpdateUserCommand, User>();
            //CreateMap<User, DeleteUserByIdCommand>();
            CreateMap<AuthenticationResponse, AuthenticateUserResponse>();
            CreateMap<UserDetailViewModel, AuthenticateUserResponse>();

            //Branch Mapping
            CreateMap<Branch, BranchDetailViewModel>();
            CreateMap<Branch, BranchViewModel>();
            CreateMap<Branch, CreateBranchCommand>();
            CreateMap<CreateBranchCommand, Branch>();
            CreateMap<Branch, UpdateBranchCommand>();
            CreateMap<UpdateBranchCommand, Branch>();
            CreateMap<Branch, DeleteBranchByIdCommand>();


          
        }
    }
}
