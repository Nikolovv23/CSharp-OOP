﻿using System.Reflection;
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
        public string AnalyzeAccessModifiers(string investigatedClass)
        {
            Type classType = Type.GetType(investigatedClass);
            FieldInfo[] fields = classType.GetFields(
                BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            MethodInfo[] publicMethods = classType.GetMethods(BindingFlags.Public | BindingFlags.Instance);
            MethodInfo[] NonpublicMethods = classType.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

            StringBuilder sb = new StringBuilder();
            foreach (var field in fields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            foreach(var method in NonpublicMethods.Where(m=>m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} must to be public!");
            }
            foreach (var method in publicMethods.Where(m=>m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} must to be private!");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
