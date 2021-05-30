using System;
using System.Collections.Generic;
using System.Linq;

namespace CharacterAttributes
{
    [Serializable]
    public class FloatAttribute
    {
        public float baseValue;
        public float addedValue;
        /// <summary>
        /// To make changes here use the classes ApplyModifier() and RemoveModifier() methods.
        /// </summary>
        public readonly List<BaseModifier<float>> Modifiers;
        public bool isDirty;
        public float finalValue;

        public float FinalValue
        {
            get
            {
                if (isDirty)
                {
                    CalculateFinalValue();
                }

                return finalValue;
            }
        }

        public FloatAttribute(float baseValue)
        {
            this.baseValue = baseValue;
            isDirty = false;
            Modifiers = new List<BaseModifier<float>>();
        }
        
        public FloatAttribute() : this(0)
        {}
        
        public void ApplyModifier(BaseModifier<float> mod)
        {
            isDirty = true;
            Modifiers.Add(mod);
        }
        public bool RemoveModifier(BaseModifier<float> mod)
        {
            if (!Modifiers.Remove(mod)) return false;
            isDirty = true;
            return true;

        }

        protected virtual float CalculateFinalValue()
        {
            addedValue = default;
            var initialBaseValue = baseValue;
            foreach (var modifier in Modifiers.OrderByDescending(x => x.IsBaseModifier).ThenBy(x => x.Order))
            {
                if (modifier.IsBaseModifier)
                    baseValue = modifier.CalculateValue(initialBaseValue);
                else
                    addedValue += modifier.CalculateValue(baseValue);
            }

            isDirty = false;
            finalValue = baseValue + addedValue;
            return finalValue;
        }
    }

}