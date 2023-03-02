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

        
        //OneYearPasses()
        // o Træets alder øges med 1 (age-feltet)
        // o Træet højde øges med 2, hvis træets alder er under 80, ellers ikke(height-feltet)
        // o Træet er i live, hvis træets alder er under 80, ellers dødt(treeAlive)
        // o Træet giver ikke frugt første år, men derefter øges dets produktion med 5
        // appelsiner for hvert år(dvs. 5 appelsiner 2. år, 10 appelsiner det 3. år, 15 appelsiner det 4. år osv.).
        // Frugt fra forrige år føres ikke med over til et nyt år(numOranges-feltet)



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


        // •	EatOrange(count : int): denne operation simulerer, at der spises det antal appelsiner, der er 
        // angivet i count-parameteren fra årets høst, hvis der altså er så mange appelsiner tilbage på træet 
        // (orangesEaten-feltet)

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
