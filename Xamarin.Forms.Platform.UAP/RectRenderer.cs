﻿using System.ComponentModel;
using WRectangle = Windows.UI.Xaml.Shapes.Rectangle;

namespace Xamarin.Forms.Platform.UWP
{
	public class RectRenderer : ShapeRenderer<Rect, WRectangle>
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Rect> args)
		{
			if (Control == null && args.NewElement != null)
			{
				SetNativeControl(new WRectangle());
			}

			base.OnElementChanged(args);

			if (args.NewElement != null)
			{
				UpdateRadiusX();
				UpdateRadiusY();
			}
		}

		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs args)
		{
			base.OnElementPropertyChanged(sender, args);

			if (args.PropertyName == Rect.RadiusXProperty.PropertyName)
				UpdateRadiusX();
			else if (args.PropertyName == Rect.RadiusYProperty.PropertyName)
				UpdateRadiusY();
		}

		void UpdateRadiusX()
		{
			Control.RadiusX = Element.RadiusX;
		}

		void UpdateRadiusY()
		{
			Control.RadiusY = Element.RadiusY;
		}
	}
}