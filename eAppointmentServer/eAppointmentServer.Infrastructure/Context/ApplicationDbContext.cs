﻿using eAppointmentServer.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eAppointmentServer.Infrastructure.Context
{
    internal sealed class ApplicationDbContext : IdentityDbContext<AppUser, AppUserRole, Guid>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) 
        { 
        }
    }
}
