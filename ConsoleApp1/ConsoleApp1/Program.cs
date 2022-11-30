namespace ja
{

    class mirko
    {
        private string _name;
        private string _lastname;

        public mirko(string name, string lastname) {
            _name = name;
            _lastname = lastname;
        
        
        
        
        }

        public string Value { get; private set; }

       public string name
        {
            get { return _name; }


            set {_name=value; }


        }

        public string lastname
        {
            get { return _lastname; }


            set { _lastname = value; }


        }


    }



    class ja : mirko
    {
        public ja(string name, string lastname) : base(name, lastname)
        {
        }




        public static void Main(string[] args)
        {
            ja j = new ja("Mirko","Antunovic");

            Console.WriteLine("Vase ime je "+j.name+" a vase prezime je "+j.lastname);
        }
    }

    

}