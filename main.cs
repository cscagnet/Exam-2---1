using System;

class MainClass {
  public static void Main (string[] args) {

  Console.WriteLine ("What is the radius?");
  double radius = Convert.ToDouble(Console.ReadLine());
  Console.WriteLine ("What is the height?");
  double height = Convert.ToDouble(Console.ReadLine()); 
 
  CylinderVolume();

  }


  public static double CylinderVolume(double radius, double height)
{
  double volume = 0;
  volume = 3.14 * radius * radius * height;
  Console.WriteLine ("The Volume is " + volume);

  }
}