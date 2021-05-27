namespace Exercise
{
    public interface IEdge
    {
        int getEither();
        int getOther(int v);
        float getWeight();
        int compareTo(IEdge o);
    }
}