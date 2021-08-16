﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Buisness.Abstract
{
    public interface IMovieService
    {
        Task<Movie> GetMovieWithIdAsync(int id);
        Task<List<Movie>> GetAllMovieAsync();
        Task<List<Movie>> GetAllMovieAsync(string languageCode);

        Task<bool> AddMovieAsync(Movie movie);
        Task<bool> UpdateMovieAsync(Movie movie);
        Task<bool> DeleteMovieAsync(int id);
    }
}