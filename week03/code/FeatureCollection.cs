using System.ComponentModel;
using Microsoft.VisualBasic;

public class FeatureCollection
{
    // TODO Problem 5 - ADD YOUR CODE HERE
    // Create additional classes as necessary
    public GeneralInformation Metadata{ get ; set;}
    public List<SpecificInformation> features{ get; set;}

}

public class GeneralInformation
{
    public int count {get; set;}
}

public class SpecificInformation
{
    public SpecificProperties properties{get; set;}
}

public class SpecificProperties
{
    public int mag{get; set;}
    public string place {get; set;}
}