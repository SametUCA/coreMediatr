using System;
using System.Threading;
using System.Threading.Tasks;
using coreMediatr.Application.Articles.Queries;
using coreMediatr.Models;
using MediatR;

namespace coreMediatr.Handlers
{
    
    public class GetDeleteArticleHandler : IRequestHandler<DeleteArticleQuery,Article>
    {
        private IArticle _article;

        public GetDeleteArticleHandler(IArticle article)
        {
            _article = article;
        }

        public async Task<Article> Handle(DeleteArticleQuery request, CancellationToken cancellationToken)
        {
            return _article.DeleteArticle(request);
            
        }
    }
}