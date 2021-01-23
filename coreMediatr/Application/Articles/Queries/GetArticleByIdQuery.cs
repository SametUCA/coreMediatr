using System.Collections.Generic;
using coreMediatr.Models;
using coreMediatr.Persistance;
using MediatR;

namespace coreMediatr.Application.Articles.Queries
{
    public class GetArticleByIdQuery : IRequest<Article>
    {
        public int Id { get; set; }
        
    }
}