using System.Reflection;

namespace Task13_Reflection_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();

            FieldInfo[] fieldInfos = user.GetType().GetFields(BindingFlags.NonPublic |
                         BindingFlags.Instance);

            fieldInfos[0].SetValue(user,12);
            fieldInfos[1].SetValue(user,"asassas");

            
            var info = user.GetType().GetMethod("ChangeAge", BindingFlags.Static | BindingFlags.NonPublic);

            object[] parameters = {12};
            info.Invoke(user, parameters);

        }
    }
}