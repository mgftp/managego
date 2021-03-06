using Android.Graphics;
using SkiaSharp;
using SkiaSharp.Views.Android;

namespace CustomCalendar.Droid
{
    public class DrawableControlView<T> : SKCanvasView where T : IDrawableControlDelegate
    {
        readonly T _controlDelegate;

        public T ControlDelegate
        {
            get
            {
                return _controlDelegate;
            }
        }

        public DrawableControlView(Android.Content.Context context, T controlDelegate) : base(context)
        {
            _controlDelegate = controlDelegate;
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);
            _controlDelegate.Draw(e.Surface, e.Info);
        }


    }

}
