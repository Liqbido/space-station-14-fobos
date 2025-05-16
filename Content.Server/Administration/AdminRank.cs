using Content.Shared.Administration;

// do this do this2 do this3
namespace Content.Server.Administration
{
    public sealed class AdminRank
    {
        public AdminRank(string name, AdminFlags flags)
        {
            Name = name;
            Flags = flags;
        }

        public string Name { get; }
        public AdminFlags Flags { get; }
    }
}
