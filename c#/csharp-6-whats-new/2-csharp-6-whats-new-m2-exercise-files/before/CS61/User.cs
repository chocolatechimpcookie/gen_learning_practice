using System;

namespace CS61
{
    public class User
    {
        public User(string username)
        {
            Id = Guid.NewGuid();
            Username = username;
        }

       public Guid Id { get; private set; }
       public string Username { get; protected set; }
    }
}
