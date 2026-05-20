class Box
{
    public float Height;
    public float Width;
    public float Length;

    public Box()
    {
        Height = 1;
        Width = 1;
        Length = 1;
    }

    public Box(float height, float width, float length)
    {
        Height = height;
        Width = width;
        Length = length;
    }

    public int Show()
    {
        WriteLine($"Height: {Height}");
        WriteLine($"Width: {Width}");
        WriteLine($"Length: {Length}");
        return 0;
    }

    public float Volume()
    {
        return Height * Width * Length;
    }


}