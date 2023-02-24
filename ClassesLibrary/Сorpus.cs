

namespace ClassesLibrary
{
	public class corpus
	{
		public string Title;
		public string Address;
		public employee commandant;
		public Organization organization;
        public corpus(string Title,string Address,employee commandant, Organization organization)
		{
			this.Title = Title;
			this.Address = Address;
			this.organization = organization;
			this.commandant = commandant;
		}
	}
}