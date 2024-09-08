namespace Coffee_Shop_App.src.Abstractions;

public interface IReviewRepository
{


    public Review FindOne(Guid reviewId);
    public IEnumerable<Review> FindAll();

        public Review CreateOne(Review review);



}