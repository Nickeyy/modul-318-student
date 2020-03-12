using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportAppGUI
{
    class SendMail
    {
        private string _subject;
        private string _body;

        public string Subject
        {
            get { return _subject; }
            set { _subject = value;}
        }

        public string Body
        {
            get { return _body; }
            set { _body = value; }
        }

        public void MailSender()
        {
            System.Diagnostics.Process.Start(string.Format(@"mailto:?subjects" + Subject + "&body=" + Body));
        }
    }
}
