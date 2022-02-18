﻿using SocialGames.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace SocialGames.Domain.Entities
{
    public class Comment : EntityBase
    {
        public DateTime DateTime { get; private set; }
        public string Description { get; private set; }
        public Guid MyGameId { get; private set; }
        public MyGame MyGame { get; private set; }
        protected Comment()
        {
        }
        public Comment(string description)
        {
            DateTime = DateTime.Now;
            Description = description;
        }
        public void Update(string description)
        {
            if (description == null || description.Length == 0) throw new ValidationException("Description cannot be empty");
            Description = description;

        }
    }
}
