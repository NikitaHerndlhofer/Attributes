using System;
using Attributes.Attributes;
using UnityEngine;

namespace Attributes.ResourceAttributes
{
    [Serializable]
    public class FloatResource
    {
        [SerializeField]
        public FloatAttribute maxValue;
        [SerializeField]
        public float currentValue;

        public FloatResource() : this(0)
        {}

        public FloatResource(float value)
        {
            maxValue = new FloatAttribute(value);
            currentValue = value;
        }
    }
}