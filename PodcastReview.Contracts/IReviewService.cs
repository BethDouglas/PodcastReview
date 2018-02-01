using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PodcastReview.Models;

namespace PodcastReview.Contracts
{
    public interface IReviewService
    {
        bool CreateReview(ReviewCreate model);
        IEnumerable<ReviewListItem> GetReviews();
        IEnumerable<ReviewListAllItem> GetAllReviews();
        ReviewDetail GetReviewById(int reviewId);
        bool UpdateReview(ReviewEdit model);
        bool DeleteReview(int reviewId);
    }
}
