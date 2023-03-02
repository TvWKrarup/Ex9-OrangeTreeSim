using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    
    public class OrangeTree
    {
        // Attributter
        private int _age;
        private int _height;
        private bool _treeAlive;
        private int _numOranges;
        private int _orangesEaten;


        public int Age
        {   
            get { return _age; }
            set
            { 
                if (value >= 0)
                {
                    _age = value;
                }
            } 
        }

        public int Height
        { 
            get { return _height; } 
            set { _height = value; } 
        }
        public bool TreeAlive
        {
            get { return _treeAlive; }
            set { _treeAlive = value; }
        }
        public int NumOranges
        { 
            get { return _numOranges;} 
        }
        public int OrangesEaten
        {
            get { return _orangesEaten; }
        }

        public void OneYearPasses()
        {
            _orangesEaten = 0;   
            _age++;
            if (_age <= 79)
            {
                _height += 2;
                //_treeAlive = true;
            } 
            else
            {
                _treeAlive = false;
            }
          
            if (_age <= 79 && _age >= 2)
            {
                _numOranges = (Age-1) * 5;    
            }
            else
            {
                _numOranges = 0;
            }    
        }

        public void EatOrange(int count)
        {
            if (count <= _numOranges)
            {
                _orangesEaten += count;
                _numOranges -= count;     
            }
        }

    }
}
