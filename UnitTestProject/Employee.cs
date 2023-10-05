namespace Section6
{
    public class Employee
    {
        //constructor
        public Employee(int id)
        {
            EmployeeID = id;
        }
        public Employee(string name, int id, string title)
        {
            Name = name;
            EmployeeID = id;
            JobTitle = title;
        }

        //properties
        public string Name;
        public int EmployeeID;
        public string JobTitle;

        //methods
        public string JobLocation()
        {
            if (JobTitle == "Manager")
            {
                return "Boston";
            }
            else if (JobTitle == "Staff")
            {
                return "Chicago";

            }
            return "New York";
        }

        public override string ToString()
        {
            return EmployeeID + " " + Name + "Job Title: " + JobTitle;
        }
    }

}
