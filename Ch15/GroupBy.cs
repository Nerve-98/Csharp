using System;
using System.Linq;

class Profile
{
    public string Name { get; set; }
    public int Height { get; set; }
}

class MainApp
{
    static void Main(string[] args)
    {
        Profile[] arrProfile =
        {
            new Profile(){Name = "A", Height = 186},
            new Profile(){Name = "B", Height = 170}
        };


        var listProfile = from profile in arrProfile
                          orderby profile.Height
                          group profile by profile.Height < 175 into g
                          select new { GroupKey = g.Key, Profiles = g };
        /* public interface IGrouping<out TKey, out TElement> : IEnumerable<TElement>, IEnumerable */
        foreach(var Group in listProfile)
        {
            Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

            foreach (var profile in Group.Profiles)
            {
                Console.WriteLine($"\t{profile.Name}, {profile.Height}");
            }

        }
    }

}