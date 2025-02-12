using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveiApi.Application.Features.CQRSDesignPattern.Commands.MovieCommands;
using MovieApi.Persistence.Context;

namespace MoveiApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async void Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieID);
            
            value.MovieRate = command.MovieRate;
            value.MovieStatus = command.MovieStatus;
            value.MovieDuration = command.MovieDuration;
            value.MovieCoverImageUrl = command.MovieCoverImageUrl;
            value.MovieCreatedYear = command.MovieCreatedYear;
            value.MovieDescription = command.MovieDescription;
            value.MovieReleaseDate = command.MovieReleaseDate;
            value.MovieTitle = command.MovieTitle;

            await _context.SaveChangesAsync();
        }
    }
}
