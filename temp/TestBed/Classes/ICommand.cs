namespace TestBed.Classes;

public interface ICommand<in T>
{
    void Save(string connection, T obj);
}