using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace LearnTwilio
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("hello World");
            var accountSid=secrets.AccountSID;
            var authtoken=secrets.AuthToken;
            var toNumber=secrets.ToNumber;
            var fromNumber=secrets.FromNumber;

            TwilioClient.Init(accountSid,authtoken);

            var message = MessageResource.Create(
                to: new PhoneNumber(toNumber),
                from:new PhoneNumber(fromNumber),
                body: "Hey you have got the GREAT CR!!!"
            );
            Console.WriteLine(message.Sid);
        }
    }
}