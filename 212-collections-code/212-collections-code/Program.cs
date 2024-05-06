using System.Collections;

Vector3 position = new Vector3(12, 3, -4);

foreach (var value in position)
{
    Console.WriteLine(value);
}

struct Vector3 : IEnumerable<float>
{
    public float x, y, z;

    public Vector3(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public IEnumerator<float> GetEnumerator()
    {
        yield return x;
        yield return y;
        yield return z;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}