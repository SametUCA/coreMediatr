using System.Collections.Generic;
using coreMediatr.Application.Articles.Queries;

namespace coreMediatr.Models
{
    public interface IArticle
    {
        public Article CreateArticle(CreateArticleQuery request);
        public List<Article> GetAllArticle(GetAllArticleQuery request);

        public Article GetArticleById(GetArticleByIdQuery request);
    }
}