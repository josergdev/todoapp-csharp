namespace josergdev.Todo.Shared.Domain.ValueObject
{
    using System;
    using System.Collections.Generic;
    public class BoolValueObject : ValueObject
    {
        public bool Value { get; }

        public BoolValueObject(bool value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;

            var item = obj as BoolValueObject;
            if (item == null) return false;

            return Value == item.Value;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value);
        }
    }
}
