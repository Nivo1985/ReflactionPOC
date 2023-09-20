using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Channels;
using ReflectionDemo1;

// closed gemeric
// var people = new Dictionary<int,Person>();
// Console.WriteLine(people.GetType());
// Console.WriteLine(people.GetType().Name);
// var dictionaryType = people.GetType();
// foreach (var argument in dictionaryType.GenericTypeArguments)
// {
//     Console.WriteLine(argument);
// }
// foreach (var argument in dictionaryType.GetGenericArguments())
// {
//     Console.WriteLine(argument);
// }

//open generic
// var closeGenericType = typeof(Dictionary<,>);
// Console.WriteLine(closeGenericType);
// Console.WriteLine(closeGenericType.Name);
// foreach (var argument in closeGenericType.GenericTypeArguments)
// {
//     Console.WriteLine(argument);
// }
// foreach (var argument in closeGenericType.GetGenericArguments())
// {
//     Console.WriteLine(argument);
// }





Console.WriteLine("DONE");

static void Demo1()
{
// inspecting build in type
// Console.Title = "Demo1";
// var name = "Karol Rogowski";
// var nameType = name.GetType();
// Console.WriteLine(nameType);
//
// var stringType = typeof(string);
// Console.WriteLine(stringType);

// inspecting Custom type
//var currentAssembly = Assembly.GetExecutingAssembly();
// var typesFromCurrentAssembly = currentAssembly.GetTypes();
// foreach (var type in typesFromCurrentAssembly)
// {
//  Console.WriteLine(type.FullName);
// }

// var personType = currentAssembly.GetType("ReflectionDemo1.Samples+Person"); // only person?
// Console.WriteLine(personType);
// foreach (var personConstructor in personType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
// {
//     Console.WriteLine(personConstructor);
// }
// foreach (var personMethod in personType.GetMethods())
// {
//     Console.WriteLine(personMethod);
// }

//inspection external Assembly/Module/Type
//var externalAssembly = Assembly.Load("System.Text.Json");
// var typesFromExternalAssembly = externalAssembly.GetTypes();
// foreach (var type in typesFromExternalAssembly)
// {
//     Console.WriteLine(type.FullName);
// }
// var modulesFromExternalAssembly = externalAssembly.GetModules();
// foreach(var module in modulesFromExternalAssembly)
// {
//     Console.WriteLine(module.ScopeName);
// }
// var jsonModule = externalAssembly.GetModule("System.Text.Json.dll");
// var typesFromTheModule = jsonModule.GetTypes();
// foreach (var type in typesFromTheModule)
// {
//     Console.WriteLine(type.FullName);
// }
// var jsonPropertyType = jsonModule.GetType("System.Text.Json.JsonProperty");
}

static void Demo2()
{
//     Console.Title = "Demo2";
//
//     var personType = typeof(Person);
//     var personAllConstrustors =
//         personType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
//
//
// // var personPricateConstructors = 
// //     personType.GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, 
// //         null,
// //         new Type[] {typeof(string), typeof(int)},
// //         null);
// // var person1 = personAllConstrustors[0].Invoke(null);
// // var person2 = personAllConstrustors[1].Invoke(new object[] { "Karol Rogowski" });
// // var person3 = personAllConstrustors[2].Invoke(new object[] { "Karol Rogowski", 1 });
// // var person4 = Activator.CreateInstance(typeof(Person));
// // var iTalkInstancePerson = Activator.CreateInstance("ReflectionDemo1","ReflectionDemo1.Person").Unwrap() as ITalk;
// // iTalkInstancePerson.Talk("Reflection check");
// // var iTalkInstanceAlien = Activator.CreateInstance("ReflectionDemo1","ReflectionDemo1.Alien").Unwrap() as ITalk;
// // iTalkInstanceAlien.Talk("Reflection check");
//
//     var personForModification = personAllConstrustors[2].Invoke(new object[] { "Karol Adam Rogowski", 10 });
//     var nameProperty = personForModification.GetType().GetProperty("Name");
//     nameProperty?.SetValue(personForModification, "Changed");
//
//     personForModification.GetType().InvokeMember("Name",
//         BindingFlags.Instance | BindingFlags.Public | BindingFlags.SetProperty,
//         null, personForModification, new[] { "Changed Again" });
}