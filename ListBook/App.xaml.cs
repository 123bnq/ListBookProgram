using Avalonia;
using Avalonia.Markup.Xaml;

namespace ListBook
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
