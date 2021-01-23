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
        private readonly IArticle _article;
        public ArticleController(IMediator mediator, IArticle article)
        {
            _mediator = mediator;
            _article = article;
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetArticleById([FromRoute]GetArticleByIdQuery request)
        {
            return Ok(await _mediator.Send(request));
        }
        
        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateArticle(CreateArticleQuery request)
        {
            return Ok(await _mediator.Send(request));
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllArticle([FromRoute]GetAllArticleQuery request)
        {
            return Ok(await _mediator.Send(request));
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}