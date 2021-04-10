using System;
using System.Reflection;

namespace CalculateDemo
{
    class OperatorFactory
    {
        /// <summary>
        /// Use reflection
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static Operator Create(string name)
        {
            Operator opr = null;
            Type cls = Type.GetType(name);
            //GetConstructor(), returns the ConstructorInfo type, used to obtain the information of the constructor of this class
            ConstructorInfo ci = cls.GetConstructor(Type.EmptyTypes);
            //Call the constructor reflected by the instance with the specified parameters to provide default values ​​for the parameters that are not commonly used
            opr = (Operator)ci.Invoke(null);
            return opr;
        }
    }
}