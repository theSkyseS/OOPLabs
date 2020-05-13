using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_8
{
    class Program
    {
        static MyClass myClass = new MyClass();
        static void Main(string[] args)
        {

            #region fields
            const BindingFlags BindingAttr = BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public;
            var type = myClass.GetType();
            FieldInfo[] fieldsInfo = type.GetFields(BindingAttr);
            MethodInfo[] methodsInfo = type.GetMethods(BindingAttr);
            PropertyInfo[] propertiesInfo = type.GetProperties(BindingAttr);
            #endregion

            #region get info
            foreach (var fieldInfo in fieldsInfo)
                GetInfoAboutField(fieldInfo);

            foreach (var methodInfo in methodsInfo)
                GetInfoAboutMethod(methodInfo);

            foreach (var propertyInfo in propertiesInfo)
                GetInfoAboutPropety(propertyInfo);
            #endregion

            #region set values
            FieldInfo field = type.GetField("name", BindingAttr);
            field.SetValue(myClass, "notDefault");
            field = type.GetField("amount", BindingAttr);
            field.SetValue(myClass, 100);
            PropertyInfo property = type.GetProperty("Flag", BindingAttr);
            property.SetValue(myClass, true);
            #endregion

            #region method invoke
            MethodInfo method = type.GetMethod("AddToName", BindingAttr);
            method.Invoke(myClass, new object[] {"User"});
            #endregion

            #region constructors invoke
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);
            constructor.Invoke(null);
            constructor = type.GetConstructor(BindingAttr, null , new Type[] { typeof(int), typeof(string), typeof(bool), typeof(double) }, null );
            constructor.Invoke(new object[] { 10, "User", false, 2.67 });
            #endregion

            Console.ReadKey();
        }
        static void GetInfoAboutField(FieldInfo fieldInfo)
        {
            Console.WriteLine($"Имя поля: {fieldInfo.Name}");
            Console.WriteLine($"Тип поля: {fieldInfo.FieldType}");
            Console.WriteLine($"Значение поля: {fieldInfo.GetValue(myClass)}");
            Console.WriteLine($" Открытый член? {fieldInfo.IsPublic}");
            Console.WriteLine($" Приватный член? {fieldInfo.IsPrivate}");
            Console.WriteLine($" Статический член? {fieldInfo.IsStatic}\n");
        }
        static void GetInfoAboutMethod(MethodInfo methodInfo)
        {
            Console.WriteLine($"Имя метода: {methodInfo.Name}");
            Console.WriteLine($"Возвращаемый тип: {methodInfo.ReturnType.Name}");
            Console.WriteLine($"Параметры метода:");
            foreach (var parameter in methodInfo.GetParameters())
                Console.WriteLine($"  Тип: {parameter.ParameterType}, Имя: {parameter.Name}");
            Console.WriteLine($" Это конструктор? {methodInfo.IsConstructor}");
            Console.WriteLine($" Это абстрактный метод? {methodInfo.IsAbstract}");
            Console.WriteLine($" Открытый метод? {methodInfo.IsPublic}");
            Console.WriteLine($" Приватный метод? {methodInfo.IsPrivate}");
            Console.WriteLine($" Статический метод? {methodInfo.IsStatic}\n");
        }
        static void GetInfoAboutPropety(PropertyInfo propertyInfo)
        {
            Console.WriteLine($"Имя свойства: {propertyInfo.Name}");
            Console.WriteLine($"Тип свойства: {propertyInfo.PropertyType}");
            if(propertyInfo.CanRead)
                Console.WriteLine($"Значение свойства: {propertyInfo.GetValue(myClass)}");
            Console.WriteLine($" Запись разрешена? {propertyInfo.CanWrite}");
            Console.WriteLine($" Чтение разрешено? {propertyInfo.CanRead}\n");
        }
    }
}
