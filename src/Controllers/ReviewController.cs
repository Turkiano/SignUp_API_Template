using Coffee_Shop_App.src.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_App.src.Controllers;





public class ReviewController : BaseController
{
    private IReviewService _reviewService;

    public ReviewController(IReviewService reviewService)
    {
        _reviewService = reviewService;
    }




    [HttpGet("{reviewId}")]

    public Review FindOne(string reviewId)
    {
        return _reviewService.FindOne(reviewId);

    }
    [HttpGet]

    public IEnumerable<Review> FindAll()
    {
        return _reviewService.FindAll();
    }


}