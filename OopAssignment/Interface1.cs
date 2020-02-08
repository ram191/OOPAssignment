using System;
using System.Collections.Generic;
using System.Text;

namespace OopAssignment
{
    public interface IErrorLog
    {
        DateTime Date { get; set; }
        string Message { get; set; }
    }
    public interface IItems
    {
        int Item_id { get; set; }
        int Price { get; set; }
        int Quantity { get; set; }
    }
    public interface IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
