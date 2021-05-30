namespace CharacterAttributes
{
    public abstract class BaseModifier<T>
    {
        public readonly bool IsBaseModifier;
        public readonly byte Order;

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