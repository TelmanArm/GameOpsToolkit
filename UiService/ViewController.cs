using UnityEngine;

namespace Core.UI
{
    public class ViewController : PresentController
    {
        public ViewController(BasePresenter[] basePresenters, Transform generatePosition) : base(basePresenters, generatePosition)
        {
        }
    }
}
