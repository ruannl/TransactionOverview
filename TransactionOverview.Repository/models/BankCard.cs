namespace TransactionOverview.Repository.models
{
    public class BankCard : EntityId
    {
        public Account Account { get; set; }
        public string CardNumber { get; set; }
        public CardHolder CardHolder { get; set; }
    }
}