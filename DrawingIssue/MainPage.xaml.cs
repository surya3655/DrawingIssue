namespace DrawingIssue
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

    }

    public class GraphicsDrawable : IDrawable
    {
        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            canvas.StrokeColor = Colors.Red;
            canvas.DrawRectangle(new RectF(dirtyRect.X,dirtyRect.Y,dirtyRect.Width-20, dirtyRect.Height));
        }
    }

}
