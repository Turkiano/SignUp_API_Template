using Coffee_Shop_App.src.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.src.Repositories;

public class ReviewRepository : IReviewRepository
{

    private DbSet<Review> _reviews;

    public ReviewRepository(DbSet<Review> reviews)
    {
        _reviews = reviews;
    }

    public IEnumerable<Review> FindAll()
    {
        return _reviews;
    }

    public Review FindOne(string reviewId)
    {
        Review? review = _reviews.FirstOrDefault(review => review.Id ==reviewId);

        return review!;
    }
}