

using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App;

    public class Review
    {


        public string? Id {get; set;} 
        public string? UserId {get; set;}
        public string? Rating {get; set;}
        public string? Comment {get; set;}
        public string? ReviewDate {get; set;}


        public User? User {get; set;}
        public Product? Product {get; set;}


        
        
    }
