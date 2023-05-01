using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MatiBian.Persistence.Structure;
using MatiBian.Persistence.Format;
using System;

namespace MatiBian.Persistence.Strategy
{
    public interface ISavesStrategy
    {
        // Save
        public void SaveGameSync(SaveStateStructure saveStructure, IFormat format, string filename);
        public void SaveGameAsync(SaveStateStructure saveStructure, IFormat format, string filename, Action<bool> callback = null);

        //Load
        public SaveStateStructure LoadGameSync(IFormat format, string filename);
        public void LoadGameAsync(Action<SaveStateStructure, bool> callback, IFormat format, string filename);
    }
}
