﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
    {
    public class BusinessEntity
        {
        private int _ID;

        private States _State;
    
        //Enumeración
        
        public enum States { Deleted, New, Modified, Unmodified }

        public BusinessEntity() 
        {
        this.State = States.New;     
        }


        //Propiedades

        public int ID
        {

        get {
            return _ID;
            }
        set
            {
            _ID = value;

            }     
        }
 
        public States State
        {
        
        get {
            return _State;
            }
        set
            {
            _State = value;

            }     
        }
    
   }
 }
