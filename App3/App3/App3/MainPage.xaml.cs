using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

#if __ANDROID__
using Android.Widget;
using Xamarin.Forms.Platform.Android;
#endif

#if __IOS__
using UIKit;
using Xamarin.Forms.Platform.iOS;
#endif

namespace App3 {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

#if __ANDROID__
            TextView labelDroid = new TextView(Forms.Context) { Text = "Eu sou Android Nativo !" };
            Container.Children.Add(labelDroid);
#endif

#if __IOS__
            UILabel labelIOS = new UILabel() { Text = "Eu sou iOS Nativo!" };
            Container.Children.Add(labelIOS);
#endif
        }
    }
}
