using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MailKit.Net.Smtp;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TerraHomes
{
    public partial class frmForgotPassword : Form
    {
        string OTPstring;
        string email;
        public frmForgotPassword()
        {
            InitializeComponent();
        }
        private string OTP()
        {
            string otpSource = "1234567890abcdefghijklmnopqrstuvwxyz";
            Random rnd = new Random();
            string otp = "";

            for(int i = 0;i<6;i++)
            {
                int otpchar = rnd.Next(0, otpSource.Length + 1);
                otp += otpSource[otpchar];
            }

            return otp;
        }
        private void SendEmail(string email)
        {
            string msg = OTP();
            this.OTPstring = msg;
            string senderEmail, senderPass, receiverEmail;
            receiverEmail = email;
            this.email = email;

            senderEmail = "philipjohn.segarra@gmail.com";
            senderPass = "wmit qzng vptn noia";

            MimeMessage message = new MimeMessage(); // Creating object for Message
            message.From.Add(new MailboxAddress("TerraHomes-OTP", senderEmail)); //Sender's information
            message.To.Add(MailboxAddress.Parse(receiverEmail)); //Receiver's Information

            message.Subject = "One-Time-Password"; //Email's Subject

            //Email's Body
            message.Body = new TextPart("plain") //Plain text
            {
                Text = msg  //MSG = OTP
            };

            using (var client = new SmtpClient())
            {
                try
                {
                    client.Connect("smtp.gmail.com", 465, true); //Gmail's smtp server, PORT: 465
                    client.Authenticate(senderEmail, senderPass); //Login sender's email and password
                    client.Send(message); //
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to generate OTP, please try again");
                    return;
                }
                finally
                {
                    client.Disconnect(true); // always Disconnect the service.
                    client.Dispose(); //Releases all resource used by the MailService object.
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SendEmail(txtEmail.Text);
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(OTPstring == txtOTP.Text)
            {
                pnlNewPass.Visible = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            UsersDB.UpdatePassword(this.email, txtNewPassword.Text);
        }
    }
}
