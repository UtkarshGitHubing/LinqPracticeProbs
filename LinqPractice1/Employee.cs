namespace LinqPractice1
{
  internal class Employee
  {
    protected int ID;
    protected string Name;

    public override string ToString()
    {
      return ID + " " + Name;
    }
    protected virtual string GetName() {
      return ID + " " + Name;
    }
  }
}