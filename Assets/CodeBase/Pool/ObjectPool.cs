using System.Collections.Generic;
using UnityEngine;

namespace CodeBase.Pool
{
    public class ObjectPool
    {
        public List<T> LoadObject<T>(GameObject prefab, int countObject)
        {
            List<T> _instancePrefabs = new List<T>();
            
            for (int i = 0; i < countObject; i++)
            {
                GameObject instance = Object.Instantiate(prefab);
                instance.SetActive(false);
                
                _instancePrefabs.Add(instance.GetComponent<T>());
            }

            return _instancePrefabs;
        } 
    }
}