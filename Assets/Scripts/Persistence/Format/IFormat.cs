using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MatiBian.Persistence.Structure;
using System;

namespace MatiBian.Persistence.Format 
{
    public interface IFormat
    {
        // Save
        public void WriteSync (SaveStateStructure saveStructure, string filename);
        public void WriteAsync (SaveStateStructure saveStructure, string filename, Action<bool> callback = null);

        //Load
        public SaveStateStructure ReadSync(string filename);
        public void ReadAsync(Action<SaveStateStructure, bool> callback, string filename);
    }
}
