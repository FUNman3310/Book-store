using System.Reflection;
using ReflectionTask;


 
    Assembly assembly = Assembly.GetExecutingAssembly();
    Teacher teacher = new Teacher();

    Type[] types = assembly.GetTypes();

    foreach (Type type in types)
    {
        if (type == typeof(Teacher))
        {
            Console.WriteLine("Type names: ");
            Console.WriteLine("\t" + type.Name);
            Console.WriteLine("Property name:");
            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine("\t" + property.Name);
            }
            Console.WriteLine("Field name:");
            foreach (FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                if (field.Name == "_name") field.SetValue(teacher, "AB102");
                Console.WriteLine("\t" + field.Name + " " + field.GetValue(teacher));
            }
            Console.WriteLine("Method name:");
            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic))
            {
                Console.WriteLine("\t" + method.Name);
            }
        }

    }



