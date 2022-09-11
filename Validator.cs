using System.Net.Mail;

namespace AbstractHw
{
    internal class Validator: IValidator
    {
        public bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }

            catch(FormatException ex)
            {
                // Log the error
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
