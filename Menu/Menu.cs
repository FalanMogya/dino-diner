using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Sides;

namespace DinoDiner.Menu
{
    public class Menu
    {
        public List<IMenuItem> AvaliableMenuItems
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new JurassicJava());
                avaliable.Add(new Sodasaurus());
                avaliable.Add(new Tyrannotea());
                avaliable.Add(new Water());
                avaliable.Add(new Brontowurst());
                avaliable.Add(new DinoNuggets());
                avaliable.Add(new PrehistoricPBJ());
                avaliable.Add(new PterodactylWings());
                avaliable.Add(new SteakosaurusBurger());
                avaliable.Add(new TRexKingBurger());
                avaliable.Add(new VelociWrap());
                avaliable.Add(new Fryceritops());
                avaliable.Add(new MeteorMacAndCheese());
                avaliable.Add(new MezzorellaSticks());
                avaliable.Add(new Triceritots());
                avaliable.Add(new CretaceousCombo(new Brontowurst()));
                avaliable.Add(new CretaceousCombo(new DinoNuggets()));
                avaliable.Add(new CretaceousCombo(new PrehistoricPBJ()));
                avaliable.Add(new CretaceousCombo(new PterodactylWings()));
                avaliable.Add(new CretaceousCombo(new SteakosaurusBurger()));
                avaliable.Add(new CretaceousCombo(new TRexKingBurger()));
                avaliable.Add(new CretaceousCombo(new VelociWrap()));
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableEntrees
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new Brontowurst());
                avaliable.Add(new DinoNuggets());
                avaliable.Add(new PrehistoricPBJ());
                avaliable.Add(new PterodactylWings());
                avaliable.Add(new SteakosaurusBurger());
                avaliable.Add(new TRexKingBurger());
                avaliable.Add(new VelociWrap());
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableSides
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new Fryceritops());
                avaliable.Add(new MeteorMacAndCheese());
                avaliable.Add(new MezzorellaSticks());
                avaliable.Add(new Triceritots());
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableDrinks
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new JurassicJava());
                avaliable.Add(new Sodasaurus());
                avaliable.Add(new Tyrannotea());
                avaliable.Add(new Water());
                return avaliable;
            }
        }

        public List<IMenuItem> AvaliableCombos
        {
            get
            {
                List<IMenuItem> avaliable = new List<IMenuItem>();
                avaliable.Add(new CretaceousCombo(new Brontowurst()));
                avaliable.Add(new CretaceousCombo(new DinoNuggets()));
                avaliable.Add(new CretaceousCombo(new PrehistoricPBJ()));
                avaliable.Add(new CretaceousCombo(new PterodactylWings()));
                avaliable.Add(new CretaceousCombo(new SteakosaurusBurger()));
                avaliable.Add(new CretaceousCombo(new TRexKingBurger()));
                avaliable.Add(new CretaceousCombo(new VelociWrap()));
                return avaliable;
            }
        }

        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < AvaliableMenuItems.Count; i++)
            {
                str += AvaliableMenuItems[i].ToString() + "\n";
            }

            return str;
        }
    }
}
