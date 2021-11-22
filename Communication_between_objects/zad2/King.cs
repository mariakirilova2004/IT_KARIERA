using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    public delegate void AttackedKingEventHandler(object sender, AttackedKingEventArgs args);
    class King
    {
        public event AttackedKingEventHandler AttackedKing;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public King(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            OnAttackedKing();
        }
        private void OnAttackedKing()
        {
            Console.WriteLine($"King {this.Name} is under attack!");
            if (this.AttackedKing != null)
            {
                this.AttackedKing(this, new AttackedKingEventArgs(this.Name));
            }
        }   
    }
}
