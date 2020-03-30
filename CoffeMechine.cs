using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoffeMechine
{
    class CoffeMechine
    {
        private CoffePowder coffePowder;
        private WaterGalon waterGalon;
        private Milk miLk;

        public CoffeMechine(CoffePowder powder, WaterGalon galon, Milk miLk)
        {
            this.waterGalon = galon;
            this.coffePowder = powder;
            this.miLk = miLk;
        }

        public String makeEsspresso()
        {
            if (!this.waterGalon.isAvailable())
            {
                return "sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }


            this.waterGalon.makeOneCup();
            this.coffePowder.makeOneCup();
            return "Yey! your coffe is ready";
        } 
        
        public String makeCappucino()
        {
            if (!this.waterGalon.isavailable())
            {
                return "sorry, the water is empty";
            }
            if (!this.coffePowder.isAvailable())
            {
                return "Sorry, the coffe is empty";
            }
            if (!this.miLk.isAvailable())
            {
                return "Sorry, the milk is empty";
            }


            this.waterGalon.makeonecup();
            this.coffePowder.makeOneCup();
            this.miLk.makeonecup();
            return "Yey! your cappucino is ready";
        }
      
        public String checkAvailability()
        {
            return $"the water :{this.waterGalon.getVolume()} and the coffe powder : {this.coffePowder.getNetto()} and the milk : {this.miLk.getVolume()}";
        }
    }
}
