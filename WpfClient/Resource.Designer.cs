﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfClient {
    using System;
    
    
    /// <summary>
    ///   ローカライズされた文字列などを検索するための、厳密に型指定されたリソース クラスです。
    /// </summary>
    // このクラスは StronglyTypedResourceBuilder クラスが ResGen
    // または Visual Studio のようなツールを使用して自動生成されました。
    // メンバーを追加または削除するには、.ResX ファイルを編集して、/str オプションと共に
    // ResGen を実行し直すか、または VS プロジェクトをビルドし直します。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   このクラスで使用されているキャッシュされた ResourceManager インスタンスを返します。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WpfClient.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   すべてについて、現在のスレッドの CurrentUICulture プロパティをオーバーライドします
        ///   現在のスレッドの CurrentUICulture プロパティをオーバーライドします。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   地域コード(文字列型),地域コード(数値型),地方,都道府県,地域,緯度,経度
        ///900,900,未設定,,地域未設定,,
        ///901,901,不明,,地域不明,,
        ///905,905,外国,,日本以外,,
        ///010,10,北海道,北海道,北海道 石狩,43.062,141.354
        ///015,15,北海道,北海道,北海道 渡島,41.820,140.753
        ///020,20,北海道,北海道,北海道 檜山,41.859,140.128
        ///025,25,北海道,北海道,北海道 後志,42.902,140.756
        ///030,30,北海道,北海道,北海道 空知,43.198,141.767
        ///035,35,北海道,北海道,北海道 上川,43.808,142.439
        ///040,40,北海道,北海道,北海道 留萌,43.935,141.656
        ///045,45,北海道,北海道,北海道 宗谷,45.398,141.700
        ///050,50,北海道,北海道,北海道 網走,44.027,144.261
        ///055,55,北海道,北海道,北海道 胆振,42.321,140.972
        ///060,60,北海道,北海道,北海道 日高,42.173, [残りの文字列は切り詰められました]&quot;; に類似しているローカライズされた文字列を検索します。
        /// </summary>
        internal static string epsp_area {
            get {
                return ResourceManager.GetString("epsp-area", resourceCulture);
            }
        }
        
        /// <summary>
        ///   型 System.Byte[] のローカライズされたリソースを検索します。
        /// </summary>
        internal static byte[] loading {
            get {
                object obj = ResourceManager.GetObject("loading", resourceCulture);
                return ((byte[])(obj));
            }
        }
        
        /// <summary>
        ///   (アイコン) に類似した型 System.Drawing.Icon のローカライズされたリソースを検索します。
        /// </summary>
        internal static System.Drawing.Icon p2pquake {
            get {
                object obj = ResourceManager.GetObject("p2pquake", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
    }
}
