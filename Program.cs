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




}









