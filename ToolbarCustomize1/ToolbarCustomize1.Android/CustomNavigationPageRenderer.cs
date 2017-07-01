using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;
using System.ComponentModel;
using Xamarin.Forms.Platform.Android;
using ToolbarCustomize1.Droid;
using Android.Widget;
using Android.Support.V7.App;
using Android.Support.V4.Widget;

[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomNavigationPageRenderer))]

namespace ToolbarCustomize1.Droid
{
    public class CustomNavigationPageRenderer : NavigationPageRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<NavigationPage> e)
        {
            base.OnElementChanged(e);

            e.NewElement.LayoutChanged += (sender, ea) =>
            {
                var _drawerToggle = (ActionBarDrawerToggle)GetType().BaseType.GetField("_drawerToggle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).GetValue(this);
                if (_drawerToggle == null)
                {
                    return;
                }

                _drawerToggle.DrawerIndicatorEnabled = false;
            };
        }
    }
}