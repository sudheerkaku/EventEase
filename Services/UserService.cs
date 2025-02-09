﻿using EventEase.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EventEase.Services
{
    public class UserService
    {
        private User currentUser;
        private readonly List<User> users = new List<User>();

        // This is a simple in-memory list. In a real app, you would use a database (like Entity Framework).
        public User RegisterUser(User user)
        {
            // Perform some basic validation for registration (e.g., check if the email is already registered).
            if (users.Any(u => u.Email.Equals(user.Email, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("User with this email already exists.");
            }

            // For simplicity, assigning a new user ID and storing the user.
            user.Id = users.Count + 1;  // In a real app, the ID is auto-generated by the database.
            users.Add(user);
            return user;
        }

        public User AuthenticateUser(string email, string password)
        {
            // Check if the user exists and if the password matches.
            var user = users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
            if (user == null || user.Password != password)
            {
                throw new InvalidOperationException("Invalid email or password.");
            }

            currentUser = user;
            return currentUser;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        // Method to get a user by ID (you may use it in your login or user management features)
        public User GetUserById(int userId)
        {
            return users.FirstOrDefault(u => u.Id == userId);
        }

        public void LogOut()
        {
            currentUser = null; // Clear the current user session
        }

        public User GetCurrentUser()
        {
            return currentUser;
        }

        public bool IsAuthenticated => currentUser != null;
    }
}
