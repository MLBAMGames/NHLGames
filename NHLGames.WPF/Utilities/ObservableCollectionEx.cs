using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace NHLGames.WPF.Utilities
{
    public class ObservableCollectionEx<T> : ObservableCollection<T> where T : INotifyPropertyChanged
    {
        public new event PropertyChangedEventHandler PropertyChanged;

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            Unsubscribe(e.OldItems);
            Subscribe(e.NewItems);
            base.OnCollectionChanged(e);
        }

        protected override void ClearItems()
        {
            foreach (T element in this)
                element.PropertyChanged -= ContainedElementChanged;

            base.ClearItems();
        }

        private void Subscribe(IList iList)
        {
            if (iList != null)
            {
                foreach (T element in iList)
                    element.PropertyChanged += ContainedElementChanged;
            }
        }

        private void Unsubscribe(IList iList)
        {
            if (iList != null)
            {
                foreach (T element in iList)
                    element.PropertyChanged -= ContainedElementChanged;
            }
        }

        private void ContainedElementChanged(object sender, PropertyChangedEventArgs e)
        {
            var ex = new PropertyChangedEventArgsEx(e.PropertyName, sender);
            PropertyChanged?.Invoke(this, ex);
        }
    }

    public class PropertyChangedEventArgsEx : PropertyChangedEventArgs
    {
        public object Sender { get; private set; }

        public PropertyChangedEventArgsEx(string propertyName, object sender)
            : base(propertyName)
        {
            this.Sender = sender;
        }
    }
}