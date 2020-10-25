using UnityEngine;

namespace OGJ
{
    public class Spawner : CustomMonoBehaviour
    {
        public void TrySpawn(GameObject obj, Transform transform)
        {
            Instantiate(obj, transform.position, Quaternion.identity);
        }
    }
}
