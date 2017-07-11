using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaProvaProgetto.Model
{
    struct Money
    {
        private decimal _value;

        public Money(decimal value)
        {
            if (value < 0.0m)
                throw new ArgumentException("value < 0.0");
            _value = value;
        }

        private decimal Value
        {
            get
            {
                return _value;
            }
        }

        public static implicit operator Money(decimal value)
        {
            return new Money(value);
        }

        public static implicit operator decimal(Money m)
        {
            return m.Value;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Money))
            {
                if (obj is decimal)
                    return Value == (decimal)obj;
                else
                    return false;
            }
            var other = (Money)obj;
            return Equals(other);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override string ToString()
        {
            return Value.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
