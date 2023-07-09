using System;

namespace UnityExtended.System.Attributes 
{
    [Obsolete("No use for now")]
    [AttributeUsage(AttributeTargets.Field)]
    public class RandomAttribute : Attribute
    {
        // The idea is create a Field Attribute (To integers and Enum) that on awake or Start, randomize the value (based on a range)... 
        // idk if this is possible but... let's give it a try
    } 
}
