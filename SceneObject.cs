namespace Raytracer;

/// <summary>
/// Base class for anything that can appear in the scene. Concrete objects implement
/// Intersect with their specific geometry math.
/// </summary>
public abstract class SceneObject
{
    // TODO: Add common properties such as material information and transformation matrices.
    public abstract bool Intersect(Ray ray);
}
