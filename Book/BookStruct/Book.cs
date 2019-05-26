using System;

namespace BookStruct
{
    public struct Book
    {
        public string _name;
        private string _id;

        public string Name
        {
            get
            {
                return _name;
            }
            private set
            {
                _name = value;
            }
        }
        public string Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }
        public Book(string name, string id)
        {
            _name = name;
            _id = id;
        }

        public string LocalId
        {
            get
            {
                return string.Format("{0}_{1}", Name, _id);
            }
        }
    }
}
