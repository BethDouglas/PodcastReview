using System;
using System.Collections.Generic;
using PodcastReview.Contracts;
using PodcastReview.Models;

namespace PodcastReview.Web.Tests.Controllers.ReviewControllerTests
{
    public class FakeReviewService : IReviewService
    {
        public int CreateReviewCallCount { get; private set; }
        public bool CreateReviewReturnValue { private get; set; } = true;

        public bool CreateReview(ReviewCreate model)
        {
            CreateReviewCallCount++;


            return CreateReviewReturnValue;
        }

        public bool DeleteReview(int reviewId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewListAllItem> GetAllReviews()
        {
            throw new NotImplementedException();
        }

        public ReviewDetail GetReviewById(int reviewId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ReviewListItem> GetReviews()
        {
            throw new NotImplementedException();
        }

        public bool UpdateReview(ReviewEdit model)
        {
            throw new NotImplementedException();
        }
    }
}