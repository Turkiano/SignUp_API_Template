using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.Databases;
using Coffee_Shop_App.src.Entities;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_App.src.Repositories;

public class ReviewRepository : IReviewRepository
{
    
    private DbSet<Review> _reviews;
    private DatabaseContext _dbContext;

    public ReviewRepository(DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    public Review CreateOne(Review review)
    {
        _dbContext.Add(review);
        _dbContext.SaveChanges();
        return review;
    }

    public IEnumerable<Review> FindAll(int limit, int offset)
    {
         if(limit == 0 && offset ==0){ // 1.if pagination has empty values
            return _dbContext.Reviews!; // 2.show all produts
        }
        // 3.else show the values of pagination
        return  _dbContext.Reviews!.Skip(offset).Take(limit);
    }

    public Review FindOne(Guid reviewId)
    {
        Review? review = _dbContext.Reviews.Find(reviewId);

        return review;
    }

    public Review UpdateOne(Review reivew)
    {
        _dbContext.Reviews.Update(reivew);
        _dbContext.SaveChanges();
        return reivew;
    }
}