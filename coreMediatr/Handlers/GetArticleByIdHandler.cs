using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using coreMediatr.Models;
using coreMediatr.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace coreMediatr.Application.Articles.Queries
{
    public class GetArticleHandler : IRequestHandler<GetArticleByIdQuery,Article>
    {
        private readonly MediatRContext _context;

        public GetArticleHandler(MediatRContext context)
        {
            _context = context;
        }
        
        public Task<Article> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            var article = _context.Articles.FirstOrDefaultAsync(x => x.Id == request.Id);
            return article;
        }
    }
}