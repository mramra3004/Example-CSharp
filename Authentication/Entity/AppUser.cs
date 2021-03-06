﻿using Authentication.Entity.Interface;
using Authentication.Utils.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Authentication.Entity
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, IHasSoftDelete
    {
        public string FullName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Blance { get; set; }
        public string Avatar { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDelete { get; set; }
    }
}