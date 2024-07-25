using System.ComponentModel.DataAnnotations;
namespace Coffee_Shop_App.src.Entities;

// [Index(nameof(Email), IsUnique = true)]

public class User
{
    [Required]
    public string Id { get; set; }

    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    [Required]
    public string Phone { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Password { get; set; }




    //this is the constructor
    public User(string id, string firstName, string lastName, string phone, string email, string password)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
        Email = email;
        Password = password;
    }




}