using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CubeShaftEngine.Math;

namespace CubeShaftEngine.Render
{
	public interface IIndexedTriangles : List<ITriangle>, IRenderable
	{
	}
}
