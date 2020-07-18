using System.Configuration;
using System.Net;
using System.Net.Mail;

public class EmailSender
{
    private string mailFromAddress = ConfigurationManager.AppSettings["MailFromAddress"];
    private bool useSsl = bool.Parse(ConfigurationManager.AppSettings["UseSsl"]);
    private string userName = ConfigurationManager.AppSettings["UserName"];
    private string password = ConfigurationManager.AppSettings["Password"];
    private string serverName = ConfigurationManager.AppSettings["ServerName"];
    private int serverPort = int.Parse(ConfigurationManager.AppSettings["ServerPort"]);
    private string findPassword;
    private string mailToAddress = "";

    public EmailSender(string address, string pwd)
    {
        mailToAddress = address;
        findPassword = pwd;
    }

    public void Send()
    {
        using (var smtpClient = new SmtpClient())
        {
            smtpClient.EnableSsl = useSsl;
            smtpClient.Host = serverName;
            smtpClient.Port = serverPort;
            smtpClient.Credentials = new NetworkCredential(userName, password);
            string body = "您登录MyPetShop的密码已重置为：" + findPassword;
            MailMessage mailMessage = new MailMessage(
                          mailFromAddress,
                          mailToAddress,
                          "MyPetShop密码重置",
                          body);
            smtpClient.Send(mailMessage);
        }
    }
}