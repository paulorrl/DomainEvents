namespace DomainEventValidation.Application.Interface.Base
{
    public interface IBaseApplicationService
    {
        bool HasNotification();

        bool Commit();

        void RollBack(string message);

        void RollBack();
    }
}