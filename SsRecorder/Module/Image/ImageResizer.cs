using System.Drawing.Drawing2D;

namespace SsRecorder.Module.Image {

    /// <summary>
    /// 画像のリサイズを行うクラス
    /// </summary>
    public class ImageResizer {

        /// <summary>
        /// 必要があれば、リサイズする
        /// </summary>
        /// <param name="inputPath"></param>
        /// <param name="maxWidth"></param>
        /// <param name="maxHeight"></param>
        /// <returns></returns>
        public string ResizeImageIfNecessary(string inputPath, int maxWidth, int maxHeight) {

            using (var originalImage = System.Drawing.Image.FromFile(inputPath)) {
                int originalWidth = originalImage.Width;
                int originalHeight = originalImage.Height;

                var shouldResize = originalWidth > maxWidth || originalHeight > maxHeight;
                // リライズ不要
                if (!shouldResize) {
                    return inputPath;
                }

                // 出力パス
                var directory = Path.GetDirectoryName(inputPath) ?? ".";
                var fileNameWithoutExt = Path.GetFileNameWithoutExtension(inputPath);
                var extension = Path.GetExtension(inputPath); // 例: ".png"（拡張子が無い場合は空文字）
                var resizedFileName = $"{fileNameWithoutExt}_resized{extension}";
                var outputPath = Path.Combine(directory, resizedFileName);

                // 画像のリサイズ
                double ratioX = (double)maxWidth / originalWidth;
                double ratioY = (double)maxHeight / originalHeight;
                double ratio = Math.Min(ratioX, ratioY); // 小さい辺の比率に合わせる

                int newWidth = (int)(originalWidth * ratio);
                int newHeight = (int)(originalHeight * ratio);

                using (var resizedImage = new Bitmap(newWidth, newHeight)) {
                    using (var graphics = Graphics.FromImage(resizedImage)) {
                        graphics.CompositingQuality = CompositingQuality.HighQuality;
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.SmoothingMode = SmoothingMode.HighQuality;
                        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
                        graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
                    }
                    resizedImage.Save(outputPath);
                }

                return outputPath;
            }
        }
    }
}
