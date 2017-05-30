using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorf {
    class Program {
        static void Main(string[] args) {
            List<UserError> errors = new List<UserError>();
            for(int i = 0; i < 3; i++) {
                errors.Add(new NumericInputError());

                errors.Add(new TextInputError());
                errors.Add(new ProgramInputError());
                errors.Add(new CatInputError());
                errors.Add(new SleepInputError());
            }

            int c = 0;
            foreach(var e in errors) {
                Console.WriteLine("{1}", c, e.UEMessage());
                c++;
            }


        }
    }
}
