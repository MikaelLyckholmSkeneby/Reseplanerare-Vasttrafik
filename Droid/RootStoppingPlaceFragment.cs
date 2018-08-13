﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace stops
{
	public class RootStoppingPlaceFragment : LazyLoadFragment
	{

		public override int Delay {
			get {
				return 100;
			}
		}

		private FocuableFragment _frag;

		#region implemented abstract members of LazyLoadFragment

		#region implemented abstract members of LazyLoadFragment

		public override void SetFragment ()
		{
			_frag = new StoppingPlaceFragment ();
		}

		#endregion




		public override FocuableFragment Frag {
			get {
				return _frag;
			}
			set {
				Frag = value;
			}
		}
		public override int ResourceId {
			get {
				return Resource.Id.root_stopping_place_fragment;
			}
		}
		#endregion


		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

		

			// Create your fragment here
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			// Use this to return your custom view for this Fragment
			var view = inflater.Inflate(Resource.Layout.RootStoppingPlaceFragment, container, false);

			//var view =  inflater.Inflate(Resource.Layout.root_fragment, container, false);


			this.Create ();


			return view;

		}
	}
}
