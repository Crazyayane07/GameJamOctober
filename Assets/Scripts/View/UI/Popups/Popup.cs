

namespace OGJ.View.UI.Popups
{
    public class Popup : CustomMonoBehaviour
    {
        public void OpenPopup()
        {
            SetActive(true);
        }

        public void ClosePopup()
        {
            SetActive(false);
        }
    }
}
