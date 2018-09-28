using triApi.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Cors;

namespace TrianglesApp.Controllers
{
	public class TrianglesController : ApiController
	{
		Triangle[] triangles = new Triangle[]
		{
			new Triangle { Id = 1, Name = "A1", Coordinates = new Coordinates { V1 = new Point(0, 10), V2 = new Point(0, 0), V3 = new Point(10, 10) } },
			new Triangle { Id = 2, Name = "A2", Coordinates = new Coordinates { V1 = new Point(0, 10), V2 = new Point(0, 0), V3 = new Point(10, 10) } },
			new Triangle { Id = 3, Name = "A3", Coordinates = new Coordinates { V1 = new Point(0, 10), V2 = new Point(0, 0), V3 = new Point(10, 10) } },
		};

		public IEnumerable<Triangle> GetAllTriangles()
		{
			return triangles;
		}

		public IHttpActionResult GetTriangle(int id)
		{
			var triangle = triangles.FirstOrDefault((p) => p.Id == id);
			if (triangle == null)
			{
				return NotFound();
			}
			return Ok(triangle);
		}
	}
}