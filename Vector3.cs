using System;

namespace Raytracer;

/// <summary>
/// Minimal 3D vector helper. Math operations are stubs so the structure compiles
/// before the real raytracing math is added.
/// </summary>
public class Vector3
{
    public float X { get; }
    public float Y { get; }
    public float Z { get; }

    public Vector3(float x, float y, float z)
    {
        X = x;
        Y = y;
        Z = z;
    }

    public static Vector3 Add(Vector3 a, Vector3 b)
    {
        // TODO: Implement component-wise vector addition.
        throw new NotImplementedException();
    }

    public static Vector3 Sub(Vector3 a, Vector3 b)
    {
        // TODO: Implement component-wise vector subtraction.
        throw new NotImplementedException();
    }

    public static float Dot(Vector3 a, Vector3 b)
    {
        // TODO: Return the dot product of the two vectors.
        throw new NotImplementedException();
    }

    public static Vector3 Cross(Vector3 a, Vector3 b)
    {
        // TODO: Return the cross product of the two vectors.
        throw new NotImplementedException();
    }

    public Vector3 Normalize()
    {
        // TODO: Return a new vector that points in the same direction but has unit length.
        throw new NotImplementedException();
    }
}
