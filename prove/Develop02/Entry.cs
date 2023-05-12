namespace Develop02
{
    public class Entry
    { 

        public string prompt;
        public string response;
        public string date;

        public string GetPrompt()
        {
           return prompt;
        }
        public string GetResponse()
        {
            return response;
        }
        public string GetDate()
        {
           return date;
        }
        public void StorePrompt(string prompt)
        {
            this.prompt = prompt;
        }
        public void StoreResponse(string response)
        {
            this.response = response;
        }
        public void StoreDate(string date)
        {
            this.date = date;
        }

   
    }

}