using System;
using System.Collections;
using System.Drawing;

namespace TriggerEdit
{
	public struct Trigger
	{
		public int       X;
		public int       Y;
		public string    name;
		public Property  action;
		public Property  condition;
		public ArrayList links;
		public Brush     color_;
		public struct Link
		{
			public int   target;
			public Color color;
			public bool  is_active;
		};
	}

	class TriggerComparer : IComparer
	{
		#region IComparer Members

		public int Compare(object x, object y)
		{
			Trigger cell1 = (Trigger)x;
			Trigger cell2 = (Trigger)y;
			if (cell1.X == cell2.X)
				return cell1.Y - cell2.Y;
			else
				return cell1.X - cell2.X;
		}

		#endregion
	}
}
