

using Coffee_Shop_App.src.DTOs;

namespace Coffee_Shop_App.src.Abstractions;
public interface IReviewService
{

    public ReviewReadDto FindOne(Guid reviewId);
    public IEnumerable<ReviewReadDto> FindAll(int limit, int offset);
    public ReviewReadDto CreateOne(ReviewCreateDto review);





}