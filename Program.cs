using System;
using System.Xml.Linq;

namespace ProgramTP2
{
    class Evaluation   // Base class
    {

        private string name;
        private DateTime datedebut;
        private int NotGlobale;



        public Evaluation()
        {
           name= "exam C sharp";
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public DateTime datedebu  // property
        {
            get { return datedebu; }   // get method
            set { datedebu = value; }  // set method
        }
        public int Not  // property
        {
            get { return NotGlobale; }   // get method
            set { NotGlobale = value; }  // set method
        }







    }





    class Quistion  // Base class
    {

        private string name;
        private DateTime datedebut;
        private int NotGlobale;



        public Evaluation()
        {
            name = "exam C sharp";
        }
        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
        public DateTime datedebu  // property
        {
            get { return datedebu; }   // get method
            set { datedebu = value; }  // set method
        }
        public int Not  // property
        {
            get { return NotGlobale; }   // get method
            set { NotGlobale = value; }  // set method
        }

    }


    class QCM: Quistion  // Base class
    {

       
        private DateTime duree;
        private int NBR_Q;
        private int Not;



        public QCM()
        {}
        public int NBR_Q // property
        {
            get { return NBR_Q; }   // get method
            set { NBR_Q = value; }  // set method
        }
        public DateTime duree  // property
        {
            get { return duree; }   // get method
            set { duree = value; }  // set method
        }
        public int Not  // property
        {
            get { return Not; }   // get method
            set { Not= value; }  // set method
        }

    }

    class vrais_faaux : Quistion  // Base class
    {


        private DateTime duree;
        private int NBR_Q;
        private int NotQ;



        public vrais_faaux()
        { }
        public int NBR_Q // property
        {
            get { return NBR_Q; }   // get method
            set { NBR_Q = value; }  // set method
        }
        public DateTime duree  // property
        {
            get { return duree; }   // get method
            set { duree = value; }  // set method
        }
        public int NotQ // property
        {
            get { return NotQ; }   // get method
            set { NotQ = value; }  // set method
        }

    }

    class QDirect: Quistion  // Base class
    {


        private DateTime duree;
        private int NBR_Q;



        public QCM()
        { }
        public int NBR_Q // property
        {
            get { return NBR_Q; }   // get method
            set { NBR_Q = value; }  // set method
        }
        public DateTime duree  // property
        {
            get { return duree; }   // get method
            set { duree = value; }  // set method
        }
        public int Not  // property
        {
            get { return Not; }   // get method
            set { Not = value; }  // set method
        }


    }

    class Proposition: QCM  // Base class
    {


        
        private  string pourcentage_certitude;
        private int NumQ;
        private int notP;


        
        public int NumQ // property
        {
            get { return NumQ; }   // get method
            set { NumQ = value; }  // set method
        }
        public string pourcentage_certitude // property
        {
            get { return pourcentage_certitude; }   // get method
            set { pourcentage_certitude = value; }  // set method
        }
        public int notP  // property
        {
            get { return notP; }   // get method
            set { notP = value; }  // set method
        }

    }


}









