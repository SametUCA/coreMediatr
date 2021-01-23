using coreMediatr.Models;
using MediatR;

namespace coreMediatr.Application.Articles.Queries
{
    public class CreateArticleQuery : IRequest<Article>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}