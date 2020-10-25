
namespace OGJ.Controller.Services
{
    public interface IPopupsService
    {
        void OpenGameOverPopup();
        void CloseGameOverPopup();

        void OpenPausePopup();
        void ClosePausePopup();
    }

    public class PopupsService : IPopupsService
    {
        private PopupsSet popupsSet;

        public PopupsService(PopupsSet popupsSet)
        {
            this.popupsSet = popupsSet;
        }

        public void CloseGameOverPopup()
        {
            popupsSet.gameOverPopup.ClosePopup();
        }

        public void ClosePausePopup()
        {
            popupsSet.pausePopup.ClosePopup();
        }

        public void OpenGameOverPopup()
        {
            popupsSet.gameOverPopup.OpenPopup();
        }

        public void OpenPausePopup()
        {
            popupsSet.pausePopup.OpenPopup();
        }
    }
}
