﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MusicLover.WebApp.Server.Core.Contracts;
using MusicLover.WebApp.Server.Core.Models;

namespace MusicLover.WebApp.Server.Persistent.Repositories.Contracts
{
    public interface IGenreRepository: IDataRepository<Genre>
    {
        Task<IEnumerable<Genre>> GetAll();
    }
}