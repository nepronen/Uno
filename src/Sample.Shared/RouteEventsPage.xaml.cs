﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Sample
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class RouteEventsPage : Page
	{
		public RouteEventsPage()
		{
			this.InitializeComponent();

			HookEvents(outer, resultOuter);
			HookEvents(middle, resultMiddle);
			HookEvents(inner, resultInner);
			HookEvents(scroll, resultScroll);
		}

		private void HookEvents(Grid grid, TextBlock textBlock)
		{
			void TapHandler(object snd, TappedRoutedEventArgs evt)
			{
				textBlock.Text += $".T({evt.GetPosition(null)})";
				evt.Handled = true;
			}

			void TapHandler2(object snd, TappedRoutedEventArgs evt)
			{
				textBlock.Text += $".t({GetPosition(evt)})";
				//evt.Handled = false;
			}

			grid.AddHandler(TappedEvent, (TappedEventHandler) TapHandler, false);
			grid.AddHandler(TappedEvent, (TappedEventHandler) TapHandler2, true);

			string GetPosition(TappedRoutedEventArgs evt)
			{
				var pos = evt.GetPosition(null);
				return $"{Math.Round(pos.X, 1)}, {Math.Round(pos.Y, 1)}";
			}

			textBlock.Tapped += TapHandler3;

			void TapHandler3(object sender, TappedRoutedEventArgs evt)
			{
				textBlock.Text += $".e({GetPosition(evt)})";
			}

			grid.AddHandler(DoubleTappedEvent, (DoubleTappedEventHandler) DoubleTappedHandler, true);

			void DoubleTappedHandler(object sender, DoubleTappedRoutedEventArgs e)
			{
				textBlock.Text += $".dt";
				e.Handled = true;
			}

			grid.PointerEntered += (s, e) =>
			{
				textBlock.Text += "<<";
				e.Handled = true;
			};

			grid.PointerExited += (s, e) => textBlock.Text += ">>";

			grid.PointerPressed += (s, e) =>
			{
				textBlock.Text += "_";
				grid.BorderThickness = new Thickness(3);
			};
			grid.PointerReleased += (s, e) =>
			{
				textBlock.Text += "-";
				grid.BorderThickness = new Thickness(0);
			};

			grid.GotFocus += (s, e) => textBlock.Text += ".F";
			grid.LostFocus += (s, e) => textBlock.Text += ".f";

			grid.KeyDown += (s, e) => textBlock.Text += ".K";
			grid.KeyUp += (s, e) => textBlock.Text += ".k";
		}
	}
}