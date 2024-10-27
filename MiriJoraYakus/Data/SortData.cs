using MiriJoraYakus.Enums;

namespace MiriJoraYakus.Data
{
    public class SortData
    {
        public string sortName { get; set; } = string.Empty;
        public CardEnum[] sorting { get; set; } = Array.Empty<CardEnum>();
    }
    public static partial class GlobalDatas
    {
        public static Dictionary<string, CardEnum[]> sortMethods = new Dictionary<string, CardEnum[]>
        {
            {"アイドル順", new CardEnum[]{CardEnum.天海春香,CardEnum.如月千早,CardEnum.星井美希,CardEnum.萩原雪歩,CardEnum.高槻やよい,CardEnum.菊地真,CardEnum.水瀬伊織,CardEnum.四条貴音,CardEnum.秋月律子,CardEnum.三浦あずさ,CardEnum.双海亜美,CardEnum.双海真美,CardEnum.我那覇響,CardEnum.春日未来,CardEnum.最上静香,CardEnum.伊吹翼,CardEnum.田中琴葉,CardEnum.島原エレナ,CardEnum.佐竹美奈子,CardEnum.所恵美,CardEnum.徳川まつり,CardEnum.箱崎星梨花,CardEnum.野々原茜,CardEnum.望月杏奈,CardEnum.ロコ,CardEnum.七尾百合子,CardEnum.高山紗代子,CardEnum.松田亜利沙,CardEnum.高坂海美,CardEnum.中谷育,CardEnum.天空橋朋花,CardEnum.エミリー,CardEnum.北沢志保,CardEnum.舞浜歩,CardEnum.木下ひなた,CardEnum.矢吹可奈,CardEnum.横山奈緒,CardEnum.二階堂千鶴,CardEnum.馬場このみ,CardEnum.大神環,CardEnum.豊川風花,CardEnum.宮尾美也,CardEnum.福田のり子,CardEnum.真壁瑞希,CardEnum.篠宮可憐,CardEnum.百瀬莉緒,CardEnum.永吉昴,CardEnum.北上麗花,CardEnum.周防桃子,CardEnum.ジュリア,CardEnum.白石紬,CardEnum.桜守歌織, CardEnum.PrWC, CardEnum.FaWC, CardEnum.AnWC, CardEnum.AllWC} } ,
            { "屬性順", new CardEnum[]{
            CardEnum.天海春香,
CardEnum.如月千早,
CardEnum.星井美希,
CardEnum.萩原雪歩,
CardEnum.高槻やよい,
CardEnum.菊地真,
CardEnum.水瀬伊織,
CardEnum.四条貴音,
CardEnum.秋月律子,
CardEnum.三浦あずさ,
CardEnum.双海亜美,
CardEnum.双海真美,
CardEnum.我那覇響,
CardEnum.春日未来,
CardEnum.田中琴葉,
CardEnum.佐竹美奈子,
CardEnum.徳川まつり,
CardEnum.七尾百合子,
CardEnum.高山紗代子,
CardEnum.松田亜利沙,
CardEnum.高坂海美,
CardEnum.中谷育,
CardEnum.エミリー,
CardEnum.矢吹可奈,
CardEnum.横山奈緒,
CardEnum.福田のり子,
CardEnum.最上静香,
CardEnum.所恵美,
CardEnum.ロコ,
CardEnum.天空橋朋花,
CardEnum.北沢志保,
CardEnum.舞浜歩,
CardEnum.二階堂千鶴,
CardEnum.真壁瑞希,
CardEnum.百瀬莉緒,
CardEnum.永吉昴,
CardEnum.周防桃子,
CardEnum.ジュリア,
CardEnum.白石紬,
CardEnum.伊吹翼,
CardEnum.島原エレナ,
CardEnum.箱崎星梨花,
CardEnum.野々原茜,
CardEnum.望月杏奈,
CardEnum.木下ひなた,
CardEnum.馬場このみ,
CardEnum.大神環,
CardEnum.豊川風花,
CardEnum.宮尾美也,
CardEnum.篠宮可憐,
CardEnum.北上麗花,
CardEnum.桜守歌織, CardEnum.PrWC, CardEnum.FaWC, CardEnum.AnWC, CardEnum.AllWC
            } }
        };
    }
}
