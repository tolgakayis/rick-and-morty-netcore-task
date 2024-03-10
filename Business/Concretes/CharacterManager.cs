using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Character.Requests;
using Business.Dtos.Character.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CharacterManager : ICharacterService
    {
        private ICharacterDal _characterDal;
        private IMapper _mapper;
        public CharacterManager(ICharacterDal characterDal, IMapper mapper)
        {
            _characterDal = characterDal;
            _mapper = mapper;
        }

        public async Task<CreatedCharacterResponse> AddAsync(CreateCharacterRequest createCharacterRequest)
        {
            Character character = _mapper.Map<Character>(createCharacterRequest);
            
            Character createdCharacter = await _characterDal.AddAsync(character);

            return _mapper.Map<CreatedCharacterResponse>(createdCharacter);
        }

        public async Task<Paginate<GetAllCharacterResponse>> GetAllAsync()
        {
            var data = await _characterDal.GetListAsync();
            return _mapper.Map<Paginate<GetAllCharacterResponse>>(data);
        }
    }
}
