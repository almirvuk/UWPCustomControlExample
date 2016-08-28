using CustomControlExample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CustomControlExample.Views {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpeakersView : Page {

        ObservableCollection<Speaker> speakersList { get; set; }

        public SpeakersView() {

            this.InitializeComponent();

            Speaker almir = new Speaker
            {
                FirstName = "Almir",
                LastName = "Vuk",
                Company = "AV Development",
                PhotoURL = "https://scontent-frt3-1.xx.fbcdn.net/v/l/t1.0-9/13346412_1024494224299174_8510937794765212356_n.jpg?oh=8ee83a7b9f16d0025ee02d5a9408e3b5&oe=585844AA"
            };

            Speaker emir = new Speaker
            {
                FirstName = "Emir",
                LastName = "Čajić",
                Company = "Freelance",
                PhotoURL = "https://scontent-frt3-1.xx.fbcdn.net/v/t1.0-9/12341153_1500518533586786_4557216893231140799_n.jpg?oh=7e9905603e8f747042ef225b42b6ced9&oe=583D1E39"
            };

            speakersList = new ObservableCollection<Speaker>();

            speakersList.Add(almir);
            speakersList.Add(emir);
        }
    }
}


