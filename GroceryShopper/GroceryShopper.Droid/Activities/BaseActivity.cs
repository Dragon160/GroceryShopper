using Android.Views;
using Android.Views.InputMethods;
using Cirrious.MvvmCross.Droid.Views;

namespace GroceryShopper.Droid.Activities
{
    public class BaseActivity : MvxActivity
    {
        public override bool DispatchTouchEvent(MotionEvent ev)
        {
            var focusedElement = CurrentFocus;
            var inputMethodManager = (InputMethodManager)GetSystemService(InputMethodService);
            inputMethodManager.HideSoftInputFromWindow(focusedElement == null ? null : focusedElement.WindowToken, 0);
            if (focusedElement != null)
            {
                focusedElement.ClearFocus();
            }

            return base.DispatchTouchEvent(ev);
        }
    }
}