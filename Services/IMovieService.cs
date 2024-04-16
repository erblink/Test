using movie_rating_backend.Models;
using System.Threading.Tasks;

namespace movie_rating_backend.Services
{
    public interface IMovieService
    {
        

    
        public interface IUserService
        {
            Task<User> GetMovieById(int id);
            Task AddMovie(Movie movie);
            Task UpdateMovie(Movie user);
            Task DeleteMovie(String title);
        
        }
    }

}

