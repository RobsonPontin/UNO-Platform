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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

#if NETFX_CORE
using pdftron;

#endif

namespace UNO_Sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

#if NETFX_CORE
            pdftron.PDFNet.Initialize();
            pdftron.PDF.PDFViewCtrl PDFViewCtrl = new pdftron.PDF.PDFViewCtrl();
            borderViewer.Child = PDFViewCtrl;

            pdftron.PDF.PDFDoc doc = new pdftron.PDF.PDFDoc("GettingStarted.pdf");

            PDFViewCtrl.SetDoc(doc);
#endif
        }
    }
}
