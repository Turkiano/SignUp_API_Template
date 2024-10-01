using Coffee_Shop_App.src.Entities;

namespace Coffee_Shop_App.src.Abstractions;

public interface IReviewRepository
{


    public Review FindOne(Guid reviewId);
    public IEnumerable<Review> FindAll(int limit, int offset);

    public Review CreateOne(Review review);

    public Review UpdateOne(Review reivew);




}