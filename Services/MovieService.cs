using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using movie_rating_backend.Models;
using System.Threading.Tasks;

namespace movie_rating_backend.Services
{
    public class MovieService : IMovieService
    {
        private readonly DbContext _context;

        public MovieService(DbContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<Movie>> GetMovieById(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFound();
            }
            return movie;
        }

        public async Task<ActionResult<Movie>> CreateMovie(Movie movie)
        {
            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<ActionResult<Movie>> UpdateMovie(Movie movie)
        {
            _context.Entry(movie).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return movie;
        }

        public async Task<ActionResult<Movie>> DeleteMovie(int id)
        {
            var movie = await _context.Movies.FindAsync(id);
            if (movie == null)
            {
                return NotFoundResult();
            }

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();
            return movie;
        }

        // Implement other methods defined in IMovieService
    }
}
