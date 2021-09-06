using AdminPanel.Utils;
using Buisness.Abstract;
using DataAccess.Abstract;
using Entities.Models;
using Entity.Params;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
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
        private readonly IHostEnvironment _environment;
        private readonly IMovieDetailDal _movieDetailDal;

        public MovieManager(IMovieDal movieDal, IHostEnvironment environment, IMovieDetailDal movieDetailDal)
        {
            _movieDal = movieDal;
            _environment = environment;
            _movieDetailDal = movieDetailDal;
        }
        public async Task<Movie> GetMovieWithIdAsync(int id)
        {
            return await _movieDal.GetMovieWithIdAsync(id);
        }

        public async Task<bool> AddMovieAsync(MovieParams movieParams)
        {
            if (movieParams == null)
                return false;


            var newFileName = string.Empty;


            if (movieParams.Photo != null)
            {
                if (movieParams.Photo.Length > 0 &&
                    (movieParams.Photo.ContentType == "image/jpeg"
                      || movieParams.Photo.ContentType == "image/jpg"
                    || movieParams.Photo.ContentType == "image/png"
                    || movieParams.Photo.ContentType == "image/x-png"
                    || movieParams.Photo.ContentType == "image/pjpeg"))

                {

                    //Getting FileName
                    var fileName = Path.GetFileName(movieParams.Photo.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(movieParams.Photo.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat("movies/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}"; 

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        movieParams.Photo.CopyTo(fs);
                        fs.Flush();
                    }
                }
            }


            var folderList = new List<string>
                {
                    AdminPanel.Utils.Constants.MovieImageFolderPath,
                    @"D:\Programming\CodeAcademy\FrontEnd\FinalProject\limak-az--front-end\public\images"
                };




            movieParams.Image = newFileName;

            Movie movie = new Movie {

                Age = movieParams.Age,
                Name = movieParams.Name,
                Image = movieParams.Image,
                EndTime = movieParams.EndTime,
                StartTime = movieParams.StartTime,
                LanguageId = movieParams.LanguageId

            };
            var mov = await _movieDal.AddAsync(movie);
            if (mov == true)
            {
                MovieDetail movieDetail = new MovieDetail
                {

                    About = movieParams.About,
                    Actors = movieParams.Actors,
                    Country = movieParams.Country,
                    Duration = movieParams.Duration,
                    LanguageId = movieParams.LanguageId,
                    Director = movieParams.Director,
                    Treyler = movieParams.Treyler,
                    Genre = movieParams.Genre,
                    MovieId = movie.Id
                    

                };
                await _movieDetailDal.AddAsync(movieDetail);

            }
           

            return true;
        }
    

        public async Task<bool> DeleteMovieAsync(int? id)
            {
            var movie = await _movieDal.GetMovieWithIdAsync((int)id);
            var movieDetail = await _movieDetailDal.GetMovieDetailAsync((int)id);

            var isDeleted = _movieDetailDal.DeleteAsync(movieDetail);

            if (isDeleted.Result)
                 await _movieDal.DeleteAsync(movie); 

            return true;
            }

        public async Task<bool> UpdateMovieAsync(MovieParams movieParams, string oldPhoto)
        {

            var newFileName = string.Empty;

            if (movieParams.Photo != null)
            {
                if (movieParams.Photo.Length > 0 &&
                    (movieParams.Photo.ContentType == "image/jpeg"
                      || movieParams.Photo.ContentType == "image/jpg"
                    || movieParams.Photo.ContentType == "image/png"
                    || movieParams.Photo.ContentType == "image/x-png"
                    || movieParams.Photo.ContentType == "image/pjpeg"))

                {
                    if (oldPhoto != null)
                    {
                        var oldFilePath = Path.Combine(
         _environment.ContentRootPath, "wwwroot", "Uploads", "movies", oldPhoto);
                        if (System.IO.File.Exists(oldFilePath))
                            System.IO.File.Delete(oldFilePath);
                    }


                    //Getting FileName
                    var fileName = Path.GetFileName(movieParams.Photo.FileName);
                    var fileNameWithoutExt = Path.GetFileNameWithoutExtension(movieParams.Photo.FileName);

                    //Assigning Unique Filename (Guid)
                    var myUniqueFileName = Convert.ToString(Guid.NewGuid());

                    //Getting file Extension
                    var fileExtension = Path.GetExtension(fileName);

                    // concatenating  FileName + FileExtension
                    newFileName = String.Concat("movies/" + myUniqueFileName + "-" + fileNameWithoutExt, fileExtension);

                    // Combines two strings into a path.
                    var filepath =
            new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Uploads"))
            .Root + $@"\{newFileName}";

                    using (FileStream fs = System.IO.File.Create(filepath))
                    {
                        movieParams.Photo.CopyTo(fs);
                        fs.Flush();
                    }
                }
                movieParams.Image = newFileName;
            }
            else
                movieParams.Image = oldPhoto;

            Movie movie = new Movie
            {
                Id = movieParams.MovieId,
                Age = movieParams.Age,
                Name = movieParams.Name,
                Image = movieParams.Image,
                EndTime = movieParams.EndTime,
                StartTime = movieParams.StartTime,
                LanguageId = movieParams.LanguageId

            };
            var mov = await _movieDal.UpdateAsync(movie);
            if (mov == true)
            {
                MovieDetail movieDetail = new MovieDetail
                {
                    Id = movieParams.MovieDetailId,
                    About = movieParams.About,
                    Actors = movieParams.Actors,
                    Country = movieParams.Country,
                    Director = movieParams.Director,
                    LanguageId = movieParams.LanguageId,
                    Duration = movieParams.Duration,
                    Treyler = movieParams.Treyler,
                    Genre = movieParams.Genre,
                    MovieId = movie.Id,
                    

                };
                await _movieDetailDal.UpdateAsync(movieDetail);

            }
         
            return true;
        }
        

        public async Task<List<Movie>> GetAllMovieAsync()
        {
            return await _movieDal.GetAllAsync();
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
