using AutoMapper;
using Business.Dtos.Character.Requests;
using Business.Dtos.Character.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles
{
    public class CharacterMapping : Profile
    {
        public CharacterMapping()
        {
            CreateMap<Character, CreateCharacterRequest>().ReverseMap();
            CreateMap<Character, CreatedCharacterResponse>().ReverseMap();

            CreateMap<Character, GetAllCharacterResponse>().ReverseMap();
            CreateMap<Paginate<Character>, Paginate<GetAllCharacterResponse>>().ReverseMap();
        }
    }
}
