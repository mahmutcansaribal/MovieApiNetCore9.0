using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveiApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;

namespace MoveiApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _contex;

        public CreateMovieCommandHandler(MovieContext contex)
        {
            _contex = contex;
        }

        public async void Handle(CreateMovieCommand command)
        {
            _contex.Movies.Add(new Movie
            {
                MovieCoverImageUrl = command.MovieCoverImageUrl,
                MovieCreatedYear = command.MovieCreatedYear,
                MovieDescription = command.MovieDescription,
                MovieTitle = command.MovieTitle,
                MovieDuration = command.MovieDuration,
                MovieRate = command.MovieRate,
                MovieReleaseDate = command.MovieReleaseDate,
                MovieStatus = command.MovieStatus
            });
            await _contex.SaveChangesAsync();
        }
    }
}
