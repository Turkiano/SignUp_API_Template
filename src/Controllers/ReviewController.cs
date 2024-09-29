using Coffee_Shop_App.src.Abstractions;
using Coffee_Shop_App.src.DTOs;
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
    public ActionResult<ReviewReadDto> CreateOne([FromBody] ReviewCreateDto review)
    {
        if (review is not null)
        {
            var newReview = _reviewService.CreateOne(review);
            return CreatedAtAction(nameof(CreateOne), newReview);
        }
        return BadRequest();
    }


    [HttpGet("{reviewId}")]

    public ReviewReadDto FindOne(Guid reviewId)
    {
        return _reviewService.FindOne(reviewId);

    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public ActionResult<IEnumerable<ReviewReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
    {
        return Ok(_reviewService.FindAll(limit, offset));
    }

}