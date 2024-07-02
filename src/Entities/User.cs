using System.ComponentModel.DataAnnotations;

using Coffee_Shop_App.src.Enums;

namespace Coffee_Shop_App.src.Entities;



// [Index(nameof(Email), IsUnique = true)]

public class User {

public Guid Id {get; set;}

[Required]
public string FirstName {get; set;}
[Required]
public string LastName {get; set;}

[Required]
public string phone {get; set;}

[Required]
public string Email{get; set;}

[Required]
public string password{get; set;}

private int _salt;

public int Salt{
    get { return _salt;}
    set { _salt = value;}
}

private Random _random = new Random(); //generate salt

public User(){
    _salt =_random.Next(10, 100);
}


public Role Role {get; set;} = Role.Customer; //to create role using enum class
// public IEnumerable<Order>? Order {get; set;}


}