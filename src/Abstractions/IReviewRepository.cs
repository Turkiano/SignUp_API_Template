namespace Coffee_Shop_App.src.Abstractions;

public interface IReviewRepository
{


    public Review FindOne(string reviewId);
    public IEnumerable<Review> FindAll();


}