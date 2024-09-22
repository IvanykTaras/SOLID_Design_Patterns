using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Patterns.Behavioral.State
{
    public class CardInserted : State
    {
        public CardInserted(Context context) : base(context)
        {
        }

        public override void EjectCard()
        {
            Console.WriteLine("Card ejected");
            _context.ChangeState(new NoCard(_context)) ;
        }

        public override void InsertCard()
        {
            Console.WriteLine("You have already inserted card");
        }

        public override void InsertPin(int pin)
        {
            if (pin == 8888) {
                Console.WriteLine("Correct pin insert");
                _context.ChangeState(new PinInserted(_context));
            }
            else
            {
                Console.WriteLine("Incorect pin insert");
                EjectCard();
            }
        }

        public override void WithdrawCash(int amount)
        {
            Console.WriteLine("Insert PIN first");
        }
    }
}
