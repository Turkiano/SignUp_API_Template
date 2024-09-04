

namespace Coffee_Shop_App.src.Abstractions;
public interface IReviewService
{

    public Review FindOne(string reviewId);
    public IEnumerable<Review> FindAll();
    public Review CreateOne(Review review);





}