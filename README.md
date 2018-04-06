# Unity 2017.3.1p3 でのUnityWebRequestがContent-Length なしのリクエストを発行する

## 再現方法

* Assets/Sample シーンを開く
* PlayするとUnityWebRequestでのHTTP Postが行われる。
* Content-Length がリクエストヘッダにセットされていないため、エラーが出る。

## Unityのバグ修正による仕様変更の結果でした

詳細は [Unity 2017.3以降のUnityWebRequestの話](http://sassembla.github.io/Public/2018:03:24%2018-26-28/2018:03:24%2018-26-28.html) に記載してあります。



