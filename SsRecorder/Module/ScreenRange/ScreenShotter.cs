using System.Drawing.Imaging;

namespace SsRecorder.Module.ScreenRange {
    public class ScreenShotter {

        public void CaptureScreenshot(Rectangle area, string path) {
            var bounds = Screen.PrimaryScreen.Bounds;
            using (Bitmap bmp = new Bitmap(area.Width, area.Height))
            using (Graphics g = Graphics.FromImage(bmp)) {
                g.CopyFromScreen(area.Location, Point.Empty, area.Size);
                bmp.Save(path, ImageFormat.Png);
                Console.WriteLine($"スクリーンショットを保存しました: {path}");
            }
        }
    }
}
