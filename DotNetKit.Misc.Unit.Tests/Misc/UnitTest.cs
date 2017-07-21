using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DotNetKit.Misc
{
    public sealed class UnitTest
    {
        [Fact]
        public void Test_Equality()
        {
            Assert.True(EqualityComparer<object>.Default.Equals(Unit.Instance, default(Unit)));
            Assert.True(EqualityComparer<Unit>.Default.Equals(Unit.Instance, default(Unit)));
            Assert.Equal(Unit.Instance, default(Unit));
            Assert.True(Unit.Instance == default(Unit));
            Assert.False(Unit.Instance != default(Unit));
            Assert.Equal(Unit.Instance.GetHashCode(), default(Unit).GetHashCode());
        }

        [Fact]
        public void Test_Comparison()
        {
            var comparer = Comparer<object>.Default;

            Assert.Equal(0, comparer.Compare(Unit.Instance, default(Unit)));

            // Unit.Instance is greater than null.
            Assert.True(comparer.Compare(null, Unit.Instance) < 0);
            Assert.True(comparer.Compare(Unit.Instance, null) > 0);

            // Can't compare unit and non-unit values.
            Assert.Throws<InvalidOperationException>(() => comparer.Compare(Unit.Instance, 0));
            Assert.Throws<InvalidOperationException>(() => comparer.Compare(Unit.Instance, new object()));
        }
    }
}
