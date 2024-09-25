using System.Collections.Generic;
using System.Reflection;

namespace Solnet.Raydium.Models.Layouts
{
    public abstract class BaseLayout
    {
        public abstract Dictionary<PropertyInfo, int> GetOffsets();
    }
}
