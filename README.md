# SsRecorder


<img width="2295" height="1701" alt="SsRecorder" src="https://github.com/user-attachments/assets/4cc1a277-6fe7-4c5d-8427-913fce18a1e3" />
<br>
<br>
<br>

# 1. ツール概要
主に映像作品の演出を整理・蓄積し、それらを素早く参照できるようにする **C# + Excel VBA** のツールです。
<br>
<br>
<br>


# 2.  ツールを作った背景
私は趣味で楽曲のMVを制作しています。  
制作時、依頼者と「どのような演出がよいか」を相談します。たとえば依頼者から「ここでキャラクターが走ってほしい」と言われても、「走る」にも多様な表現があり、最適な演出に迷うことがあります。毎回、会議中に多数のMVを見返して「走る」演出を探すのは時間がかかります。  
そこで、あらかじめ多様な「走る」演出をまとめたリファレンスを作成していれば、**演出のイメージを素早く共有**でき、認識の齟齬を防げると考えました。  
この発想を拡張し、**様々な映像作品を“演出ごと”に整理できるツール**として本ツールを作成しました。  
<br>
<br>
<br>



# 3. 機能説明
## 分析メモシートを生成する
- 「分析シート生成」ボタンを押すと、SsRecorderで記録する用のシートを生成することができます。
![Image from Gyazo](https://i.gyazo.com/3553cc92ab44cf1dbde21c3660baf734.gif)
<br>

## 演出を記録する
- 「記録する」ボタンを押すと、設定した画面範囲のスクリーンショットとフォーム左側の単語を、設定したExcelに書き込みます。
- 「スクショ範囲選択」ボタンでスクリーンショットの画面範囲を選択し、「設定」ボタンで記録するExcelファイルを選択できます。
![Image from Gyazo](https://i.gyazo.com/4a642d904f6568681288ddfb8b8f6a5d.gif)
<br>

## 単語別に演出をまとめる
- 「単語生成」ボタンを押すと、一覧にまとめられている各「分析メモ」シートに記録された演出を参照します。それらを単語別にまとめて、シートに書き出します。
- 同時にそれぞれの演出数を集計した「単語まとめ」シートも作成されます。
![Image from Gyazo](https://i.gyazo.com/42deca06a70a6fab00d09144196168fa.gif)
<br>
<br>
<br>


# 4.  画面一覧
| SsRecorder：記録画面 | SsRecorder：設定画面 |
| ---- | ---- |
| [![Image from Gyazo](https://i.gyazo.com/196c3fbd3687327eecb52b5fbb694d0a.png)](https://gyazo.com/196c3fbd3687327eecb52b5fbb694d0a) | [![Image from Gyazo](https://i.gyazo.com/6afa5cad26ecca931bf9ce625a1dcdaa.png)](https://gyazo.com/6afa5cad26ecca931bf9ce625a1dcdaa) |
| 「記録する」ボタンを押すと、設定範囲のスクリーンショットを撮り、画面左のフォームに入れた単語と共に、設定したエクセルへの書き込みを行います。 | 記録するExcelファイルや動画のリンク、スクリーンショットの縦横サイズ等を設定できます。 |

| 分析まとめ：一覧 |  分析メモ：メモ |
| ---- | ---- |
| [![Image from Gyazo](https://i.gyazo.com/8496553184718404672ca7c07b8474d5.png)](https://gyazo.com/8496553184718404672ca7c07b8474d5) |　[![Image from Gyazo](https://i.gyazo.com/a689157b97e44a72696709b2fe56c49b.png)](https://gyazo.com/a689157b97e44a72696709b2fe56c49b)|
| 「分析メモ」シートをまとめたシートです。右上のマクロとリンクしたボタンから、「分析メモ」シートを作成したり、演出を単語別にまとめることができます。 | タイトルごとに演出を記録します。「SsRecorder：記録画面」を使って記録する場所はこのシートになります。 |

| 分析まとめ：単語まとめ | 分析まとめ：単語 |
| ---- | ---- |
| [![Image from Gyazo](https://i.gyazo.com/bfa1749ec383107c4f55d739e550ca3b.png)](https://gyazo.com/bfa1749ec383107c4f55d739e550ca3b) |　[![Image from Gyazo](https://i.gyazo.com/534a74eec8608964330e75701fdbcffd.png)](https://gyazo.com/534a74eec8608964330e75701fdbcffd)|
|「 分析まとめ：一覧」の「単語生成」ボタンから自動生成されます。各演出の数とシートへのリンクをまとめています。 | 「分析まとめ：一覧」の「単語生成」ボタンから自動生成されます。「分析メモ：メモシート」に記録した演出を単語ごとに整理して、シートにまとめています。 |
<br>
<br>
<br>

# 5.  動作環境
- Excel 2024 または Microsoft 365 (Office 365) のExcelがインストールされている環境
- Windows OS 上で .exe ファイルを実行できる環境
<br>
<br>
<br>



# 6.  使用技術
【Excel】
- Excel 2024
- VBA
<br>

【C#】
- .NET 8
    - Microsoft.Office.Interop.Excel
<br>
<br>
<br>



# 7.  Excelのデータ構造（ER図）
<img width="235" height="488" alt="ER図" src="https://github.com/user-attachments/assets/b3abc5ab-8ac6-47e1-893c-b3eba57f6103" />
<br>
<br>
<br>



# 8 . ディレクトリ構造
```
.
├─ SsRecorder/                     # Windowsアプリ
│  ├─ Model/                       # データ関連の処理
│  ├─ Module/                      # 単機能モジュール（例：画像解像度変更等、他で流用できそうな処理）
│  ├─ Service/                     # アプリ固有の処理（他で流用しない想定の処理）
│  ├─ View/                        # UI・フォーム
│  └─ Program.cs                   # エントリーポイント
│
├─ SsRecorder_Excel/               # VBAアプリ
├─ SsRecorder_Excel_Sample/        # ツールで作成したサンプルExcelファイル
└─ SsRecorder_Excel_VBA/           # VBAをテキスト化（差分確認用）
```
<br>
<br>
<br>



# 9.  工夫した点
## Google スプレッドシートを使わずに作成
- 当初は個人利用を前提として、Google スプレッドシート（GAS）で作成しておりました。
    - 当時作成したもの：https://docs.google.com/spreadsheets/d/1LJ-zHr_87Mc51On2f02Vvlf313X7rc4o-6RRR-dpIn8/edit?usp=sharing
- しかし、スプレッドシートでの運用には以下の課題がありました。
    - ツールを配布する際に、**使用者ごとに Google Cloud の設定が必要**となり、非エンジニアの方にとってはハードルが高いこと。
    - **GAS の実行上限（5分）** があるため、データが増えると処理が途中で止まる懸念があること。
- これらの課題を解消するため、Excel ベースで全面的に作り直しました。
<br>

## SsRecorder の中核処理を View（フォーム）に書かない
- 将来的に UI を改善することを前提とし、**View（フォーム）にロジックを集中させない**ようにしました。
    - 中核となる処理は`Service/`と`Module/`にまとめ、ピュアなC#で実装しています。
- これにより、**UI改修時の影響範囲を最小限に抑えられる設計**となっております。
<br>

## エンジニアでなくても使いやすいツールを意識
- 本ツールの想定ユーザーは**デザイナーやアニメーター**の方々であり、エンジニアではありません。
- そのため、DB や Google Cloud などを利用するツールにしてしまうと、ユーザーにとって利用のハードルが高くなります。
- そこで、**多くの方に馴染みのある Excel でデータを管理**する方針にしました。
    - DB でデータを管理していないので、SQLを知らないユーザーでも**直接データを編集できる**ようになっています。 
    - Excelファイルには、なるべく処理に関わるデータを入れないようにして、ユーザーが誤って編集し、ツールが壊れてしまうリスクを軽減しています。
<br>
<br>
<br>




# 10. 今後の動きについて
- ツールを配布しやすいように、配布用のzipファイルやインストーラーを作成します。
- **Mac でも利用可能**にします。
    - **Avalonia UI** によるUIの再実装
        - 設計は **MVVM** を採用予定
- 私自身、このツールをたくさん使用しながら、**UI/UXの改善**を進め、より使いやすい操作性を目指します。
- 派生ツールとして、**アニメや映画、ゲームの演出・シナリオ分析**を効率的にできるツールを作成します。
<br>
<br>
<br>



# 11. 参考
`SsRecorder_Excel_Sample/` の中にあるサンプルExcelファイルを作る際に以下の動画を使用しました。
- https://youtu.be/Sq5Dj0U06vQ?feature=shared
- https://youtu.be/UwA_4TafA_g?feature=shared
