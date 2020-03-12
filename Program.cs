using System;
using System.Diagnostics;

/*
dotnet.exe build -c Release
nuget pack .\TestAutoDeploy.nuspec
packages\squirrel.windows.1.9.1\tools\Squirrel.exe --no-delta --no-msi -releasify TestAutoDeploy.1.3.0.nupkg


*/

namespace TestAutoSquirrel
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
      FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
      Console.WriteLine($"Here is TestApp-{fvi.FileVersion}. Press any 'enter' for exit:");
      Console.ReadLine();
    }
  }
}