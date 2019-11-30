using System;
namespace MONOPOLY_D_PATTERN
{
    class Jail : Case
    {
        public Jail(int id, string stateCase, string name):base(id, stateCase,name)
        {
        }
        public override int Id
        {
            get
            {
                return this.id;
            }
        }
        public override string StateCase
        {
            get { return this.stateCase; }
        }
        public override string NameCase
        {
            get { return this.nameCase; }
        }
		
		public override string ToString()
        {
            return "You are on case number " + this.id + " .The name of the case is : " + this.nameCase;
        }
    }
}
