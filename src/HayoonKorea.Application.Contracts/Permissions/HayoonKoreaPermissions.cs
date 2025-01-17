namespace HayoonKorea.Permissions;

public static class HayoonKoreaPermissions
{
    public const string GroupName = "HayoonKorea";

    public static class Phones
    {
        public const string Default = GroupName + ".Phones";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
    }
}
