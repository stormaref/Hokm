﻿using System;

namespace Hokm.Models
{
    public class BaseEntity : IEntity
    {
        public Guid Id { get; set; }
    }
}