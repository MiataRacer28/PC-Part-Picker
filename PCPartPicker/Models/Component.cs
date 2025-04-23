using System;

/// <summary>
/// Will serve as a basis for future dedicated component classes
/// </summary>
public abstract class Component
{

    //Fields
    public string Name { get; set; } = "Unknown"; //Name of component (Manufacturer name, NOT COMPONENT TYPE) (Unknown default)
    public string Manufacturer { get; set; } = "Unknown"; //Name of Manufacturer (Unknown default)
    public int PerformanceScore { get; set; } = 0; //performance score (Need to determine scale) (0 default)
    


    public Component(string name, string manufacturer, int performanceScore)
	{
        this.Name = name;
        this.Manufacturer = manufacturer;
        this.PerformanceScore = performanceScore;   
	}

    //Will need to be overriden by subclasses
    public abstract string[] ToStringArray();
}
