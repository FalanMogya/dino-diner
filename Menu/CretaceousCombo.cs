using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Entrees;
using DinoDiner.Menu.Drinks;
using DinoDiner.Menu.Sides;
using System.ComponentModel;

namespace DinoDiner.Menu
{
   /// <summary>    
   /// A class representing a combo meal    
   /// </summary>    
   public class CretaceousCombo : IMenuItem, IOrderItem, INotifyPropertyChanged
   {
        // Backing Variables        
        private Size size;

        /// <summary>
        /// The PropertyChanged event handler; notifies of canges to the Price,
        /// Description, and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        // Helperfunction for notifying of property changes
        private void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Gets any special preparation instructions
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Special);
                ingredients.Add(Side.ToString());
                ingredients.AddRange(Side.Special);
                ingredients.Add(Drink.ToString());
                ingredients.AddRange(Drink.Special);
                return ingredients.ToArray();
            }
        }

        private Entree entree;

        /// <summary>        
        /// Gets and sets the entree        
        /// </summary>        
        public Entree Entree
        {
            get
            {
                return entree;
            }
            set
            {
                entree = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Ingredients");
            }
        }

        private Side side = new Fryceritops();

        /// <summary>        
        /// Gets and sets the side        
        /// </summary>        
        public Side Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
            }
        }

        private Drink drink = new Sodasaurus();

        /// <summary>        
        /// Gets and sets the drink        
        /// </summary>        
        public Drink Drink
        {
            get
            {
                return drink;
            }
            set
            {
                drink = value;
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
            }
        } 
        
        /// <summary>        
        /// Gets the price of the combo        
        /// </summary>        
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>        
        /// Gets the calories of the combo        
        /// </summary>        
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }
        
        /// <summary>        
        /// Gets or sets the size of the combo        
        /// </summary>        
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChange("Price");
                NotifyOfPropertyChange("Special");
                NotifyOfPropertyChange("Description");
            }
        }
        
        /// <summary>        
        /// Gets the list of ingredients for the combo        
        /// </summary>        
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        } 
        
        /// <summary>        
        /// Constructs a new combo with the specified entree        
        /// </summary>        
        /// <param name="entree">The entree to use</param>        
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
        }

        /// <summary>
        /// Returns a string representing this instance
        /// </summary>
        /// <returns>The combo as a string</returns>
        public override string ToString()
        {
            return $"{Entree} Combo";
        }

        public string Description
        {
            get { return this.ToString(); }
        }
    }
}
