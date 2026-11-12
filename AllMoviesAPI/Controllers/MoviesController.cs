using AllMoviesAPI.DTOs;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace AllMoviesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IDbConnection _db;
        //Constructor
        public MoviesController(IDbConnection db)
        {
            _db = db;

        }


        // GET api/allmovies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetAllMovies()
        {
            var sql = "SELECT * FROM Movie";

            var movies = await _db.QueryAsync<Movie>(sql);

            return Ok(movies);
        }   

    }
}
