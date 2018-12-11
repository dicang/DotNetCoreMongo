using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Mongo.Api.Services;

namespace Mongo.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RollerCoasterController : ControllerBase
	{
		private readonly IRollerCoasterService coasterService;

		public RollerCoasterController(IRollerCoasterService coasterService)
		{
			this.coasterService = coasterService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				var list = await coasterService.GetAll();
				return new OkObjectResult(list);
			}
			catch (Exception e)
			{
				return new BadRequestObjectResult("Something went wrong here....");
			}
		}

		[HttpGet("{name}")]
		public async Task<IActionResult> Get(string name)
		{
			try
			{
				var model = await coasterService.GetRollerCoaster(name);
				return new OkObjectResult(model);
			}
			catch (Exception e)
			{
				return new BadRequestObjectResult(e.Message);
			}
		}

		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}