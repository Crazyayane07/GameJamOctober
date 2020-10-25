

namespace OGJ.View.UI.Popups
{
    public class Popup : CustomMonoBehaviour
    {
        public void OpenPopup()
        {
            SetActive(true);
            OnOpenPopup();
        }

        public void ClosePopup()
        {
            SetActive(false);
            OnClosePopup();
        }

        protected virtual void OnOpenPopup() { }
        protected virtual void OnClosePopup() { }
    }
}
