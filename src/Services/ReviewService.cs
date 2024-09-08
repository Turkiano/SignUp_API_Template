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

    public ReviewReadDto CreateOne(ReviewCreateDto review)
    {
        Review foundReview = _ReviewRepository.FindOne((Guid)review.Id);
        if (foundReview is not null)
        {
            return null;
        }
        Review mapperReview = _mapper.Map<Review>(review);
        Review newReview = _ReviewRepository.CreateOne(mapperReview);
        ReviewReadDto reviewRead = _mapper.Map<ReviewReadDto>(newReview);
        return reviewRead;

    }

    public IEnumerable<ReviewReadDto> FindAll()
    {
        var review = _ReviewRepository.FindAll();
        var reviewRead = review.Select(_mapper.Map<ReviewReadDto>);
        return reviewRead;
    }

    public ReviewReadDto FindOne(Guid reviewId)
    {
        Review review = _ReviewRepository.FindOne(reviewId);
        ReviewReadDto reviewRead = _mapper.Map<ReviewReadDto>(review);

        return reviewRead;
    }
}
