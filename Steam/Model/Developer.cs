namespace Steam.Model
{
    // 1:1, 1:N, N:N
    // Unidirecional, Bidirecional
    public record class Developer
    {

        public required Guid Id
        {
            get; set;
        }

        public required string Name
        {
            get; set;
        }
    }
}