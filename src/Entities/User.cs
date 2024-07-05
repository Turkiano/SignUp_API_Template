using System.ComponentModel.DataAnnotations;
using Coffee_Shop_App.src.Enums;
namespace Coffee_Shop_App.src.Entities;
// [Index(nameof(Email), IsUnique = true)]

public class User {

public string Id {get; set;}

[Required]
public string FirstName {get; set;}
[Required]
public string LastName {get; set;}

[Required]
public string Phone {get; set;}

[Required]
public string Email{get; set;}

[Required]
public string Password{get; set;}

private int _salt;

public int Salt{ // getter & setter propertiy
    get { return _salt;}
    set { _salt = value;}
}

private Random _random = new Random(); //this object to generate salt

public User(){ //this is the salt method
    _salt =_random.Next(10, 100);
}
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

    public Role Role {get; set;} = Role.Customer; //to create role using enum class
// public IEnumerable<Order>? Order {get; set;}


}