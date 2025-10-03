namespace Raytracer;

/// <summary>
/// Represents a simple pinhole camera. Ray generation is currently a stub.
/// </summary>
public class Camera
{
    public Vector3 Position { get; set; } = new Vector3(0f, 0f, 0f);
    public float FieldOfView { get; set; } = 90f;

    public Ray GetRay(float u, float v)
    {
        // TODO: Use camera orientation and projection math to generate a proper ray through pixel (u, v).
        var direction = new Vector3(0f, 0f, -1f);
        return new Ray(Position, direction);
    }
}
