namespace Attributes.Modifiers.AdditionalValueModifiers
{
    public class AdditionModifier : BaseModifier<float>
    {
        public float AdditionValue;

        public AdditionModifier(float additionValue)
        {
            AdditionValue = additionValue;
        }

        public AdditionModifier()
        {
            AdditionValue = default;
        }

        public override float CalculateValue(float baseValue)
        {
            return AdditionValue;
        }
    }
}