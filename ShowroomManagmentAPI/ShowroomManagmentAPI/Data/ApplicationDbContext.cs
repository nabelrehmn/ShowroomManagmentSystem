﻿using Microsoft.EntityFrameworkCore;

namespace ShowroomManagmentAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option)
        {
            
        }

    }
}