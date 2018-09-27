using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace triApi.Models
{
	public class Triangle
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public Coordinates Coordinates { get; set; }
	}

	public class Coordinates
	{
		public Point V1 { get; set; }
		public Point V2 { get; set; }
		public Point V3 { get; set; }
	}
}