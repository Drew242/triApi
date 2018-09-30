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
		List<Triangle> triangles = TriangleSeed.Seed();
		public IEnumerable<Triangle> GetAllTriangles()
		{
			return triangles;
			// return triangles;
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