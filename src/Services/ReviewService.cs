using AutoMapper;
using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.DTOs;
using Coffee_Shop_App.src.Entities;
using Coffee_Shop_App.src.Repositories;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Coffee_Shop_App.src.Services;

public class ReviewService : IReviewService
{

    private IMapper _mapper;
    private IReviewRepository _ReviewRepository;

    public ReviewService(IReviewRepository reviewRepository, IMapper mapper)
    {
        _ReviewRepository = reviewRepository;
        _mapper = mapper;
    }

    public ReviewReadDto CreateOne(ReviewCreateDto review)
    {
        Review foundReview = _ReviewRepository.FindOne(review.reviewId);
        if (foundReview is not null)
        {
            return null;
        }
        Review mappedRReview = _mapper.Map<Review>(review);
        Review newReview = _ReviewRepository.CreateOne(mappedRReview);
        ReviewReadDto readReview = _mapper.Map<ReviewReadDto>(newReview);
        return readReview;
    }

    public IEnumerable<ReviewReadDto> FindAll(int limit, int offset)
    {
        IEnumerable<Review> reviews = _ReviewRepository.FindAll(limit, offset);

        var reviewRead = reviews.Select(_mapper.Map<ReviewReadDto>);
        return reviewRead;
    }

    public ReviewReadDto FindOne(Guid reviewId)
    {
        Review review = _ReviewRepository.FindOne(reviewId);
        ReviewReadDto reviewRead = _mapper.Map<ReviewReadDto>(review);

        return reviewRead;
    }

    public ReviewReadDto UpdateOne(Guid reviewId, ReviewUpdateDto updatedReview)
    {
        Review review = _ReviewRepository.FindOne(reviewId);
        if (review is null) return null;

        review.comment = updatedReview.comment;
        review.rating = updatedReview.rating;

        _ReviewRepository.UpdateOne(review);
        return _mapper.Map<ReviewReadDto>(review);
    }
}
