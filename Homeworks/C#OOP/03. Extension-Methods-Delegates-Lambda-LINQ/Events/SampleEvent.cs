namespace Events
{
    public class SampleEvent
    {
        private string sampleMessage;

        public SampleEvent(string text)
        {
            this.SampleMessage = text;
        }
        
        public string SampleMessage
        {
            get { return this.sampleMessage; }
            set { this.sampleMessage = value; }
        } 
    }
}
