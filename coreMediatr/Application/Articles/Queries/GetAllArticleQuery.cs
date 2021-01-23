using System.Collections.Generic;
using coreMediatr.Models;
using MediatR;

namespace coreMediatr.Application.Articles.Queries
{
    public class GetAllArticleQuery : IRequest<List<Article>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}