namespace AvaloniaPlayground;

using Avalonia.Controls;
using Avalonia;
using Avalonia.Input;
using Avalonia.Media;
using Avalonia.Threading;
using System;

public partial class BlueprintCanvas: Control
{
    public IBrush? Background { get; set; }

    public BlueprintCanvas()
    {
        InitializeIfNeeded();
        InitializeComponent();
    }

    public override void Render(DrawingContext context)
    {
        Dispatcher.UIThread.Invoke(() =>
        {
            if (Background != null)
            {
                context.FillRectangle(Background, new Rect(Bounds.Size));
            }
        }, DispatcherPriority.Default);
    }

    protected override void OnPointerPressed(PointerPressedEventArgs e)
    {
        Background = Brushes.Blue;
        Console.WriteLine("Event fired");
        base.OnPointerPressed(e);
    }
}
