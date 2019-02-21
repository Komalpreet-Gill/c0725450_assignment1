using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725450_week07
{



    class CountrySide
    {
        static void Main()
        {
            new CountrySide().Run();
            
        }
        public void Run()
        {
            
            Alst = new Village("Alst", false);
            Schvenig = new Village("Schvenig", false);
            Wessig = new Village("Wessig", true);

            Alst.distanceToEastVillage = 19;
            Alst.distanceToWestVillage = 14;
            Alst.west = Schvenig;
            Alst.east = Wessig; 

            //Schvenig.distanceToNextVillage = 0;
            Schvenig.west = null;
            Schvenig.east = null;


            //Alst.distanceToNextVillage = 14;
            Wessig.west = null;
            Wessig.east = null;
            this.TravelVillages(Alst);
        }
        public void TravelVillages(Village currentVillage)
        {
            try
            {

                if (currentVillage.isAstrildgeHere)
                {
                    Console.WriteLine("I found Dear Astrildge in {0}", currentVillage.VillageName);
                    Console.WriteLine("***Feeling Happy****");

                    return;
                }
                TravelVillages(currentVillage.west);
                TravelVillages(currentVillage.east);
            }
            catch(NullReferenceException nre)
            {
                Console.WriteLine("Here be Dragons");
            }

        }
        // Create the LinkedList to reflect the Map in the PowerPoint Instructions
        Village Maeland;
        Village Helmholtz;
        Village Alst;
        Village Wessig;
        Village Badden;
        Village Uster;
        Village Schvenig;

    }

    class Village
    {
        public Village(string _villageName, bool _isAHere)
        {
            isAstrildgeHere = _isAHere;
            VillageName = _villageName;
        }

        public Village west;
        public Village east;
        public Village temp;
        public  string VillageName;
        //public int distanceToNextVillage;
        public int distanceToEastVillage;
        public int distanceToWestVillage;
        //public int distanceToPreviousVillage;
        public bool isAstrildgeHere;
    }
}

