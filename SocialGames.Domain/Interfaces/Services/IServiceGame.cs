﻿using SocialGames.Domain.Arguments.Game;
using System;
using System.Collections.Generic;

namespace SocialGames.Domain.Interfaces.Services
{
    public interface IServiceGame
    {
        GameResponse Create(CreateGameRequest request);
        IEnumerable<GameResponse> GetAll();
        GameResponse GetById(Guid id);
        IEnumerable<GameResponse> GetByPlatformId(Guid platformId);
        GameResponse Update(Guid id,UpdateGameRequest request);
        void Delete(Guid id);
    }
}
