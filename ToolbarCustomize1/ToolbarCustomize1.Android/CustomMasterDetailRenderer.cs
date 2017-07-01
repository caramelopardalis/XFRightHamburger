
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using ToolbarCustomize1.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Platform.Android.AppCompat;

[assembly: ExportRenderer(typeof(MasterDetailPage), typeof(CustomMasterDetailRenderer))]

namespace ToolbarCustomize1.Droid
{
    public class CustomMasterDetailRenderer : MasterDetailPageRenderer
    {
        protected override void OnElementChanged(VisualElement oldElement, VisualElement newElement)
        {
            base.OnElementChanged(oldElement, newElement);

            var fieldInfo = GetType().BaseType.GetField("_masterLayout", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            var _masterLayout = (ViewGroup)fieldInfo.GetValue(this);
            var lp = new DrawerLayout.LayoutParams(_masterLayout.LayoutParameters);
            lp.Gravity = (int)GravityFlags.End;
            _masterLayout.LayoutParameters = lp;
        }
    }
}