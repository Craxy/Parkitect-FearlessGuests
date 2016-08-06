namespace Craxy.Parkitect.FearlessGuests
{
    public class Mod : IMod
    {
        public string Name
        {
            get { return "Fearless Guests"; }
        }

        public string Description
        {
            get
            {
                return "Guests ignore the intensity ratings of rides. As a result all guests like all rides the same.";
            }
        }

        public string Identifier { get; set; }

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