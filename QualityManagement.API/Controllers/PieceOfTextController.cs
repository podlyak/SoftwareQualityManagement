using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QualityManagement.Shared;
using static QualityManagement.Shared.PieceOfText;

namespace QualityManagement.API.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class PieceOfTextController : ControllerBase {
        
        [HttpGet("{text}")]
        public async Task<string> Get(string text) {
            return await Task.Run(() => SearchForFragments(text).ToSimpleText());
        }
    }
}
