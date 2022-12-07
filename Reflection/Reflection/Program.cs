using System.Reflection;
using Reflection;

Assembly assembly = Assembly.GetExecutingAssembly();
Teacher teacher = new Teacher();
teacher.Name = "farid";

var type = typeof(Teacher);
Console.WriteLine(typeof(Teacher));

foreach (Type tipe in assembly.GetTypes())
{
    //Console.WriteLine("type:");
    //Console.WriteLine("\t"+type.Name);
    //Console.WriteLine("properties:");
    //foreach (PropertyInfo properties in type.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
    //{
    //    Console.WriteLine("\t"+ properties);
    //}

    Console.WriteLine("Field:");
    foreach (FieldInfo field in type.GetFields(BindingFlags.Public|BindingFlags.NonPublic|BindingFlags.Instance))
    {
        if (field.Name=="_id")
        {
            field.SetValue(teacher, 9);
        }
        Console.WriteLine("\t"+field.Name+"-"+field.GetValue(teacher));
    }

    //Console.WriteLine("methods:");
    //foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
    //{
    //    Console.WriteLine(method);
    //}

}

teacher.Id = 800;
Console.WriteLine(teacher.Id);
