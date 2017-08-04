using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetKit.Misc
{
    /// <summary>
    /// Represents meaningless value.
    /// This type is useful as a type argument.
    /// </summary>
    public struct Unit
        : IEquatable<Unit>
        , IComparable
        , IComparable<Unit>
    {
        /// <summary>
        /// Gets the unit value.
        /// You can also use <c>default(Unit)</c>.
        /// </summary>
        public static Unit Instance => default(Unit);

        #region Equality
        /// <summary>
        /// Gets a value indicating whether two unit values are equal. Always <c>true</c>.
        /// </summary>
        public bool Equals(Unit other)
        {
            return true;
        }

        /// <summary>
        /// Gets a value indicating whether the specified value is the unit value.
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Unit;
        }

        /// <summary>
        /// Serves a hash code.
        /// </summary>
        public override int GetHashCode()
        {
            return 1;
        }

        /// <summary>
        /// Gets a value indicating whether two unit values are equal. Always <c>true</c>.
        /// </summary>
        public static bool operator ==(Unit left, Unit right)
        {
            return true;
        }

        /// <summary>
        /// Gets a value indicating whether two unit values are not equal. Always <c>false</c>.
        /// </summary>
        public static bool operator !=(Unit left, Unit right)
        {
            return false;
        }
        #endregion

        #region Comparison
        /// <summary>
        /// Compares a value to the unit value.
        /// Throws an exception if the value isn't unit.
        /// </summary>
        /// <exception cref="InvalidOperationException" />
        public int CompareTo(object obj)
        {
            if (obj is Unit) return 0;
            throw new InvalidOperationException("Unit can't be compared to non-unit values.");
        }

        /// <summary>
        /// Compares two unit values. Always equal.
        /// </summary>
        public int CompareTo(Unit other)
        {
            return 0;
        }
        #endregion
    }
}
