using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] //api/activities
    public class BaseApiController : ControllerBase
    {

    }
} 