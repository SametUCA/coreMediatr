using System.Threading;
using System.Threading.Tasks;
using coreMediatr.Application.Articles.Queries;
using coreMediatr.Models;
using coreMediatr.Persistance;
using MediatR;

namespace coreMediatr.Handlers
{
    public class GetCreateArticleHandler : IRequestHandler<CreateArticleQuery,Article>
    {
        private readonly MediatRContext _mediatRContext;

        public GetCreateArticleHandler(MediatRContext mediatRContext)
        {
            _mediatRContext = mediatRContext;
        }

        public async Task<Article> Handle(CreateArticleQuery request, CancellationToken cancellationToken)
        {
            var article = new Article
            {
                Id = request.Id,
                Name = request.Name
            };
            await _mediatRContext.Articles.AddAsync(article, cancellationToken);
            return article;
        }
    }
}