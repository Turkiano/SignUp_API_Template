using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Repositories;

namespace Coffee_Shop_App.src.Services;

public class ReviewService : IReviewService
{

    private ReviewRepository _ReviewRepository;

    public ReviewService(ReviewRepository reviewRepository)
    {
        _ReviewRepository = reviewRepository;
    }

    public IEnumerable<Review> FindAll()
    {
        return _ReviewRepository.FindAll();
    }

    public Review FindOne(string reviewId)
    {

        return _ReviewRepository.FindOne(reviewId);
    }
}
