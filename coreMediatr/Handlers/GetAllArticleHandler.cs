using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using coreMediatr.Models;
using coreMediatr.Persistance;
using MediatR;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace coreMediatr.Application.Articles.Queries
{
    public class GetAllArticleHandler : IRequestHandler<GetAllArticleQuery,List<Article>>
    {
        private readonly MediatRContext _mediatRContext;

        public GetAllArticleHandler(MediatRContext mediatRContext)
        {
            _mediatRContext = mediatRContext;
        }

        public async Task<List<Article>> Handle(GetAllArticleQuery request, CancellationToken cancellationToken)
        {
            return _mediatRContext.Articles.ToList();
        }
    }
}