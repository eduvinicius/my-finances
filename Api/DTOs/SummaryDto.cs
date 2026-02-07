using MyFinances.Domain.Enums;

namespace MyFinances.Api.DTOs
{
    public class SummaryDto
    {
        public decimal TotalBalance { get; set; }
        public IEnumerable<AccountSummaryDto> Accounts { get; set; } = [];
    }

    public class AccountSummaryDto
    {
        public Guid AccountId { get; set; }
        public string Name { get; set; } = string.Empty;
        public TransactionType Type { get; set; }
        public decimal Balance { get; set; }
    }
}
