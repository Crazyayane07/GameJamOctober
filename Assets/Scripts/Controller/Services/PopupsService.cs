
namespace OGJ.Controller.Services
{
    public interface IPopupsService
    {
        void OpenGameOverPopup();
    }

    public class PopupsService : IPopupsService
    {
        private PopupsSet popupsSet;

        public PopupsService(PopupsSet popupsSet)
        {
            this.popupsSet = popupsSet;
        }

        public void OpenGameOverPopup()
        {
            
        }
    }
}
