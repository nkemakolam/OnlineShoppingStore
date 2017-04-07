namespace OnlineShoppingStore.Domain.Entities
{
    public class EmailSettings
    {
        public string MailToAddress = "nkemakolamnnadi3@gmail.com";
        public string MailFromAddress = "nkemakolamnnadi3@gmail.com";
        public bool UseSsl = true;
        public string Username = "nkemakolamnnadi3@gmail.com";
        public string Password = "ghosts123";
        public string ServerName = "smtp.gmail.com";
        public int ServerPort = 587;
        public bool WriteAsFile = false;
        public string FileLocation = @"c:\onestop_store_emails";
    }
}