using System.Linq;
using System.Reflection;

namespace Craxy.Parkitect.FearlessGuests
{
  public class Mod : IMod
  {
    public string Name => name;
    public string Description => description;
    public string Identifier => identifier;

    private static string name, description, identifier;

    static Mod()
    {
      var assembly = Assembly.GetExecutingAssembly();

      var meta =
          assembly.GetCustomAttributes(typeof(AssemblyMetadataAttribute), false)
          .Cast<AssemblyMetadataAttribute>()
          .Single(a => a.Key == "Identifier");
      identifier = meta.Value;

      T GetAssemblyAttribute<T>() where T : System.Attribute => (T)assembly.GetCustomAttribute(typeof(T));

      name = GetAssemblyAttribute<AssemblyTitleAttribute>().Title;
      description = GetAssemblyAttribute<AssemblyDescriptionAttribute>().Description;
    }

    public void onEnabled()
    {
      Global.GUESTS_LIKE_EVERY_RIDE = true;
    }

    public void onDisabled()
    {
      Global.GUESTS_LIKE_EVERY_RIDE = false;
    }
  }
}
