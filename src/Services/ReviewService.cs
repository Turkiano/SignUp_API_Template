using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Repositories;

namespace Coffee_Shop_App.src.Services;

public class ReviewService : IReviewService
{

    private IReviewRepository _ReviewRepository;

    public ReviewService(IReviewRepository reviewRepository)
    {
        _ReviewRepository = reviewRepository;
    }

    public IEnumerable<Review> FindAll()
    {
        var reviews = _ReviewRepository.FindAll();
        return reviews.ToList();
    }

    public Review FindOne(string reviewId)
    {

        return _ReviewRepository.FindOne(reviewId);
    }
}
