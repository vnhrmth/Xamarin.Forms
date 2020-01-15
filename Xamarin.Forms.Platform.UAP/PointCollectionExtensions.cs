﻿using WPoint = Windows.Foundation.Point;
using WPointCollection = Windows.UI.Xaml.Media.PointCollection;

namespace Xamarin.Forms.Platform.UWP
{
	public static class PointCollectionExtensions
	{
		public static WPointCollection ToWindows(this PointCollection pointCollection)
		{
			if (pointCollection == null || pointCollection.Count == 0)
			{
				return new WPointCollection();
			}

			WPointCollection points = new WPointCollection();
			Point[] array = new Point[pointCollection.Count];
			pointCollection.CopyTo(array, 0);

			for (int i = 0; i < array.Length; i++)
			{
				points.Add(new WPoint(array[i].X, array[i].Y));
			}

			return points;
		}
	}
}