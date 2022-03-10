﻿using Core.Entities;

namespace Entities.DTOs
{
    //kayıt olmak için istenenler
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}