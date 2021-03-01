using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TodoController : ControllerBase
	{
		[HttpGet]
		public IEnumerable<string> Get()
		{
			return new[] {""};
		}
	}
}