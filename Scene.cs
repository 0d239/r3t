using System.Collections.Generic;

namespace Raytracer;

/// <summary>
/// Holds scene objects and is responsible for telling the renderer what a ray sees.
/// </summary>
public class Scene
{
    public List<SceneObject> Objects { get; } = new();
    public Color BackgroundColor { get; set; } = new Color(0.5f, 0.7f, 1f);

    public Color Trace(Ray ray)
    {
        // TODO: Loop over Objects, track the closest hit, and compute shading information.
        return BackgroundColor;
    }
}
