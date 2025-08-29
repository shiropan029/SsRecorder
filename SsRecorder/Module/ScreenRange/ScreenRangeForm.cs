namespace SsRecorder.Module.ScreenRange {

    /// <summary>
    /// 画面全体にオーバーレイを表示し、マウスで矩形範囲を選択するためのフォーム。
    /// 範囲選択が完了すると DialogResult.OK で閉じ、選択範囲は SelectedRegion に保存される。
    /// </summary>
    public class ScreenRangeForm :Form {
        private Point _startPoint;
        private Rectangle _selection;
        private bool _isSelecting = false;

        /// <summary>
        /// 選択された画面の範囲
        /// </summary>
        public Rectangle SelectedRegion { get; private set; }

        public ScreenRangeForm() {
            // formを使わずに、コードでUIを構築

            this.BackColor = Color.Black; // 黒背景
            this.Opacity = 0.3; // 背景を半透明化
            this.FormBorderStyle = FormBorderStyle.None; // 枠なし
            this.WindowState = FormWindowState.Maximized; // フルスクリーン表示
            this.TopMost = true; // 他ウィンドウの上に表示
            this.Cursor = Cursors.Cross; // 十字カーソル
            this.DoubleBuffered = true; // 範囲選択中のちらつきを防止
        }

        /// <summary>
        /// マウスボタンを押したときの処理。選択の開始位置を記録する。
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e) {
            _isSelecting = true;
            _startPoint = e.Location;        // 開始座標
            _selection = new Rectangle();    // 選択範囲を初期化
        }

        /// <summary>
        /// マウスを動かしたときの処理。ドラッグ中の矩形を更新し、再描画する。
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e) {
            if (_isSelecting) {
                // 左上と幅高さを動的に計算（逆ドラッグにも対応）
                _selection = new Rectangle(
                    Math.Min(_startPoint.X, e.X),
                    Math.Min(_startPoint.Y, e.Y),
                    Math.Abs(_startPoint.X - e.X),
                    Math.Abs(_startPoint.Y - e.Y)
                );
                Invalidate(); // 再描画
            }
        }

        /// <summary>
        /// マウスボタンを離したときの処理。選択範囲を確定してフォームを閉じる。
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e) {
            _isSelecting = false;
            SelectedRegion = _selection;
            DialogResult = DialogResult.OK;      
            Close();                             
        }

        /// <summary>
        /// 選択中の矩形を描画する
        /// </summary>
        protected override void OnPaint(PaintEventArgs e) {
            if (_selection != Rectangle.Empty) {
                using (var selectionPen = new Pen(Color.Red, 2)) {
                    e.Graphics.DrawRectangle(selectionPen, _selection);
                }
            }
        }
    }
}