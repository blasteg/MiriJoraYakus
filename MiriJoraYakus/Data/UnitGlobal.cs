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
        };
    }
}
