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
    public ActionResult CreateOne([FromBody] ReviewCreateDto review)
    {
        if (review is not null)
        {
            var newReview = _reviewService!.CreateOne(review);
            return CreatedAtAction(nameof(CreateOne), newReview);
        }
        return BadRequest();
    }


    [HttpGet("{reviewId}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ReviewReadDto> FindOne(Guid reviewId)
    {
        ReviewReadDto review = _reviewService.FindOne(reviewId);
        if(review is null) return NotFound();
        return Ok(review);

    }
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]

    public ActionResult<IEnumerable<ReviewReadDto>> FindAll([FromQuery(Name = "limit")] int limit, [FromQuery(Name = "offset")] int offset)
    {
        return Ok(_reviewService.FindAll(limit, offset));
    }


    [HttpPatch(":reviewId")] // (POST, PUT, or PATCH) use fromBody
    [ProducesResponseType(StatusCodes.Status202Accepted)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<ReviewReadDto> UpdateOne(Guid reviewId, [FromBody] ReviewCreateDto updatedReview)
    {
        ReviewReadDto review = _reviewService.UpdateOne(reviewId, updatedReview);
        if (review is null) return NotFound();

        return Accepted(review);
    }
}   