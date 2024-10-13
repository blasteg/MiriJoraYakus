using MiriJoraYakus.Enums;

namespace MiriJoraYakus.Data
{
    public static partial class GlobalDatas
    {

        public static List<UnitData> BaseUnitData = new List<UnitData>
        {
            new UnitData(
                new List<CardEnum>{CardEnum.天海春香,CardEnum.如月千早,CardEnum.星井美希,CardEnum.萩原雪歩,CardEnum.高槻やよい,CardEnum.菊地真,CardEnum.水瀬伊織,CardEnum.四条貴音,CardEnum.秋月律子,CardEnum.三浦あずさ,CardEnum.双海亜美,CardEnum.双海真美,CardEnum.我那覇響 }
                ,"765 Pro Allstars", "Generic"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.田中琴葉, CardEnum.佐竹美奈子, CardEnum.徳川まつり, CardEnum.七尾百合子, CardEnum.高山紗代子, CardEnum.松田亜利沙, CardEnum.高坂海美, CardEnum.中谷育, CardEnum.エミリー, CardEnum.矢吹可奈, CardEnum.横山奈緒, CardEnum.福田のり子 }
                 ,"Princess Stars","Generic"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.最上静香, CardEnum.所恵美, CardEnum.ロコ, CardEnum.天空橋朋花, CardEnum.北沢志保, CardEnum.舞浜歩, CardEnum.二階堂千鶴, CardEnum.真壁瑞希, CardEnum.百瀬莉緒, CardEnum.永吉昴, CardEnum.周防桃子, CardEnum.ジュリア, CardEnum.白石紬 }
                 ,"Fairy Stars","Generic"),
            new UnitData(
                 new List<CardEnum>{CardEnum.伊吹翼, CardEnum.島原エレナ, CardEnum.箱崎星梨花, CardEnum.野々原茜, CardEnum.望月杏奈, CardEnum.木下ひなた, CardEnum.馬場このみ, CardEnum.大神環, CardEnum.豊川風花, CardEnum.宮尾美也, CardEnum.篠宮可憐, CardEnum.北上麗花, CardEnum.桜守歌織 }
                 ,"Angel Stars","Generic"),
            #region LTP
            new UnitData(
                 new List<CardEnum>{ CardEnum.天海春香, CardEnum.最上静香, CardEnum.箱崎星梨花, CardEnum.七尾百合子, CardEnum.天空橋朋花 }
                 ,"Legend Girls!!","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.我那覇響, CardEnum.春日未来, CardEnum.望月杏奈, CardEnum.横山奈緒, CardEnum.豊川風花 }
                 ,"PRETTY DREAMER","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.田中琴葉, CardEnum.所恵美, CardEnum.北沢志保, }
                 ,"Blue Symphony","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.水瀬伊織, CardEnum.エミリー, CardEnum.真壁瑞希, CardEnum.百瀬莉緒 }
                 ,"Sentimental Venus","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.伊吹翼, CardEnum.北上麗花, CardEnum.ジュリア }
                 ,"Marionetteは眠らない","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.三浦あずさ, CardEnum.高山紗代子, CardEnum.福田のり子, CardEnum.篠宮可憐 }
                 ,"カワラナイモノ","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.高槻やよい, CardEnum.中谷育, CardEnum.矢吹可奈, CardEnum.大神環 }
                 ,"Good-Sleep, Baby♡","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.秋月律子, CardEnum.佐竹美奈子, CardEnum.松田亜利沙, CardEnum.木下ひなた }
                 ,"Helloコンチェルト ","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.徳川まつり, CardEnum.高坂海美, CardEnum.宮尾美也 }
                 ,"瞳の中のシリウス ","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.菊地真, CardEnum.双海真美, CardEnum.島原エレナ, CardEnum.舞浜歩 }
                 ,"Fu-Wa-Du-Wa","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.萩原雪歩, CardEnum.ロコ, CardEnum.二階堂千鶴, CardEnum.周防桃子 }
                 ,"ココロがかえる場所","LTP"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.双海亜美, CardEnum.野々原茜, CardEnum.馬場このみ, CardEnum.永吉昴 }
                 ,"Bigバルーン◎","LTP"),
            #endregion
            #region LTH
            new UnitData(
                 new List<CardEnum>{ CardEnum.高槻やよい, CardEnum.水瀬伊織, CardEnum.秋月律子, CardEnum.双海亜美, CardEnum.我那覇響 }
                 ,"合言葉はスタートアップ！","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.伊吹翼, CardEnum.望月杏奈, CardEnum.七尾百合子, CardEnum.真壁瑞希 }
                 ,"Growing Storm!","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.最上静香, CardEnum.箱崎星梨花, CardEnum.野々原茜, CardEnum.北沢志保, CardEnum.北上麗花 }
                 ,"Shooting Stars","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.徳川まつり, CardEnum.エミリー, CardEnum.豊川風花, CardEnum.ジュリア }
                 ,"Eternal Harmony","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天海春香, CardEnum.松田亜利沙, CardEnum.横山奈緒, CardEnum.福田のり子, CardEnum.周防桃子 }
                 ,"HOME, SWEET FRIENDSHIP","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.田中琴葉, CardEnum.所恵美, CardEnum.高坂海美, CardEnum.大神環, CardEnum.宮尾美也 }
                 ,"ジレるハートに火をつけて","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.萩原雪歩, CardEnum.菊地真, CardEnum.三浦あずさ, CardEnum.舞浜歩, CardEnum.矢吹可奈 }
                 ,"Birth of Color","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.双海真美, CardEnum.佐竹美奈子, CardEnum.中谷育, CardEnum.木下ひなた, CardEnum.馬場このみ }
                 ,"ドリームトラベラー","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.高山紗代子, CardEnum.天空橋朋花, CardEnum.二階堂千鶴, CardEnum.永吉昴 }
                 ,"星屑のシンフォニア","LTH"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.島原エレナ, CardEnum.ロコ, CardEnum.篠宮可憐, CardEnum.百瀬莉緒 }
                 ,"STANDING ALIVE","LTH"),
            #endregion
            #region LTD
            new UnitData(
                 new List<CardEnum>{CardEnum.天海春香, CardEnum.春日未来 }
                 ,"ハルカナミライ","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.望月杏奈, CardEnum.七尾百合子 }
                 ,"成長Chu→LOVER!!","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.所恵美, CardEnum.ジュリア }
                 ,"エスケープ","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.高槻やよい, CardEnum.矢吹可奈 }
                 ,"Eternal Spiral","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.北沢志保, CardEnum.北上麗花 }
                 ,"piece of cake","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.最上静香 }
                 ,"アライブファクター","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.萩原雪歩, CardEnum.二階堂千鶴 }
                 ,"Persona Voice","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.真壁瑞希, CardEnum.二階堂千鶴 }
                 ,"Cut. Cut. Cut.","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.箱崎星梨花, CardEnum.宮尾美也 }
                 ,"Smiling Crescent","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.徳川まつり, CardEnum.馬場このみ }
                 ,"Decided","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.我那覇響, CardEnum.伊吹翼 }
                 ,"深層マーメイド","LTD"),
            new UnitData(
                 new List<CardEnum>{CardEnum.中谷育, CardEnum.天空橋朋花 }
                 ,"HELLO, YOUR ANGEL♪","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.秋月律子, CardEnum.篠宮可憐 }
                 ,"G♡F","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.水瀬伊織, CardEnum.エミリー }
                 ,"little trip around the world","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.佐竹美奈子, CardEnum.高山紗代子 }
                 ,"Melody in scape","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.双海亜美, CardEnum.木下ひなた}
                 ,"”Your” HOME TOWN","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.野々原茜, CardEnum.ロコ }
                 ,"fruity love","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.松田亜利沙, CardEnum.横山奈緒 }
                 ,"夜に輝く星座のように","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.百瀬莉緒 }
                 ,"秘密のメモリーズ","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.三浦あずさ, CardEnum.豊川風花 }
                 ,"たしかな足跡","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.田中琴葉, CardEnum.高坂海美 }
                 ,"Understand? Understand!","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.双海真美, CardEnum.大神環 }
                 ,"ジャングル☆パーティー","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.菊地真, CardEnum.舞浜歩 }
                 ,"Beat the World!!","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.島原エレナ }
                 ,"Emergence Vibe","LTD"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.福田のり子, CardEnum.永吉昴}
                 ,"Dreamscape","LTD"),
            #endregion
            #region TA
            new UnitData(
                 new List<CardEnum>{ CardEnum.箱崎星梨花, CardEnum.ロコ, CardEnum.七尾百合子, CardEnum.松田亜利沙, CardEnum.天空橋朋花 }
                 ,"創造は始まりの風を連れて","TA"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.木下ひなた, CardEnum.大神環, CardEnum.福田のり子, CardEnum.周防桃子, CardEnum.ジュリア }
                 ,"俠気乱舞","TA"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.佐竹美奈子, CardEnum.矢吹可奈, CardEnum.真壁瑞希, CardEnum.篠宮可憐, CardEnum.北上麗花 }
                 ,"赤い世界が消える頃","TA"),
            #endregion
            #region LTF
            new UnitData(
                 new List<CardEnum>{ CardEnum.エミリー, CardEnum.木下ひなた, CardEnum.横山奈緒 }
                 ,"キャンサー","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.島原エレナ, CardEnum.ロコ, CardEnum.中谷育 }
                 ,"レオ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.伊吹翼, CardEnum.佐竹美奈子, CardEnum.福田のり子 }
                 ,"リブラ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.望月杏奈, CardEnum.矢吹可奈, CardEnum.百瀬莉緒 }
                 ,"カプリコーン","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.エミリー, CardEnum.木下ひなた, CardEnum.横山奈緒, CardEnum.島原エレナ, CardEnum.ロコ, CardEnum.中谷育, CardEnum.伊吹翼, CardEnum.佐竹美奈子, CardEnum.福田のり子, CardEnum.望月杏奈, CardEnum.矢吹可奈, CardEnum.百瀬莉緒, CardEnum.桜守歌織 }
                 ,"Sunshine Rhythm","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.所恵美, CardEnum.舞浜歩, CardEnum.真壁瑞希 }
                 ,"サジタリアス ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天空橋朋花, CardEnum.二階堂千鶴, CardEnum.篠宮可憐 }
                 ,"ピスケス ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.最上静香, CardEnum.七尾百合子, CardEnum.永吉昴 }
                 ,"ウィルゴ ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.高山紗代子, CardEnum.北上麗花, CardEnum.ジュリア }
                 ,"アクアリウス ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.所恵美, CardEnum.舞浜歩, CardEnum.真壁瑞希, CardEnum.天空橋朋花, CardEnum.二階堂千鶴, CardEnum.篠宮可憐, CardEnum.最上静香, CardEnum.七尾百合子, CardEnum.永吉昴, CardEnum.高山紗代子, CardEnum.北上麗花, CardEnum.ジュリア, CardEnum.白石紬 }
                 ,"BlueMoon Harmony","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.田中琴葉, CardEnum.松田亜利沙, CardEnum.高坂海美, CardEnum.北沢志保 }
                 ,"スコーピオ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.箱崎星梨花, CardEnum.野々原茜, CardEnum.大神環 }
                 ,"アリエス ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.徳川まつり, CardEnum.宮尾美也 }
                 ,"タウラス ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.馬場このみ, CardEnum.豊川風花, CardEnum.周防桃子 }
                 ,"ジェミニ ","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.松田亜利沙, CardEnum.高坂海美, CardEnum.北沢志保, CardEnum.箱崎星梨花, CardEnum.野々原茜, CardEnum.大神環, CardEnum.春日未来, CardEnum.徳川まつり, CardEnum.宮尾美也, CardEnum.馬場このみ, CardEnum.豊川風花, CardEnum.周防桃子, CardEnum.田中琴葉}
                 ,"Starlight Melody","LTF"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.白石紬, CardEnum.桜守歌織 }
                 ,"オフィウクス","LTF"),
            #endregion
            #region MTG
            new UnitData(
                 new List<CardEnum>{ CardEnum.伊吹翼, CardEnum.高坂海美 }
                 ,"マイティーセーラーズ","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.所恵美, CardEnum.天空橋朋花, CardEnum.二階堂千鶴, CardEnum.百瀬莉緒 }
                 ,"夜想令嬢","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.島原エレナ, CardEnum.宮尾美也 }
                 ,"Cleasky","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.七尾百合子, CardEnum.松田亜利沙, CardEnum.中谷育 }
                 ,"トゥインクルリズム","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.北沢志保, CardEnum.真壁瑞希, CardEnum.白石紬 }
                 ,"EScape","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.馬場このみ, CardEnum.豊川風花, CardEnum.北上麗花, CardEnum.桜守歌織 }
                 ,"4 Luxury","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.佐竹美奈子, CardEnum.高山紗代子, CardEnum.高坂海美, CardEnum.横山奈緒, CardEnum.福田のり子 }
                 ,"閃光☆HANABI団","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.最上静香, CardEnum.ジュリア }
                 ,"D/Zeal","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.伊吹翼, CardEnum.野々原茜, CardEnum.篠宮可憐 }
                 ,"るきゃん ～3 little candy～","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.徳川まつり, CardEnum.エミリー }
                 ,"Charlotte・Charlotte","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.ロコ, CardEnum.舞浜歩, CardEnum.永吉昴, CardEnum.周防桃子 }
                 ,"Jelly PoP Beans","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.箱崎星梨花, CardEnum.望月杏奈, CardEnum.木下ひなた, CardEnum.大神環 }
                 ,"ピコピコプラネッツ","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.田中琴葉, CardEnum.矢吹可奈 }
                 ,"STAR ELEMENTS","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.最上静香, CardEnum.所恵美, CardEnum.北沢志保, CardEnum.ジュリア, CardEnum.白石紬 }
                 ,"FairyTaleじゃいられない","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.伊吹翼, CardEnum.箱崎星梨花, CardEnum.望月杏奈, CardEnum.北上麗花, CardEnum.桜守歌織 }
                 ,"Angelic Parade♪","MTG"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.徳川まつり, CardEnum.七尾百合子, CardEnum.エミリー, CardEnum.矢吹可奈 }
                 ,"Princess Be Ambitious!!","MTG"),
            #endregion
            #region TB 
            new UnitData(
                 new List<CardEnum>{ CardEnum.所恵美, CardEnum.高山紗代子, CardEnum.高坂海美, CardEnum.横山奈緒, CardEnum.豊川風花 }
                 ,"ビッグバンズバリボー!!!!!","TB"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.最上静香, CardEnum.望月杏奈, CardEnum.宮尾美也, CardEnum.百瀬莉緒, CardEnum.桜守歌織 }
                 ,"オーディナリィ・クローバー","TB"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.田中琴葉, CardEnum.馬場このみ, CardEnum.真壁瑞希, CardEnum.周防桃子, CardEnum.白石紬 }
                 ,"ラスト・アクトレス","TB"),
            #endregion
            #region MTW 
            new UnitData(
                 new List<CardEnum>{ CardEnum.菊地真, CardEnum.野々原茜, CardEnum.ジュリア, CardEnum.白石紬, CardEnum.桜守歌織 }
                 ,"ジェネシス×ネメシス","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.二階堂千鶴, CardEnum.馬場このみ, CardEnum.豊川風花, CardEnum.百瀬莉緒, CardEnum.桜守歌織 }
                 ,"White Vows","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.望月杏奈, CardEnum.ロコ, CardEnum.七尾百合子, CardEnum.真壁瑞希, CardEnum.永吉昴 }
                 ,"Chrono-Lexica","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.萩原雪歩, CardEnum.菊地真, CardEnum.水瀬伊織 }
                 ,"Xs","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.馬場このみ, CardEnum.百瀬莉緒 }
                 ,"Sherry 'n Cherry","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.四条貴音, CardEnum.三浦あずさ }
                 ,"ARCANA","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天空橋朋花, CardEnum.エミリー, CardEnum.白石紬 }
                 ,"花咲夜","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.佐竹美奈子, CardEnum.横山奈緒 }
                 ,"Jus-2-Mint","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.島原エレナ, CardEnum.高坂海美, CardEnum.舞浜歩, CardEnum.福田のり子 }
                 ,"miraclesonic★expassion","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.箱崎星梨花, CardEnum.木下ひなた, CardEnum.宮尾美也, CardEnum.篠宮可憐 }
                 ,"Fleuranges","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.伊吹翼, CardEnum.七尾百合子, CardEnum.天空橋朋花, CardEnum.エミリー, CardEnum.永吉昴 }
                 ,"Do the Idol!! ～断崖絶壁チュパカブラ～","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.田中琴葉, CardEnum.徳川まつり, CardEnum.北沢志保, CardEnum.桜守歌織 }
                 ,"オペラセリア・煌輝座","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天海春香, CardEnum.高槻やよい, CardEnum.我那覇響 }
                 ,"ダイヤモンドダイバー◇","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.中谷育, CardEnum.大神環, CardEnum.周防桃子 }
                 ,"TIntMe!","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.野々原茜, CardEnum.北上麗花 }
                 ,"TRICK&TREAT","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.高山紗代子, CardEnum.二階堂千鶴, CardEnum.豊川風花, CardEnum.ジュリア }
                 ,"chicAAmor","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.所恵美, CardEnum.松田亜利沙, CardEnum.矢吹可奈 }
                 ,"≡君彩≡","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.秋月律子, CardEnum.双海亜美, CardEnum.双海真美 }
                 ,"ARMooo","MTW"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.最上静香, CardEnum.伊吹翼 }
                 ,"ストロベリーポップムーン","MTW"),
            #endregion
            #region TC 
            new UnitData(
                 new List<CardEnum>{ CardEnum.我那覇響, CardEnum.徳川まつり, CardEnum.箱崎星梨花, CardEnum.永吉昴, CardEnum.周防桃子 }
                 ,"Girl meets Wonder","TC"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天海春香, CardEnum.如月千早, CardEnum.星井美希, CardEnum.菊地真, CardEnum.エミリー }
                 ,"World Changer","TC"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.島原エレナ, CardEnum.野々原茜, CardEnum.北沢志保, CardEnum.二階堂千鶴, CardEnum.桜守歌織 }
                 ,"クルリウタ","TC"),
            #endregion
            #region MTS 
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.伊吹翼, CardEnum.所恵美, CardEnum.徳川まつり }
                 ,"DIAMOND JOKER","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.萩原雪歩, CardEnum.双海真美, CardEnum.田中琴葉, CardEnum.百瀬莉緒 }
                 ,"真夏のダイヤ☆","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.水瀬伊織, CardEnum.春日未来, CardEnum.宮尾美也, CardEnum.周防桃子, CardEnum.桜守歌織 }
                 ,"シークレットジュエル 〜魅惑の金剛石〜","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.伊吹翼, CardEnum.所恵美, CardEnum.徳川まつり, CardEnum.萩原雪歩, CardEnum.双海真美, CardEnum.田中琴葉, CardEnum.百瀬莉緒, CardEnum.水瀬伊織, CardEnum.春日未来, CardEnum.宮尾美也, CardEnum.周防桃子, CardEnum.桜守歌織 }
                 ,"BRIGHT DIAMOND","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.三浦あずさ, CardEnum.箱崎星梨花, CardEnum.ロコ, CardEnum.高坂海美 }
                 ,"産声とクラブ","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.菊地真, CardEnum.島原エレナ, CardEnum.二階堂千鶴, CardEnum.真壁瑞希 }
                 ,"トレフル・ド・ノエル","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.秋月律子, CardEnum.木下ひなた, CardEnum.横山奈緒, CardEnum.馬場このみ, CardEnum.大神環 }
                 ,"Clover's Cry 〜神と神降ろしの少女〜","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.三浦あずさ, CardEnum.箱崎星梨花, CardEnum.ロコ, CardEnum.高坂海美, CardEnum.菊地真, CardEnum.島原エレナ, CardEnum.二階堂千鶴, CardEnum.真壁瑞希, CardEnum.秋月律子, CardEnum.木下ひなた, CardEnum.横山奈緒, CardEnum.馬場このみ, CardEnum.大神環 }
                 ,"CLEVER CLOVER","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.高槻やよい, CardEnum.佐竹美奈子, CardEnum.七尾百合子, CardEnum.天空橋朋花 }
                 ,"LOVE is GAME","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.高山紗代子, CardEnum.松田亜利沙, CardEnum.福田のり子, CardEnum.北上麗花 }
                 ,"紙・心・ペン・心 - SHISHINPENSHIN -","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天海春香, CardEnum.望月杏奈, CardEnum.矢吹可奈, CardEnum.ジュリア }
                 ,"CHEER UP! HEARTS UP!","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.高槻やよい, CardEnum.佐竹美奈子, CardEnum.七尾百合子, CardEnum.天空橋朋花, CardEnum.如月千早, CardEnum.高山紗代子, CardEnum.松田亜利沙, CardEnum.福田のり子, CardEnum.北上麗花, CardEnum.天海春香, CardEnum.望月杏奈, CardEnum.矢吹可奈, CardEnum.ジュリア }
                 ,"LOVERS HEART","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.最上静香, CardEnum.中谷育, CardEnum.舞浜歩, CardEnum.篠宮可憐 }
                 ,"Criminally Dinner ～正餐とイーヴルナイフ～","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.双海亜美, CardEnum.エミリー, CardEnum.北沢志保, CardEnum.永吉昴 }
                 ,"スペードのQ","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.我那覇響, CardEnum.野々原茜, CardEnum.豊川風花, CardEnum.白石紬 }
                 ,"KING of SPADE","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.最上静香, CardEnum.中谷育, CardEnum.舞浜歩, CardEnum.篠宮可憐, CardEnum.双海亜美, CardEnum.エミリー, CardEnum.北沢志保, CardEnum.永吉昴, CardEnum.我那覇響, CardEnum.野々原茜, CardEnum.豊川風花, CardEnum.白石紬 }
                 ,"SHADE OF SPADE","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.萩原雪歩, CardEnum.水瀬伊織, CardEnum.菊地真, CardEnum.伊吹翼, CardEnum.田中琴葉, CardEnum.徳川まつり, CardEnum.箱崎星梨花, CardEnum.ロコ, CardEnum.横山奈緒, CardEnum.二階堂千鶴, CardEnum.大神環, CardEnum.宮尾美也, CardEnum.周防桃子 }
                 ,"RisingLight","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.高槻やよい, CardEnum.秋月律子, CardEnum.三浦あずさ, CardEnum.島原エレナ, CardEnum.望月杏奈, CardEnum.木下ひなた, CardEnum.七尾百合子, CardEnum.高坂海美, CardEnum.馬場このみ, CardEnum.真壁瑞希, CardEnum.北上麗花, CardEnum.ジュリア }
                 ,"ShineLight","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天海春香, CardEnum.星井美希, CardEnum.我那覇響, CardEnum.佐竹美奈子, CardEnum.高山紗代子, CardEnum.松田亜利沙, CardEnum.天空橋朋花, CardEnum.北沢志保, CardEnum.舞浜歩, CardEnum.矢吹可奈, CardEnum.福田のり子, CardEnum.永吉昴, CardEnum.白石紬 }
                 ,"EmotionLight","MTS"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.双海亜美, CardEnum.双海真美, CardEnum.春日未来, CardEnum.最上静香, CardEnum.所恵美, CardEnum.野々原茜, CardEnum.中谷育, CardEnum.エミリー, CardEnum.豊川風花, CardEnum.篠宮可憐, CardEnum.百瀬莉緒, CardEnum.桜守歌織 }
                 ,"FantasticLight","MTS"),
            #endregion
            #region ASTROLOGIA
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.高槻やよい, CardEnum.秋月律子, CardEnum.双海亜美, CardEnum.双海真美 }
                 ,"ソル","ASTROLOGIA"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.菊地真, CardEnum.三浦あずさ, CardEnum.我那覇響 }
                 ,"ルナ","ASTROLOGIA"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.天海春香, CardEnum.萩原雪歩, CardEnum.水瀬伊織, CardEnum.四条貴音 }
                 ,"ステラ","ASTROLOGIA"),
            #endregion

            #region MTV 
            new UnitData(
                 new List<CardEnum>{ CardEnum.我那覇響, CardEnum.佐竹美奈子, CardEnum.中谷育, CardEnum.舞浜歩, CardEnum.篠宮可憐, }
                 ,"ワールド・アスレチック・COOK-KING ～勝者必食！？スポ食の秋～","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.所恵美, CardEnum.野々原茜, CardEnum.望月杏奈, CardEnum.高山紗代子 }
                 ,"ショコラブル＊イブ","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.三浦あずさ, CardEnum.徳川まつり, CardEnum.大神環, CardEnum.福田のり子, CardEnum.白石紬 }
                 ,"Vacation VS Summer ～ナツとヤスミのアンビバレント！～","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.双海真美, CardEnum.伊吹翼, CardEnum.天空橋朋花, CardEnum.矢吹可奈, CardEnum.北上麗花 }
                 ,"ミスティック・セレモニーへの招待状","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.萩原雪歩, CardEnum.菊地真, CardEnum.最上静香, CardEnum.福田のり子, CardEnum.永吉昴 }
                 ,"春風満帆スターティング","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.如月千早, CardEnum.徳川まつり, CardEnum.天空橋朋花, CardEnum.木下ひなた, CardEnum.馬場このみ }
                 ,"リベレイシング／アロン -LiberaSing Along-","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.我那覇響, CardEnum.高坂海美, CardEnum.横山奈緒, CardEnum.宮尾美也, CardEnum.真壁瑞希 }
                 ,"夢みがちBride","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.三浦あずさ, CardEnum.二階堂千鶴, CardEnum.豊川風花, CardEnum.北上麗花 }
                 ,"カンパリーナ♡","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.水瀬伊織, CardEnum.高山紗代子, CardEnum.舞浜歩, CardEnum.百瀬莉緒, CardEnum.永吉昴 }
                 ,"Dance in the Light","MTV"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.星井美希, CardEnum.高槻やよい, CardEnum.望月杏奈, CardEnum.木下ひなた, CardEnum.ジュリア }
                 ,"はぴ！やば！まいまいんど！","MTV"),
            #endregion
            #region MCA 
            new UnitData(
                 new List<CardEnum>{ CardEnum.四条貴音, CardEnum.中谷育, CardEnum.馬場このみ, CardEnum.真壁瑞希, CardEnum.周防桃子 }
                 ,"解夏傀儡","MCA"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.伊吹翼, CardEnum.箱崎星梨花, CardEnum.ロコ, CardEnum.舞浜歩, CardEnum.北上麗花 }
                 ,"エンダーエンダー","MCA"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.田中琴葉, CardEnum.七尾百合子, CardEnum.北沢志保, CardEnum.豊川風花 }
                 ,"ミステイク・マーダー！","MCA"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.菊地真, CardEnum.水瀬伊織, CardEnum.最上静香, CardEnum.松田亜利沙, CardEnum.矢吹可奈 }
                 ,"銀のテーブル木苺ジャム","MCA"),
            #endregion
            #region Comic 
            new UnitData(
                 new List<CardEnum>{ CardEnum.伊吹翼, CardEnum.真壁瑞希, CardEnum.ジュリア }
                 ,"アイル ","Comic"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.最上静香, CardEnum.箱崎星梨花, CardEnum.野々原茜, CardEnum.北沢志保, CardEnum.北上麗花 }
                 ,"Flooding","Comic"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.箱崎星梨花, CardEnum.高坂海美, CardEnum.北沢志保, CardEnum.矢吹可奈 }
                 ,"Clover","Comic"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.七尾百合子, CardEnum.馬場このみ, CardEnum.周防桃子 }
                 ,"FleurS","Comic"),
            #endregion
            #region Anime
            new UnitData(
                 new List<CardEnum>{ CardEnum.佐竹美奈子, CardEnum.望月杏奈, CardEnum.天空橋朋花, CardEnum.北沢志保 }
                 ,"Team1st","Anime"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.高坂海美, CardEnum.福田のり子, CardEnum.真壁瑞希, CardEnum.篠宮可憐, CardEnum.百瀬莉緒 }
                 ,"Team2nd","Anime"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.田中琴葉, CardEnum.所恵美, CardEnum.七尾百合子, CardEnum.大神環, CardEnum.豊川風花 }
                 ,"Team3rd ","Anime"),
            //new UnitData(
            //     new List<CardEnum>{ CardEnum.ロコ, CardEnum.松田亜利沙, CardEnum.横山奈緒, CardEnum.二階堂千鶴, CardEnum.馬場このみ, CardEnum.周防桃子 }
            //     ,"Team4th","Anime"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.箱崎星梨花, CardEnum.野々原茜, CardEnum.高山紗代子, CardEnum.中谷育, CardEnum.宮尾美也 }
                 ,"Team5th","Anime"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.島原エレナ, CardEnum.徳川まつり, CardEnum.エミリー, CardEnum.木下ひなた, CardEnum.永吉昴 }
                 ,"Team6th","Anime"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.舞浜歩, CardEnum.矢吹可奈, CardEnum.北上麗花, CardEnum.ジュリア }
                 ,"Team7th","Anime"),
            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.最上静香, CardEnum.伊吹翼, CardEnum.白石紬, CardEnum.桜守歌織 }
                 ,"Team8th","Anime"),
            #endregion

            new UnitData(
                 new List<CardEnum>{ CardEnum.春日未来, CardEnum.最上静香, CardEnum.箱崎星梨花 }
                 ,"MILLION RADIO!","Other"),
        };
    }
}
