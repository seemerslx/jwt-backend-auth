﻿namespace JwtRefresh.Models.AuthModels
{
    public class UserRole
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public User User { get; set; } = null!;

        public Guid RoleId { get; set; }

        public Role Role { get; set; } = null!;
    }
}
