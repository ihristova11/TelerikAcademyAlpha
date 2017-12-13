namespace Point3D
{
    using System;
    using IO = System.IO;
    using System.Linq;
    public static class PathStorage
    {
        public static void Save(Path path, string pathName)
        {
            string fullPath = IO.Path.Combine(@"..\Paths", String.Format("{0}.txt", pathName.Trim()));

        }

        public static void Load(string pathName)
        {

        }
    }
}
