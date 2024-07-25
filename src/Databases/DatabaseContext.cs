


using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Databases;


public class DatabaseContext {

public List<User> users; // to stroe User data as a list

    public DatabaseContext() // constructor to add users values
    {
        users = [ 
            new User ("01", "Khalid", "Hassan", "0594930211", "K.Hassan@gmail.com", "1234456"),
            new User ("02", "John", "Guns", "056939830122", "J.Guns@gmail.com", "3452345"),
            new User ("03", "Sumaiyah", "Abduallah", "0594930211", "S.A@gmail.com", "463456")
        ];
    }
}
