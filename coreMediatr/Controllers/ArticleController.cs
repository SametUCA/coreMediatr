using System.Threading.Tasks;
using coreMediatr.Application.Articles.Queries;
using coreMediatr.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace coreMediatr.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : Controller
    {
        private readonly IMediator _mediator;

        public ArticleController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("FindArticleById/{id}")]
        public async Task<IActionResult> GetArticleById([FromRoute]GetArticleByIdQuery request=null)
        {
            return request!=null ? Ok(await _mediator.Send(request)) : Ok(StatusCode(200));
        }
        
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateArticle(CreateArticleQuery request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllArticle(GetAllArticleQuery request)
        {
            return Ok(await _mediator.Send(request));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}