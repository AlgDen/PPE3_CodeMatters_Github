using System;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using Windows.Data.Xml.Dom;

using Windows.UI.Notifications;
using Microsoft.Toolkit.Uwp.Notifications; // Notifications library

namespace PPE3_CodeMatters_Github
{
    /// <summary>
    /// Logique d'interaction pour ToastWindow.xaml
    /// </summary>
    public partial class ToastWindow : Window
    {
        private static ToastWindow instance = null;

        public static ToastWindow Instance {
            get
            {
                if (ToastWindow.instance == null)
                {
                    ToastWindow.instance = new ToastWindow();
                }

                return ToastWindow.instance;
            }
        }


        public string APP_ID { get { return Properties.Resources.appname; } }

        private ToastWindow()
        {
            InitializeComponent();
        }

        public static void ShowNotification(string title, string txt1 = null, string txt2 = null, string imagePath = null)
        {
            Instance.__ShowNotification(title, txt1, txt2, imagePath);
        }

        private void __ShowNotification(string title, string txt1 = null, string txt2 = null, string imagePath = null)
        {

            // Get a toast XML template
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastImageAndText04);

            // Fill in the text elements
            XmlNodeList stringElements = toastXml.GetElementsByTagName("text");
            stringElements[0].AppendChild(toastXml.CreateTextNode(title));
            if (txt1 != null)
            {
                stringElements[1].AppendChild(toastXml.CreateTextNode(txt1));
            }

            if (txt2 != null)
            {
                stringElements[2].AppendChild(toastXml.CreateTextNode(txt2));
            }

            if (imagePath != null)
            {
                // Specify the absolute path to an image
                imagePath = "file:///" + imagePath;
                XmlNodeList imageElements = toastXml.GetElementsByTagName("image");
                imageElements[0].Attributes.GetNamedItem("src").NodeValue = imagePath;
            }

            // Create the toast and attach event listeners
            ToastNotification toast = new ToastNotification(toastXml);
            toast.Activated += ToastActivated;
            toast.Dismissed += ToastDismissed;
            toast.Failed += ToastFailed;

            // Show the toast. Be sure to specify the AppUserModelId on your application's shortcut!
            ToastNotificationManager.CreateToastNotifier(APP_ID).Show(toast);
        }

        private void ToastActivated(ToastNotification sender, object e)
        {
            Dispatcher.Invoke(() =>
            {
                Activate();
                Output.Text = "The user activated the toast.";
            });
        }

        private void ToastDismissed(ToastNotification sender, ToastDismissedEventArgs e)
        {
            String outputText = "";
            switch (e.Reason)
            {
                case ToastDismissalReason.ApplicationHidden:
                    outputText = "The app hid the toast using ToastNotifier.Hide";
                    break;
                case ToastDismissalReason.UserCanceled:
                    outputText = "The user dismissed the toast";
                    break;
                case ToastDismissalReason.TimedOut:
                    outputText = "The toast has timed out";
                    break;
            }

            Dispatcher.Invoke(() =>
            {
                Output.Text = outputText;
            });
        }

        private void ToastFailed(ToastNotification sender, ToastFailedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                Output.Text = "The toast encountered an error.";
            });
        }
    }
}
