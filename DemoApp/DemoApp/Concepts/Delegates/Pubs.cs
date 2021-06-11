namespace DemoApp.Concepts.Delegates
{
    public class Pubs
    {
        public delegate void NotifyWhenPubsDelegate(string msg);

        public NotifyWhenPubsDelegate notifyDelegate = null;

        public void Register(Subs sub)
        {
            notifyDelegate += sub.NotifyMeByEmail;
            notifyDelegate += sub.NotifyMeByText;
        }

        public void Publish()
        {
            notifyDelegate("New Vedio has been uploaded");
        }
    }
}