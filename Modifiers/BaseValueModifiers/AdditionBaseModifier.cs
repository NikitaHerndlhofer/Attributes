namespace Attributes.Modifiers.BaseValueModifiers
{
    public class AdditionBaseModifier : BaseModifier<float>
    {
        public float AdditionValue;

        public AdditionBaseModifier()
        {
            Order = 0;
        }
        public override float CalculateValue(float baseValue)
        {
            return AdditionValue + baseValue;
        }
    }
}