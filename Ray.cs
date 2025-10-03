using System;

namespace Raytracer;

/// <summary>
/// Represents a ray with an origin and direction.
/// </summary>
public class Ray
{
    public Vector3 Origin { get; }
    public Vector3 Direction { get; }

    public Ray(Vector3 origin, Vector3 direction)
    {
        Origin = origin;
        Direction = direction;
    }

    public Vector3 At(float t)
    {
        // TODO: Return the point Origin + Direction * t once vector math operations are implemented.
        throw new NotImplementedException();
    }
}
