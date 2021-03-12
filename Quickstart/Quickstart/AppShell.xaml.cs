
using Quickstart.Views;
using Xamarin.Forms;

namespace Quickstart
{
        public partial class AppShell : Shell
        {
            public AppShell()
            {
                InitializeComponent();
                Routing.RegisterRoute(nameof(NoteEntryPage), typeof(NoteEntryPage));
            }

        }
}
