using coreMediatr.Models;
using MediatR;

namespace coreMediatr.Application.Articles.Queries
{
    public class DeleteArticleQuery : IRequest<Article>
    {
        public int Id { get; set; }   
    }
}