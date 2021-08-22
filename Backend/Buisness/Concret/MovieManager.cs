using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Concret
{
    public class MovieManager : IMovieService
    {
        private readonly IMovieDal _movieDal;
        private IHostEnvironment _environment;

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        public async Task<Movie> GetMovieWithIdAsync(int id)
        {
            return await _movieDal.GetAsync(x => x.Id == id);
        }

        public async Task<List<Movie>> GetAllMovieAsync()
        {
            return await _movieDal.GetAllAsync();
        }

        public async Task<bool> AddMovieAsync(Movie movie)
        {
            if (movie == null)
                return false;
                

            var newFileName = string.Empty;

            if (movie.Photo != null)
            {
                if (movie.Photo.Length > 0 &&
                    (movie.Photo.ContentType == "image/jpeg"
                      || movie.Photo.ContentType == "image/jpg"
                    || movie.Photo.ContentType == "image/png"
                    || movie.Photo.ContentType == "image/x-png"
                    || movie.Photo.ContentType == "image/pjpeg"))

                {

                    //Getting FileName
                    var fileName = Path.GetFileName(movie.Photo.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(movie.Photo.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat("movies/"+myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        movie.Photo.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }

            movie.Image = newFileName;

          await  _movieDal.AddAsync(movie);
            return true;

        }

        public async Task<bool> DeleteMovieAsync(Movie movie)
        {
            return await _movieDal.DeleteAsync(movie);

        }

        public async Task<bool> UpdateMovieAsync(Movie movie, string oldPhoto)
        {

            var newFileName = string.Empty;

            if (movie.Photo != null)
            {
                if (movie.Photo.Length > 0 &&
                    (movie.Photo.ContentType == "image/jpeg"
                      || movie.Photo.ContentType == "image/jpg"
                    || movie.Photo.ContentType == "image/png"
                    || movie.Photo.ContentType == "image/x-png"
                    || movie.Photo.ContentType == "image/pjpeg"))

                {
                    if(oldPhoto!= null)
                    {
                        var oldFilePath = Path.Combine(
         _environment.ContentRootPath, "wwwroot", "Uploads", "movies", oldPhoto);
                        if (System.IO.File.Exists(oldFilePath))
                            System.IO.File.Delete(oldFilePath);
                    }
                   

                    //Getting FileName
                    var fileName = Path.GetFileName(movie.Photo.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(movie.Photo.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat("movies/"+myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        movie.Photo.CopyTo(fs);
                        fs.Flush();
                    }
                }
                movie.Image = newFileName;

                await _movieDal.UpdateAsync(movie);
                return true;
            }
            return false;
        }

        public async Task<List<Movie>> GetAllMovieAsync(string languageCode)
        {
            return await _movieDal.GetMovieAsync(languageCode);

        }
        public async Task<bool> MovieAnyAsync(Expression<Func<Movie, bool>> expression)
        {
            return await _movieDal.CheckMovie(expression);
        }

        public async Task<MovieDetail> GetMovieDetail(int? movieId)
        {
            return await _movieDal.GetMovieDetail(movieId);
        }
     
    }
}
