namespace Raytracer;

/// <summary>
/// Example scene object. Intersection math is not implemented yet.
/// </summary>
public class Sphere : SceneObject
{
    public Vector3 Center { get; }
    public float Radius { get; }

    public Sphere(Vector3 center, float radius)
    {
        Center = center;
        Radius = radius;
    }

    public override bool Intersect(Ray ray)
    {
        // TODO: Implement the analytical sphere-ray intersection test and return true when hit.
        return false;
    }
}
