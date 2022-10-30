using System;

namespace DgKala.Generators
{
    public class NameGenerator
    {
        public static string GeneratorUniqCode()
        {
            return Guid.NewGuid().ToString().Replace("-","");
        }
    }
}
