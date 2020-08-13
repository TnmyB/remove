using System;
using System.Collections.Generic;

class NoOggyChecker
{
  static void RemoveOggy(List<string> names)
  {
    //Initial method in comment
   /* foreach (var name in names)
    {
        if(name.StartsWith("oggy")) {
            Console.WriteLine($"Need to remove {name}!");
            names.Remove(name);
        }
    }
    */
    
    for(int i_names = 0; i_names < names.Count ; i_names++){
           
           if(names[i_names].StartsWith("oggy")){
                 Console.WriteLine($"Need to remove {names[i_names]}!");
                 names.Remove(names[i_names]);
                 i_names--;
           }
    }
    
  }
  static bool OggyIsRemoved(List<string> names)
  {
    return names.Find(x => x.Contains("oggy")) == null;
  }
  static int Main()
  {
    var names = new List<string>
      { "nobita", "bheem", "oggy", "oggy cockroach", "ninja" };
    RemoveOggy(names);
    if(OggyIsRemoved(names)) {
      Console.WriteLine("Passed!");
      return 0;
    } else {
      Console.WriteLine("Failed!!");
      return 1;
    }
  }
}
