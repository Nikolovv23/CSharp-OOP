using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string investigatedClass , 
            params string[] requestedFields)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] classFields = classType.GetFields(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static
                | BindingFlags.NonPublic);
            StringBuilder  sb = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] {});

            sb.AppendLine($"Class under investigation: {investigatedClass}");

            foreach ( var field in classFields.Where(f => requestedFields.Contains(f.Name))) 
            {
                sb.AppendLine($"{field.Name} - {field.GetValue(classInstance)}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
