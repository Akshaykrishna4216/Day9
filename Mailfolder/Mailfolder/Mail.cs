using System;


namespace Mailfolder
{
     class Mail
    {
        private long _id;
        public long Id { get { return _id; } set { _id = value; } }

        private string _to;
        public string To
        { get { return _to; } set { _to = value; } }

        private string _from;
        public string From
        { get { return _from; } set { _from = value; } }

        private string _subject;
        public string Subject
        { get { return _subject; } set { _subject = value; } }

        private string _content;
        public string Content { get { return _content; } set { _content = value; } }

        private DateTime _recieveddate;
        public DateTime RecievedDate { get {  return _recieveddate; } set { _recieveddate = value; } }

        private double _size;
        public double Size { get { return _size; } set { _size = value; } }

        public Mail() { }
        public Mail(long _id, string _to, string _from, string _subject, string _content, DateTime _recieveddate, double _size)
        {
            Id = _id;
            To = _to;
            From = _from;
            Subject = _subject;
            Content =_content;
            RecievedDate = _recieveddate;
            Size = _size;
        }

       

        public override string ToString()
        {
            return $"Id:{_id},To:{_to},From:{_from},Subject:{_subject},Content:{_content},RecievedDate:{_recieveddate.ToString("dd-mm-yyyy")},Size:{_size}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
