using System;

namespace TrackerUAJ
{
    public enum TraceFormats{ JSON, CSV, XML }

	public interface ISerializer
	{
		string Serialize(TrackerEvent e);
	}
}
