import sys
import smtplib
from email.message import EmailMessage

def send_email(message):
    email = EmailMessage()
    email['From'] = "test@example.com"
    email['To'] = "recipient@example.com"
    email['Subject'] = "Backup Notification"
    email.set_content(message)

    #test
    print("Simulated Email Content:")
    print(f"From: {email['From']}")
    print(f"To: {email['To']}")
    print(f"Subject: {email['Subject']}")
    print(f"Message: {message}")

    # UNCOMMENT FOR FUNCTIONAL SEND
    # try:
     #   with smtplib.SMTP_SSL("smtp.gmail.com", 465) as smtp:
       #     smtp.login("tester@example.com", "test_password")
        #    smtp.send_message(email)
       # print("Email sent successfully.")
   # except Exception as e:
    #    print(f"Error sending email: {e}") 

if __name__ == "__main__":
    msg = sys.argv[1] if len(sys.argv) > 1 else "Backup script ran."
    send_email(msg)
