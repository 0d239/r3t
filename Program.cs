using System;

namespace Raytracer;

internal class Program
{
    private static void Main()
    {
        const int width = 200;
        const int height = 100;

        var canvas = new Canvas(width, height);
        var scene = new Scene();
        // TODO: Populate the scene with real objects, materials, and lighting once implemented.
        scene.Objects.Add(new Sphere(new Vector3(0f, 0f, -1f), 0.5f));

        var camera = new Camera();
        // TODO: Configure camera parameters (position, orientation, field of view, etc.).

        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                // TODO: Cast a ray through each pixel and compute the color via scene.Trace(ray).
                var t = (float)x / (width - 1);
                var u = (float)y / (height - 1);
                var placeholderColor = new Color(t, u, 0.2f);
                canvas.SetPixel(x, y, placeholderColor);
            }
        }

        const string outputFile = "output.ppm";
        canvas.SavePPM(outputFile);
        Console.WriteLine($"Wrote placeholder image to {outputFile}. TODO: replace with real raytracing output.");
    }
}
