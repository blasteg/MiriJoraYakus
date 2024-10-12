using MiriJoraYakus.Enums;

namespace MiriJoraYakus.Data
{
    public class UnitData
    {
        public string Name { get; set; } = String.Empty;
        public List<CardEnum> Idols { get; set; } = new List<CardEnum>();
        public  Dictionary<TypeEnum,int> TypeCount { get; set; }
            = new Dictionary<TypeEnum, int> { { TypeEnum.Princess, 0 },{ TypeEnum.Fairy,0},{ TypeEnum.Angel,0} };
        public int TotalCount = 0;
        public UnitData(String name, List<CardEnum> cards) 
        {
            Name = name;
            Idols=cards;
            TotalCount = cards.Count();
            cards.ForEach(x => TypeCount[x.Type()]++);
        }
    }
}
