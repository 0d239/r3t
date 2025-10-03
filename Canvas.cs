using System.IO;

namespace Raytracer;

/// <summary>
/// Lightweight image buffer that can later be swapped for a more advanced renderer output.
/// </summary>
public class Canvas
{
    private readonly Color[,] _pixels;

    public int Width { get; }
    public int Height { get; }

    public Canvas(int width, int height)
    {
        Width = width;
        Height = height;
        _pixels = new Color[width, height];
    }

    public void SetPixel(int x, int y, Color color)
    {
        if (x < 0 || x >= Width || y < 0 || y >= Height)
        {
            // TODO: Decide whether to throw an exception or clamp coordinates in release builds.
            return;
        }

        _pixels[x, y] = color;
    }

    public void SavePPM(string filename)
    {
        // TODO: Replace plain PPM output with a more robust image format if needed.
        using var writer = new StreamWriter(filename);
        writer.WriteLine("P3");
        writer.WriteLine($"{Width} {Height}");
        writer.WriteLine("255");

        for (var y = Height - 1; y >= 0; y--)
        {
            for (var x = 0; x < Width; x++)
            {
                var (r, g, b) = _pixels[x, y].ToByteTuple();
                writer.WriteLine($"{r} {g} {b}");
            }
        }
    }
}
