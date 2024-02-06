using City_Easter_Eggs.Models;
using Microsoft.AspNetCore.Mvc;

namespace City_Easter_Eggs.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class PointsController : ControllerBase
	{
		private readonly ILogger<PointsController> _logger;

		public PointsController(ILogger<PointsController> logger)
		{
			_logger = logger;
		}

		public IEnumerable<PointOfInterest> GetPoints()
		{
			var list = new List<PointOfInterest>();
			for (int x = 0; x < 10; x++)
			{
				for (int y = 0; y < 10; y++)
				{
					list.Add(new PointOfInterest()
                    {
                        Id = $"test_{x}x{y}",
                        Longitude = 20 + x,
                        Latitude = 40 + y
                    });
				}
			}

			return list;
        }
	}
}
