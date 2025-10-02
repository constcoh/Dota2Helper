using Dota2Helper.WinFormApp.InputControllers;
using Dota2Helper.WinFormApp.Models;
using Dota2Helper.WinFormApp.ViewModelObservers;

namespace Dota2Helper.WinFormApp
{
    public class RootViewModel
    {
        public static RootViewModel Instance { get; private set; }

        public static void Init()
        {
            Instance = new RootViewModel();
        }

        private List<IViewModelObserver> _viewModelObservers;

        private List<IInputController> _inputControllers;

        private RootViewModel()
        {
            _viewModelObservers = new List<IViewModelObserver>();
            _inputControllers = new List<IInputController>();

            MapEnlargerModel = new MapEnlargerModel();
            HerosStatisticsModel = new HerosStatisticsModel();
        }

        public MapEnlargerModel MapEnlargerModel { get; }
        public HerosStatisticsModel HerosStatisticsModel { get; }

        public void AddRange(IReadOnlyList<IViewModelObserver> viewModelObservers)
        {
            _viewModelObservers.AddRange(viewModelObservers);
        }

        public void AddRange(IReadOnlyList<IInputController> inputController)
        {
            _inputControllers.AddRange(inputController);
        }

        public void UpdateView()
        {
            _viewModelObservers.ForEach(x => x.UpdateView());
        }
    }
}
