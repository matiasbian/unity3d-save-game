using MatiBian.Persistence.Structure;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatiBian.Persistence.Format 
{
	public class JSONFormat : IFormat
	{
		public void ReadAsync(Action<SaveStateStructure, bool> callback, string filename)
		{
			throw new NotImplementedException();
		}

		public SaveStateStructure ReadSync(string filename)
		{
			throw new NotImplementedException();
		}

		public void WriteAsync(SaveStateStructure saveStructure, string filename, Action<bool> callback = null)
		{
			throw new NotImplementedException();
		}

		public void WriteSync(SaveStateStructure saveStructure, string filename)
		{
			throw new NotImplementedException();
		}
	}
}
