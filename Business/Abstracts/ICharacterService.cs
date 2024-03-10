using Business.Dtos.Character.Requests;
using Business.Dtos.Character.Responses;
using Core.DataAccess.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICharacterService
    {
        Task<Paginate<GetAllCharacterResponse>> GetAllAsync();
        Task<CreatedCharacterResponse> AddAsync(CreateCharacterRequest createCharacterRequest);
    }
}
