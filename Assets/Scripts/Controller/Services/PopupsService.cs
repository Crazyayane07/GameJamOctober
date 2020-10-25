
namespace OGJ.Controller.Services
{
    public interface IPopupsService
    {
        void OpenGameOverPopup();
        void CloseGameOverPopup();

        void OpenPausePopup();
        void ClosePausePopup();

        void OpenOptions();
        void CloseOptions();
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

        public void CloseOptions()
        {
            popupsSet.options.ClosePopup();
        }

        public void ClosePausePopup()
        {
            popupsSet.pausePopup.ClosePopup();
        }

        public void OpenGameOverPopup()
        {
            popupsSet.gameOverPopup.OpenPopup();
        }

        public void OpenOptions()
        {
            popupsSet.options.OpenPopup();
        }

        public void OpenPausePopup()
        {
            popupsSet.pausePopup.OpenPopup();
        }
    }
}
