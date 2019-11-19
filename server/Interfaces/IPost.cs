namespace Journal.Interfaces
{
	public interface IPost
	{
		public int Id { get; set; }
		public string Timestamp { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
	}
}