using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheSlum.Interfaces;

namespace TheSlum.Classes
{
    class Healer : Character,IHeal
    {
        private int healingPoints;

        public Healer(string id, int x, int y, Team team) : base(id, x, y, 75, 50,team,6)
        {
            this.HealingPoints = 60;
        }

        public override Character GetTarget(IEnumerable<Character> targetsList)
        {
            var target = targetsList.OrderBy(s => s.HealthPoints).FirstOrDefault(s => s.Team == this.Team && s.IsAlive && s != this);
            return target;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            this.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            this.RemoveItemEffects(item);
        }

        public int HealingPoints
        {
            get { return this.healingPoints; }
            set { this.healingPoints = value; }
        }

        public override string ToString()
        {
            return "Class: " + this.GetType().ToString().Replace("TheSlum.Classes.", "") + "\n" + base.ToString() + ", Healing: " + this.HealingPoints;
        }

    }
}
