using System;

namespace ClusteringProgram.Graph
{
	public class Edge : IComparable
	{
		private readonly CPPoint startPoint;
		private readonly CPPoint endPoint;
		private readonly double length;

		public Edge(CPPoint startPoint, CPPoint endPoint)
		{
			this.startPoint = startPoint;
			this.endPoint = endPoint;
			length = endPoint - startPoint;
		}
		
		public CPPoint GetStartPoint()
		{
			return startPoint;
		}
		
		public CPPoint GetEndPoint()
		{
			return endPoint;
		}
		
		public double GetLength()
		{
			return length;
		}
		
		public int CompareTo(Object obj)
		{
			var edge = (Edge)obj;
			if (length > edge.length) {
				return 1;
			}
			if (length < edge.length) {
				return -1;
			}
			return 0;
		}
		
		public override string ToString()
		{
			return string.Format("[Edge StartPoint={0}, EndPoint={1}, Length={2}]", startPoint, endPoint, length);
		}
	}
}
