using System;
class Ex29
{
    static void Main()
    {
        Console.WriteLine("直方体");
        float width = InputFloat("幅");
        float boxHeight = InputFloat("高さ");
        float boxDepth = InputFloat("奥行");
        Console.WriteLine($"表面積は{Box.GetSurface(width, boxHeight, boxDepth)}");
        Console.WriteLine($"体積は{Box.GetVolume(width, boxHeight, boxDepth)}");

        Console.WriteLine("円柱");
        float cylinderBottom = InputFloat("底面の半径");
        float cylinderHeight = InputFloat("高さ");
        Console.WriteLine($"表面積は{Cylinder.GetSurface(cylinderBottom, cylinderHeight)}");
        Console.WriteLine($"体積は{Cylinder.GetVolume(cylinderBottom, cylinderHeight)}");

        Console.WriteLine("球");
        float radius = InputFloat("半径");
        Console.WriteLine($"表面積は{Sphere.GetSurface(radius)}");
        Console.WriteLine($"体積は{Sphere.GetVolume(radius)}");

        Console.WriteLine("三角柱");
        float triangleBottom = InputFloat("三角形の底辺");
        float triangleDepth = InputFloat("三角形の奥行");
        float riangularPrismHeight = InputFloat("三角柱の高さ");
        Console.WriteLine($"表面積は{TriangularPrism.GetSurface(triangleBottom, triangleDepth, riangularPrismHeight)}");
        Console.WriteLine($"体積は{TriangularPrism.GetVolume(triangleBottom, triangleDepth, riangularPrismHeight)}");
    }
    static float InputFloat(string outputstring)
    {
        float input;
        while (true)
        {
            Console.Write(outputstring);
            if (float.TryParse(Console.ReadLine(), out input))
            {
                return input;
            }
        }

    }
    static class Box //直方体
    { 
        public static float GetSurface(float width, float height, float depth)
        {
            return (width * height + height * depth + depth * width) * 2;
        }

        public static float GetVolume(float width, float height, float depth)
        {
            return width * height * depth;
        }

    }
    static class Cylinder //円柱 
    {
        public static float GetSurface(float bottom, float height)
        {
            return bottom * 2.0f * MathF.PI * height + bottom * bottom * MathF.PI * 2.0f;
        }

        public static float GetVolume(float bottom, float height)
        {
            return bottom * bottom * MathF.PI * height;
        }
    }
    static class Sphere //球
    {
        public static float GetSurface(float radius)
        {
            return radius * radius * MathF.PI * 4;
        }

        public static float GetVolume(float radius)
        {
            return (4.0f / 3.0f) * MathF.PI * radius * radius * radius;
        }
    }
    static class TriangularPrism //三角柱
    {
        public static float GetSurface(float bottom, float depth, float height)
        {
            return (float)((bottom * depth / 2) * 2 + (bottom * height
                + depth * height
                + Math.Sqrt(bottom * bottom + depth * depth) * height));
        }

        public static float GetVolume(float bottom, float depth, float height)
        {
            return (bottom * depth / 2) * height;
        }
    }
}