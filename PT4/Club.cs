using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT4
{
    public delegate void ActionDelegate();


    public class Club<T> : IEnumerable<T> where T : IPlayer
    {
        private List<T> players = new List<T>();

        private event ActionDelegate AttackEvent;
        private event ActionDelegate DefenseEvent;

        public void Add(T player)
        {
            players.Add(player);
            double average = (player.Attack + player.Defense + player.Samina + player.Speed + player.Power) / 5.0;

            if (average > 80)
            {
                AttackEvent += player.GetInfor;
            }
            else if (average > 60 && average <= 80)
            {
                DefenseEvent += player.GetInfor;
            }
        }

        public void RaiseAttackEvent()
        {
            if (AttackEvent != null)
            {
                AttackEvent.Invoke();
            }
            else
            {
                Console.WriteLine("No players with average points above 80.");
            }
        }

        public void RaiseDefenseEvent()
        {
            if (DefenseEvent != null)
            {
                DefenseEvent.Invoke();
            }
            else
            {
                Console.WriteLine("No players with average points between 60 and 80.");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            return players.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
