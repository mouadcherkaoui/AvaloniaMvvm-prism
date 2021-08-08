using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaMvvm.Modules.Mail.Views
{
    public partial class MailView : UserControl
    {
        public MailView()
        {
            InitializeComponent();
#if DEBUG
            // this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}