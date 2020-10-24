using UnityEngine;

namespace OGJ.View
{
    public class ScrollingBackground : CustomMonoBehaviour
    {
        public float speed = 0.1f;
        public Renderer meshRenderer;

        private void Update()
        {
            Vector2 offset = new Vector2(Time.time * speed, 0);

            meshRenderer.material.mainTextureOffset = offset;
        }
    }
}
