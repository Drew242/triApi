using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace triApi.Models
{
	static class TriangleSeed
	{

		public static List<Triangle> Seed()
		{
			List<Triangle> triangles = new List<Triangle>();
			String[] characterRows = new String[] { "A", "B", "C", "D", "E", "F" };
			int[] characterColumns = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
			return triangles = MapTriangles(characterRows, characterColumns);
		}

		private static List<Triangle> MapTriangles(String[] rows, int[] columns)
		{
			List<Triangle> mappedTriangles = new List<Triangle>();
			int pixelScale = 10;
			int idCounter = 1;

			for (int i = 0; i < rows.Length; i++)
			{
				for (int j = 0; j < columns.Length; j++)
				{
					mappedTriangles.Add(CreateTriangle(rows[i], i, columns[j], pixelScale, idCounter));
					idCounter += 1;
				}
			}

			return mappedTriangles;
		}

		private static Triangle CreateTriangle(String row, int rowIndex, int column, int pixelScale, int id)
		{
			rowIndex += 1;
			bool odd = (column % 2 == 0) ? false : true;

			int v1x = (odd == true) ? (((column * pixelScale) - pixelScale) / 2) : ((column / 2) * pixelScale);
			int v1y = (odd == true) ? (rowIndex * pixelScale) : ((rowIndex * pixelScale) - pixelScale);
			int v2x = (odd == true) ? (((column * pixelScale) - pixelScale) / 2) : ((column / 2) * pixelScale);
			int v2y = (odd == true) ? ((rowIndex * pixelScale) - pixelScale) : (rowIndex * pixelScale);
			int v3x = (odd == true) ? (((column * pixelScale) + pixelScale) / 2) : (((column / 2) * pixelScale) - pixelScale);
			int v3y = (odd == true) ? (rowIndex * pixelScale) : ((rowIndex * pixelScale) - pixelScale);

			return new Triangle
			{
				Id = id,
				Name = $"{row}{column}",
				Coordinates = new Coordinates
				{
					V1 = new Point(v1x, v1y),
					V2 = new Point(v2x, v2y),
					V3 = new Point(v3x, v3y)
				}
			};
		}
	}
}