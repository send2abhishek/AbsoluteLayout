using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbsoluteLayout.Droid.CustomRenders;
using AbsoluteLayout.Renders;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(SLayout), typeof(GridRenderer))]
namespace AbsoluteLayout.Droid.CustomRenders
{
    public class GridRenderer : ViewRenderer
    {
        public GridRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
           SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.shape_rounded_blue_rect));
        }
    }
}