using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using coreMediatr.Application.Articles.Queries;
using coreMediatr.Models;
using coreMediatr.Persistance;
using MediatR;

namespace coreMediatr.Handlers
{
    public class GetAllArticleHandler : IRequestHandler<GetAllArticleQuery,List<Article>>
    {
        private readonly IArticle _article;
        public GetAllArticleHandler(IArticle article)
        {
            _article = article;
        }

        public async Task<List<Article>> Handle(GetAllArticleQuery request, CancellationToken cancellationToken)
        {
            return _article.GetAllArticle(request);
        }
    }
}