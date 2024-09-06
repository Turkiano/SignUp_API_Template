using AutoMapper;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Repositories;

namespace Coffee_Shop_App.src.Services;

public class ReviewService : IReviewService
{

    private IMapper _mapper;
    private IReviewRepository _ReviewRepository;

    public ReviewService(IReviewRepository reviewRepository,  IMapper mapper)
    {
        _ReviewRepository = reviewRepository;
        _mapper = mapper;
    }

    public Review CreateOne(Review review)
    {
        Review foundReview = _ReviewRepository.FindOne(review.Id);
        if (foundReview is not null)
        {
            return null;
        }
        return _ReviewRepository.CreateOne(review);

    }

    public IEnumerable<Review> FindAll()
    {
        var reviews = _ReviewRepository.FindAll();
        return reviews.ToList();
    }

    public ReviewReadDto FindOne(string reviewId)
    {
        Review review = _ReviewRepository.FindOne(reviewId);
        ReviewReadDto reviewRead = _mapper.Map<ReviewReadDto>(review);

        return reviewRead;
    }
}
