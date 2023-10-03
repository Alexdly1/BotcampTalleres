﻿using System;

namespace Jazani.Application.Admins.Dtos.Activities
{
    public class ActivityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }
    }
}
