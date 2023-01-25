using System.Reflection;

namespace OnlineMuhasebeServer.Presentation;

public static class AssemblyReference
{
    //oluşturma sebebimiz program.cs te controller ı başka bir katmana taşımak istersen o katmana assemblsini vermemiz lazım.
    public static readonly Assembly Assembly = typeof(Assembly).Assembly;
}
