using System.Diagnostics.Metrics;

namespace ValidationAttributes.Attributes
{
    public class MyRequiredattribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            return obj != null;
        }
    }
}
