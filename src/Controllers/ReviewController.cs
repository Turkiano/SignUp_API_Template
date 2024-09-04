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


    [HttpPost] //POST, PUT, or PATCH use fromBody
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public ActionResult<Review> CreateOne([FromBody] Review review)
    {
        if (review is not null)
        {
            var newReview = _reviewService.CreateOne(review);
            return CreatedAtAction(nameof(CreateOne), newReview);
        }
        return BadRequest();
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