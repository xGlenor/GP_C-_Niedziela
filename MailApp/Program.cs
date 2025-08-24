using MailKit.Net.Smtp;
using MimeKit;
using MimeKit.Text;

var message = new MimeMessage();

var from = new MailboxAddress("Grzegorz Duraj", "kontakt@gduraj.pl");
message.From.Add(from);


var to = new MailboxAddress("Andrzej", "andrzej@gduraj.pl");
message.To.Add(to);
message.Subject = "Testowa wiadomośc wysłana od grzesia";
message.Body = new TextPart(TextFormat.Plain)
{
    Text = """
        Hej Andrzej

        Testujemy sobie działanie maila w C#

    """
};


using var smtp = new SmtpClient();
await smtp.ConnectAsync("frog03.mikr.us", 20167);
await smtp.SendAsync(message);
await smtp.DisconnectAsync(true);
Console.WriteLine("Mail send");