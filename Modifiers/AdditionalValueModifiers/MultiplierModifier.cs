
namespace Attributes.Modifiers.AdditionalValueModifiers
{
    public class MultiplierModifier : BaseModifier<float>
    {
        public float MultiplierValue;
        
        public MultiplierModifier()
        {
            Order = 2;
            MultiplierValue = default;
        }
        public override float CalculateValue(float baseValue)
        {
            return MultiplierValue * baseValue;
        }
    }
}