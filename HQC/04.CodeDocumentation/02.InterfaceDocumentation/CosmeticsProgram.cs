using System.Globalization;
using System.Threading;

namespace Cosmetics
{
    using Engine;

    public class CosmeticsProgram
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            CosmeticsEngine.Instance.Start();
        }
    }
}
