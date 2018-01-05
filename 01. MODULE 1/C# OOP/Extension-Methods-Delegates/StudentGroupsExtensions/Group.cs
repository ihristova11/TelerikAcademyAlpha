namespace StudentGroupsExtensions
{
    public class Group
    {
        public Group(uint groupNumber, string groupDepartment)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = groupDepartment;
        }
        public uint GroupNumber { get; set; }
        public string DepartmentName { get; set; }
    }
}
