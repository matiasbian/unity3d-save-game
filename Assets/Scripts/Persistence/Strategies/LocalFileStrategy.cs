using MatiBian.Persistence.Format;
using MatiBian.Persistence.Structure;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MatiBian.Persistence.Strategy
{
	public class LocalFileStrategy : ISavesStrategy
	{
		public void LoadGameAsync(Action<SaveStateStructure, bool> callback, IFormat format, string filename)
		{
			throw new NotImplementedException();
		}

		public SaveStateStructure LoadGameSync(IFormat format, string filename)
		{
			throw new NotImplementedException();
		}

		public void SaveGameAsync(SaveStateStructure saveStructure, IFormat format, string filename, Action<bool> callback = null)
		{
			throw new NotImplementedException();
		}

		public void SaveGameSync(SaveStateStructure saveStructure, IFormat format, string filename)
		{
			throw new NotImplementedException();
		}
	}
}
