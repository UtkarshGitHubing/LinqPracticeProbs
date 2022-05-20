namespace LinqPractice1
{
  internal class EmployeeChild: Employee
  {
    public new int ID;
    public new string Name;
    public override string ToString()
    {
      return ID + base.ID + base.Name + Name;
    }
    protected override string GetName()
    {
      return ID + " " + Name;
    }
  }
}