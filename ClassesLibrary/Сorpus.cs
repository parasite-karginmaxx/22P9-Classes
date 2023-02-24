//https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit

namespace ClassesLibrary
{
	public class corpus
	{
		public string? Title;
		public string? Address;
		public readonly employee commandant;
		public employee commandant {get => commandant;}
		public readonly  Organization organization;
		public Organization organization{get => organization;}
        public corpus(string? Title,string? Address,employee commandant, Organization organization)
		{
			this.Title = Title;
			this.Address = Address;
			this.organization = organization;
			this.commandant = commandant;
		}
	}
}
