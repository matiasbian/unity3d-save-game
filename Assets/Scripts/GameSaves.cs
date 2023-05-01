using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using MatiBian.Persistence.Structure;
using MatiBian.Persistence.Format;
using MatiBian.Persistence.Strategy;
using MatiBian.Enums;

namespace MatiBian
{
	public class GameSaves
	{
		ISavesStrategy mSaveStrategy;
		IFormat mSaveFormat;
		string mFileName;

		public GameSaves(SaveStrategy saveStrategy, FileFormat saveFormat, string filename = "savegame_01")
		{
			mSaveStrategy = GetStrategy(saveStrategy);
			mSaveFormat = GetFormat(saveFormat);
			mFileName = filename;
		}
		public void LoadGameAsync(Action<SaveStateStructure, bool> callback)
		{
			mSaveStrategy.LoadGameAsync(callback, mSaveFormat, mFileName);
		}

		public SaveStateStructure LoadGameSync()
		{
			return mSaveStrategy.LoadGameSync(mSaveFormat, mFileName);
		}

		public void SaveGameAsync(SaveStateStructure saveStructure, Action<bool> callback = null)
		{
			mSaveStrategy.SaveGameAsync(saveStructure, mSaveFormat, mFileName, callback);
		}

		public void SaveGameSync(SaveStateStructure saveStructure)
		{
			mSaveStrategy.SaveGameSync(saveStructure, mSaveFormat, mFileName);
		}


		#region aux func
		ISavesStrategy GetStrategy(SaveStrategy strategy)
		{
			switch (strategy)
			{
				case SaveStrategy.LocalFile:
					return new LocalFileStrategy();
				default:
					Debug.LogError("Unknown Strategy: " + strategy);
					return null;
			}
		}

		IFormat GetFormat(FileFormat format)
		{
			switch (format)
			{
				case FileFormat.JSON:
					return new JSONFormat();
				default:
					Debug.LogError("Unknown Format: " + format);
					return null;
			}
		}
		#endregion

	}
}

