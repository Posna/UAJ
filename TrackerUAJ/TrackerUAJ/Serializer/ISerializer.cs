using System;

namespace TrackerUAJ
{
    public enum TraceFormats{ JSON, CSV }

	public interface ISerializer
	{
		string Serialize(TrackerEvent e);
	}
}
