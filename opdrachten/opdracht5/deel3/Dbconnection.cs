class Dbconnection
    {
        private static Dbconnection _instance;

        //constructor
        protected Dbconnection()
        {
        }

        public static Dbconnection Instance()
        {
            if (_instance == null)
            {
            _instance = new Dbconnection();
            }

            return _instance;
        }
    }
