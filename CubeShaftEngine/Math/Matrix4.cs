using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeShaftEngine.Math
{
	public struct Matrix4<T>
	{
		T M11 { get; set; }
		T M12 { get; set; }
		T M13 { get; set; }
		T M14 { get; set; }
		T M21 { get; set; }
		T M22 { get; set; }
		T M23 { get; set; }
		T M24 { get; set; }
		T M31 { get; set; }
		T M32 { get; set; }
		T M33 { get; set; }
		T M34 { get; set; }
		T M41 { get; set; }
		T M42 { get; set; }
		T M43 { get; set; }
		T M44 { get; set; }
	}
}
