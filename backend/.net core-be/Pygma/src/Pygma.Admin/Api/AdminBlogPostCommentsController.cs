namespace Pygma.Admin.Api
{
    // [Route("api/admin/blog-posts/{id:int:min(1)}/comments")]
    // public class AdminBlogPostCommentsController: AdminControllerBase
    // {
    //     private readonly IBlogPostCommentsRepository _blogPostCommentsRepository;
    //     private readonly IBlogPostsRepository _blogPostsRepository;
    //     private readonly Mapper _mapper;
    //
    //     public AdminBlogPostCommentsController(IBlogPostCommentsRepository blogPostCommentsRepository,
    //         IBlogPostsRepository blogPostsRepository,
    //         Mapper mapper)
    //     {
    //         _blogPostCommentsRepository = blogPostCommentsRepository;
    //         _blogPostsRepository = blogPostsRepository;
    //         _mapper = mapper;
    //     }
    //
    //     #region CRUD
    //     [HttpPost]
    //     public async Task<ActionResult> CreateBlogPostCommentAsync(int id,
    //         [FromBody] CreateBlogPostCommentVm createBlogPostCommentVm)
    //     {
    //         var blogPost = await _blogPostsRepository.ReadByIdAsync(id);
    //
    //         var blogPostComment = _mapper.Map<BlogPostComment>(createBlogPostCommentVm);
    //         blogPostComment.BlogPostId = blogPost.Id;
    //         
    //         await _blogPostCommentsRepository.CreateAsync(blogPostComment);
    //         
    //         return CreatedAtRoute(nameof(GetBlogPostCommentAsync),
    //             new {blogPostId = blogPost.Id, itemId = blogPostComment.Id}, null);
    //     }
    //     
    //     [HttpGet("{commentId:int:min(1)}", Name = nameof(GetBlogPostCommentAsync))]
    //     public async Task<ActionResult<BlogPostCommentVm>> GetBlogPostCommentAsync(int id, int commentId)
    //     {
    //         var blogPostComment = await _blogPostCommentsRepository.ReadByIdAndBlogPostIdAsync(commentId, id);
    //
    //         return blogPostComment == null 
    //             ? (ActionResult<BlogPostCommentVm>) NotFound($"Blog post comment {commentId} not found") 
    //             : _mapper.Map<BlogPostCommentVm>(blogPostComment);
    //     }
    //     
    //     [HttpPut("{commentId:int:min(1)}")]
    //     public async Task<ActionResult> UpdateBlogPostCommentAsync(int id, int commentId, UpdateBlogPostCommentVm updateBlogPostCommentVm)
    //     {
    //         var blogPostComment = await _blogPostCommentsRepository.ReadByIdAsync(commentId);
    //
    //         if (blogPostComment is null)
    //         {
    //             return NotFound();
    //         }
    //
    //         await _blogPostCommentsRepository.UpdateAsync(_mapper.Map(updateBlogPostCommentVm, blogPostComment));
    //
    //         return NoContent();
    //     }
    //     
    //     [HttpDelete("{commentId:int:min(1)}")]
    //     public async Task<ActionResult> DeleteBlogPostCommentAsync(int commentId)
    //     {
    //         var blogPostComment = await _blogPostCommentsRepository.ReadByIdAsync(commentId);
    //
    //         if (blogPostComment is null)
    //         {
    //             return NotFound();
    //         }
    //
    //         await _blogPostsRepository.DeleteAsync(commentId);
    //
    //         return NoContent();
    //     }
    //     #endregion
    // }
}