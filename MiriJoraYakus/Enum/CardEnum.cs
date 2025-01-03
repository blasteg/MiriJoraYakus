﻿using MiriJoraYakus.Data;
using System.Runtime.Serialization;

namespace MiriJoraYakus.Enums
{
    public enum CardEnum
    {
        None,
        天海春香,
        如月千早,
        星井美希,
        萩原雪歩,
        高槻やよい,
        菊地真,
        水瀬伊織,
        四条貴音,
        秋月律子,
        三浦あずさ,
        双海亜美,
        双海真美,
        我那覇響,
        春日未来,
        最上静香,
        伊吹翼,
        田中琴葉,
        島原エレナ,
        佐竹美奈子,
        所恵美,
        徳川まつり,
        箱崎星梨花,
        野々原茜,
        望月杏奈,
        ロコ,
        七尾百合子,
        高山紗代子,
        松田亜利沙,
        高坂海美,
        中谷育,
        天空橋朋花,
        エミリー,
        北沢志保,
        舞浜歩,
        木下ひなた,
        矢吹可奈,
        横山奈緒,
        二階堂千鶴,
        馬場このみ,
        大神環,
        豊川風花,
        宮尾美也,
        福田のり子,
        真壁瑞希,
        篠宮可憐,
        百瀬莉緒,
        永吉昴,
        北上麗花,
        周防桃子,
        ジュリア,
        白石紬,
        桜守歌織,
        PrWC,
        FaWC,
        AnWC,
        AllWC
    }
    public static class Ext
    {
        public static TypeEnum Type(this CardEnum card)
        {
            return GlobalDatas.BaseIdolData.First(x => x.Idol == card).Type;
        }
    }
}
