using coreMediatr.Models;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace coreMediatr.Application.Articles.Queries
{
    public class CreateArticleQuery : IRequest<Article>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}