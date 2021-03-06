using System.Collections.Generic;

namespace Server.Misc
{
    public static class PreventInaccess
    {
        public static readonly bool Enabled = true;
        private static readonly LocationInfo[] m_Destinations = new LocationInfo[]
        {
            new LocationInfo(new Point3D(5275, 1163, 0), Map.Felucca), // Jail
            new LocationInfo(new Point3D(5275, 1163, 0), Map.Trammel),
            new LocationInfo(new Point3D(5445, 1153, 0), Map.Felucca), // Green acres
            new LocationInfo(new Point3D(5445, 1153, 0), Map.Trammel)
        };
        private static Dictionary<Mobile, LocationInfo> m_MoveHistory;
        public static void Initialize()
        {
            m_MoveHistory = new Dictionary<Mobile, LocationInfo>();

            if (Enabled)
                EventSink.Login += new LoginEventHandler(OnLogin);
        }

        public static void OnLogin(LoginEventArgs e)
        {
            Mobile from = e.Mobile;

            if (from == null || from.IsPlayer())
                return;

            if (HasDisconnected(from))
            {
                if (!m_MoveHistory.ContainsKey(from))
                    m_MoveHistory[from] = new LocationInfo(from.Location, from.Map);

                LocationInfo dest = GetRandomDestination();

                from.Location = dest.Location;
                from.Map = dest.Map;
            }
            else if (m_MoveHistory.ContainsKey(from))
            {
                LocationInfo orig = m_MoveHistory[from];
                from.SendMessage("Your character was moved from {0} ({1}) due to a detected client crash.", orig.Location, orig.Map);

                m_MoveHistory.Remove(from);
            }
        }

        private static bool HasDisconnected(Mobile m)
        {
            return (m.NetState == null || m.NetState.Socket == null);
        }

        private static LocationInfo GetRandomDestination()
        {
            return m_Destinations[Utility.Random(m_Destinations.Length)];
        }

        private class LocationInfo
        {
            public LocationInfo(Point3D loc, Map map)
            {
                Location = loc;
                Map = map;
            }

            public Point3D Location { get; }
            public Map Map { get; }
        }
    }
}
