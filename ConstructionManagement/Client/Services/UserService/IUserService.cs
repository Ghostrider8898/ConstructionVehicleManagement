﻿namespace ConstructionManagement.Client.Services.UserService
{
    public interface IUserService
    {
        List<User> Users { get; set; }
        Task GetUsers();
    }
}
