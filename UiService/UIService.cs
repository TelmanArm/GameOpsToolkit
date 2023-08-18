using Core.UI.Base;
using UnityEngine;

namespace Core.UI
{
    public class UIService : MonoBehaviour
    {
        [SerializeField] private RectTransform popupHolder;
        [SerializeField] private RectTransform viewHolder;
        [SerializeField] private BasePresenter[] popups;
        [SerializeField] private BasePresenter[] views;

        public PopupController PopupController;
        public ViewController ViewController;

        private void Awake()
        {
            popupHolder.FitInSafeArea();
            viewHolder.FitInSafeArea();
            PopupController =new PopupController(popups, popupHolder);
            ViewController =new ViewController(views, viewHolder);
            
        }
    }
}