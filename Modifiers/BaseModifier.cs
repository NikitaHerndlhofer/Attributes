namespace Attributes.Modifiers
{
    public abstract class BaseModifier<T>
    {
        public bool IsBaseModifier;
        public byte Order;

        public BaseModifier(bool isBaseModifier, byte order)
        {
            IsBaseModifier = isBaseModifier;
            Order = order;
        }

        public BaseModifier()
        {
        }

        public abstract T CalculateValue(T baseValue);
    }
}