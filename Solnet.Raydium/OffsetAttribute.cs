using System;

namespace Solnet.Raydium
{
    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public sealed class OffsetAttribute : Attribute
    {
        public OffsetAttribute(int offset)
        {
            Value = offset;
        }

        public int Value { get; }
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public sealed class DecodeAttribute : Attribute
    {
        public DecodeAttribute()
        {
            
        }        
    }
}
