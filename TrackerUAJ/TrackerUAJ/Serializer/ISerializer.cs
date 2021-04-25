using System;

namespace TrackerUAJ
{
	public interface ISerializer
	{
		string Serialize(TrackerEvent e);
	}
}
