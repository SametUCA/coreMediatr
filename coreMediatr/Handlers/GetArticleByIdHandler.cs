using System.Threading;
using System.Threading.Tasks;
using coreMediatr.Application.Articles.Queries;
using coreMediatr.Models;
using coreMediatr.Persistance;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace coreMediatr.Handlers
{
    public class GetArticleHandler : IRequestHandler<GetArticleByIdQuery,Article>
    {
        private readonly IArticle _article;

        public GetArticleHandler(IArticle article)
        {
            _article = article;
        }
        
        public async Task<Article> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            var article = _article.GetArticleById(request);
            return article;
        }
    }
}