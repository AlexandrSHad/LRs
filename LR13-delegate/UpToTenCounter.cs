
namespace LR13_delegate
{
    public class UpToTenCounter
    {
        public delegate void CounterSwitchHandler();
        public event CounterSwitchHandler OnSwitch;

        public void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                RaiseOnSwitch();
            }
        }

        protected void RaiseOnSwitch()
        {
            if (OnSwitch != null)
            {
                OnSwitch();
            }
            //OnSwitch?.Invoke();
        }
    }
}
