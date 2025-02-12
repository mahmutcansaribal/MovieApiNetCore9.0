﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoveiApi.Application.Features.CQRSDesignPattern.Commands.CategoryCommands;
using MovieApi.Persistence.Context;

namespace MoveiApi.Application.Features.CQRSDesignPattern.Handlers.CategoryHandlers
{
    public class RemoveCategoryCommandHandler
    {
        private readonly MovieContext _context;

        public RemoveCategoryCommandHandler(MovieContext context)
        {
            _context = context;
        }
        public async void Handle(RemoveCategoryCommand command)
        {
            var value = await _context.Categories.FindAsync(command.CategoryID);
            _context.Categories.Remove(value);
            await _context.SaveChangesAsync();
        }
    }
}
