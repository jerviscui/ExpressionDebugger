using System;

namespace ExpressionDebugger
{
    public class PropertyDefinitions
    {
        public Type Type { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
        public bool IsReadOnly { get; set; }

        public bool NullableReference { get; set; }
    }
}
