using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;
using Telamoveis.Models;

namespace Telamoveis.DataAccess
{
    public interface IGuestData
    {
        [Get("/Guests")]
        Task<List<GuestModel>> GetGuests();

        [Get("/Guests/{id}")]
        Task<List<GuestModel>> GetGuests(int id);

        [Post("/Guests")]
        Task CreateGuest([Body]GuestModel guest);

        [Put("/Guests/{id}")]
        Task UpdateGuest([Body]GuestModel guest);

        [Delete("/Guests/{id}")]
        Task DeleteGuest(int id);

    }
}
