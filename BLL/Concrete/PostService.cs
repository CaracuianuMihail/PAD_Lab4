using BLL.Abstract;
using DAL.Abstract;
using DataContract;
using Domain;

namespace BLL.Concrete
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;
        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public void CreatePost(PostDTO dto)
        {
            var post = new Post()
            {
                Author = dto.Author,
                Content = dto.Content.Replace("\n", "<br />"),
                Created = dto.Created,
                Id = dto.Id
            };

            _postRepository.CreatePost(post);
        }

        public IList<PostDTO> GetPosts()
        {
            var posts = _postRepository.GetPosts();
            var dtos = posts.Select(x => new PostDTO()
            {
                Author = x.Author,
                Content = x.Content,
                Created = x.Created,
                Id = x.Id
            }).ToList();
            return dtos;
        }
    }
}
