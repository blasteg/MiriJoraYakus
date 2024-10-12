using MiriJoraYakus.Enums;

namespace MiriJoraYakus.Data
{
    public class UnitEvaluator
    {
        public string Name { get; set; } = String.Empty;
        public List<CardEnum> Idols { get; set; } = new List<CardEnum>();
        public  Dictionary<TypeEnum,int> TypeCount { get; set; }
            = new Dictionary<TypeEnum, int> { { TypeEnum.Princess, 0 },{ TypeEnum.Fairy,0},{ TypeEnum.Angel,0} };
        public int TotalCount = 0;
        public string Tags { get; set; }=String.Empty;
        public bool IsEnabled { get; set; } = true;

        public Dictionary<TypeEnum, int> TypeHave = new Dictionary<TypeEnum, int> { { TypeEnum.Princess, 0 }, { TypeEnum.Fairy, 0 }, { TypeEnum.Angel, 0 } };
        public int Have { get; set; } = 0;
        public int Gone { get; set; } = 0;
        public UnitEvaluator(UnitData data) 
        {
            Name = data.Name;
            Idols = data.Idols;
            TotalCount = data.TotalCount;
            TypeCount = data.TypeCount;
            Tags = data.Tags;
        }
    }
}
