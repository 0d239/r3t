using System;

namespace Raytracer;

/// <summary>
/// Simple RGB color stored as floats in the 0..1 range.
/// </summary>
public readonly struct Color
{
    public float R { get; }
    public float G { get; }
    public float B { get; }

    public Color(float r, float g, float b)
    {
        R = r;
        G = g;
        B = b;
    }

    public (int R, int G, int B) ToByteTuple()
    {
        // TODO: Apply gamma correction before exporting to bytes if desired.
        var clamped = Clamp01();
        var r = (int)(clamped.R * 255.999f);
        var g = (int)(clamped.G * 255.999f);
        var b = (int)(clamped.B * 255.999f);
        return (r, g, b);
    }

    private Color Clamp01()
    {
        return new Color(
            Math.Clamp(R, 0f, 1f),
            Math.Clamp(G, 0f, 1f),
            Math.Clamp(B, 0f, 1f));
    }
}
