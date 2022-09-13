using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Text.RegularExpressions;

namespace RegexProblems
{
    public class RegexFactory
    {
        public static object CreateObjectForUserDetails(string ClassName,string ConstructorName)
        {
            
            string pattern = @"." + ConstructorName + "$";
            Match result = Regex.Match(ClassName, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly assembly = Assembly.GetExecutingAssembly();
                    Type type = assembly.GetType(ClassName);
                    return Activator.CreateInstance(type);
                }
                catch(ArgumentNullException ex)
                {
                    throw new RegexCustomException(RegexCustomException.ExceptionType.NO_SUCH_CLASS, "No Class Found");
                }
            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No Constructor Found");
            }
        }

        public static object CreateObjectForParameterConstructor(string ClassName, string ConstructorName,string message)
        {
            Type type = typeof(ValidateUser);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo constructorInfo = type.GetConstructor(new[] { typeof(string) });
                    object objectConstructor = constructorInfo.Invoke(new object[] { message });
                    return objectConstructor;
                }
                else
                {
                    throw new RegexCustomException(RegexCustomException.ExceptionType.NO_CONSTRUCTOR_FOUND, "No Constructor Found");
                }
            }
            else
            {
                throw new RegexCustomException(RegexCustomException.ExceptionType.NO_SUCH_CLASS, "No Class Found");
            }
        }
    }
}
