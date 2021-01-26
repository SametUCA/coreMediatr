using System.Collections.Generic;
using System.Linq;
using ASP;
using coreMediatr.Application.Articles.Queries;
using coreMediatr.Models;
using coreMediatr.Persistance;
using MediatR;

namespace coreMediatr.Repository
{
    public class ArticleRepository : IArticle
    {
        private readonly MediatRContext _mediatRContext;
        private readonly IMediator _mediator;

        public ArticleRepository(MediatRContext mediatRContext, IMediator mediator)
        {
            _mediatRContext = mediatRContext;
            _mediator = mediator;
        }

        public Article CreateArticle(CreateArticleQuery request)
        {
            var article = new Article
            {
                Id = request.Id,
                Name = request.Name
            };
            _mediatRContext.Articles.Add(article);
            return article;
        }

        public List<Article> GetAllArticle(GetAllArticleQuery request)
        {
            var articles = _mediatRContext.Articles.ToList();
            return articles;
        }

        public Article GetArticleById(GetArticleByIdQuery request)
        {
            var article = _mediatRContext.Articles.FirstOrDefault(articles => articles.Id == request.Id);
            return article;
        }

        public Article DeleteArticle(DeleteArticleQuery request)
        {
            var deleteArticle = _mediatRContext.Articles.Single(articles => articles.Id == request.Id);
            _mediatRContext.Articles.Remove(deleteArticle);
            return deleteArticle;
        }
    }
}