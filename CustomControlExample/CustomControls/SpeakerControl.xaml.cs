using System;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace CustomControlExample.CustomControls {
    public sealed partial class SpeakerControl : UserControl {
        public SpeakerControl() {
            this.InitializeComponent();
        }

        public ImageSource PhotoURL
        {
            get { return (ImageSource)GetValue(PhotoURLProperty); }
            set { SetValue(PhotoURLProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PhotoURL.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PhotoURLProperty =
            DependencyProperty.Register("PhotoURL", typeof(ImageSource), typeof(SpeakerControl), null);

        public string FirstName
        {
            get { return (string)GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FirstName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FirstNameProperty =
            DependencyProperty.Register("FirstName", typeof(string), typeof(SpeakerControl), null);


        public string LastName
        {
            get { return (string)GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for LastName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty LastNameProperty =
            DependencyProperty.Register("LastName", typeof(string), typeof(SpeakerControl), null);


        public string Company
        {
            get { return (string)GetValue(CompanyProperty); }
            set { SetValue(CompanyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Company.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CompanyProperty =
            DependencyProperty.Register("Company", typeof(string), typeof(SpeakerControl), null);



    }
}
