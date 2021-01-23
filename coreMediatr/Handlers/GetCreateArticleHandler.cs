using System.Threading;
using System.Threading.Tasks;
using coreMediatr.Application.Articles.Queries;
using coreMediatr.Models;
using MediatR;

namespace coreMediatr.Handlers
{
    public class GetCreateArticleHandler : IRequestHandler<CreateArticleQuery,Article>
    {
        private readonly IArticle _article;

        public GetCreateArticleHandler(IArticle article)
        {
            _article = article;
        }

        public async Task<Article> Handle(CreateArticleQuery request, CancellationToken cancellationToken)
        {
            return _article.CreateArticle(request);
        }
    }
}